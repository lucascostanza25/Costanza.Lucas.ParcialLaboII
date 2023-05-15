﻿using Entidades.PPLabII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costanza.Lucas.PPLabII
{
    public partial class FrmCrearModificarVuelo : Form
    {
        Vuelos vuelo = new Vuelos();
        public FrmCrearModificarVuelo()
        {
            InitializeComponent();
            CrearDataGridViewVuelos(MiAerolinea.listaAviones);
            dtpFecha.CustomFormat = "yyyy/MM/dd HH:mm";
            btnAceptar.Text = "Crear vuelo";
        }

        public FrmCrearModificarVuelo(Vuelos vueloModificar) : this()
        {
            PintarDatosVuelo(vueloModificar);
            btnAceptar.Text = "Editar vuelo";
            this.txtCodigo.Enabled = false;
            vuelo = vueloModificar;
        }

        protected void CrearDataGridViewVuelos(List<Aviones> listaAviones)
        {
            dgvAviones.Rows.Clear();
            dgvAviones.Columns.Clear();
            dgvAviones.Columns.Add("matricula", "Matricula");
            dgvAviones.Columns.Add("modelo", "Modelo");
            dgvAviones.Columns.Add("asientos", "Asientos");
            dgvAviones.Columns.Add("asientos_premium", "Asientos\npremium");
            dgvAviones.Columns.Add("capacidad_bodega", "Capacidad\nbodega");
            dgvAviones.Columns.Add("internet", "Internet");
            dgvAviones.Columns.Add("comida", "Comida");

            dgvAviones.Columns["matricula"].Width = 80;
            dgvAviones.Columns["modelo"].Width = 100;
            dgvAviones.Columns["asientos"].Width = 80;
            dgvAviones.Columns["asientos_premium"].Width = 80;
            dgvAviones.Columns["capacidad_bodega"].Width = 80;
            dgvAviones.Columns["internet"].Width = 50;
            dgvAviones.Columns["comida"].Width = 50;

            foreach(Aviones avion in listaAviones)
            {
                dgvAviones.Rows.Add(avion.Matricula,
                    avion.ModeloAvion,
                    avion.CantidadAsientos,
                    avion.CantidadAsientosPremium,
                    avion.CapacidadBodega,
                    avion.ServicioInternet,
                    avion.ServicioComida);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Crear vuelo")
            {
                if (CrearVuelo())
                {
                    MessageBox.Show("Vuelo creado con exito!", "Vuelo creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el vuelo", "Error al crear el vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ModificarVuelo(vuelo))
                {
                    MessageBox.Show("Vuelo modificado con exito!", "Vuelo modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el vuelo", "Error al modificar el vuelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarDestinos(int tipoVuelo)
        {
            cmbDestino.Items.Clear();
            cmbOrigen.Items.Clear();

            foreach (DestinosVuelos destino in MiAerolinea.destinoPorVuelo[tipoVuelo])
            {
                string destinoString = destino.ToString().Replace("_", " ");
                if (tipoVuelo == 1)
                {
                    cmbDestino.Items.Add(destinoString);
                    cmbOrigen.Items.Add(destinoString);
                }
                else if (tipoVuelo == 2)
                {
                    if (destino != DestinosVuelos.Buenos_aires)
                        cmbDestino.Items.Add(destinoString);
                    else if (destino == DestinosVuelos.Buenos_aires)
                        cmbOrigen.Items.Add(destinoString);
                }
            }
        }

        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {
            CargarDestinos(1);
            nudPrecio.Value = 50;
        }

        private void rbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            CargarDestinos(2);
            nudPrecio.Value = 100;
        }

        private void dgvAviones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? matricula = dgvAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
            Aviones vueloAvion = MiAerolinea.BuscarUnAvion(matricula);
            lblAvion.Text = $"Avion seleccionado: {vueloAvion.ModeloAvion} - {vueloAvion.Matricula}";
        }

        private bool CrearVuelo()
        {
            bool estado = false;

            try
            {
                string? matricula = dgvAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
                Aviones vueloAvion = MiAerolinea.BuscarUnAvion(matricula);
            
                DestinosVuelos origen, destino;
                double precio = Convert.ToDouble(nudPrecio.Value);
                List<Pasajeros> listaPasajeros = new List<Pasajeros>();
                bool vueloDuplicado = false;

                if (Enum.TryParse(cmbOrigen.Text.Replace(" ", "_"), out origen))
                {
                    if (Enum.TryParse(cmbDestino.Text.Replace(" ", "_"), out destino))
                    {
                        if(dtpFecha.Value >= DateTime.Now)
                        {
                            foreach(Vuelos vuelo in MiAerolinea.listaVuelos)
                            {
                                if (vuelo.CodigoVuelo == txtCodigo.Text)
                                {
                                    vueloDuplicado = true;
                                    break;
                                }
                            }
                            if (!vueloDuplicado)
                            {
                                MiAerolinea.listaVuelos.Add(new Vuelos(listaPasajeros, vueloAvion, dtpFecha.Value, txtCodigo.Text, origen, destino, (int)nudHoras.Value, precio));
                                estado = true;

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un avion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estado;
        }

        private void PintarDatosVuelo(Vuelos vuelo)
        {
            if (MiAerolinea.destinoPorVuelo[1].Contains(vuelo.Destino))
            {
                rbNacional.Checked = true;
                nudPrecio.Value = 50;
            }
            else if (MiAerolinea.destinoPorVuelo[2].Contains(vuelo.Destino))
            {
                rbInternacional.Checked = true;
                nudPrecio.Value = 100;
            }
            cmbOrigen.SelectedItem = vuelo.Origen.ToString().Replace("_", " ");
            cmbDestino.SelectedItem = vuelo.Destino.ToString().Replace("_", " ");
            dtpFecha.Value = vuelo.FechaVuelo;
            txtCodigo.Text = vuelo.CodigoVuelo;
            nudHoras.Value = vuelo.HorasVuelo;
            Aviones avionVuelo = vuelo.AvionVuelo;
            lblAvion.Text = $"El avion del vuelo es: {avionVuelo.ModeloAvion} - {avionVuelo.Matricula}";
        }

        private bool ModificarVuelo(Vuelos vueloModificar)
        {
            bool estado = false;

            try
            {
                string? matricula = dgvAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
                Aviones vueloAvion = MiAerolinea.BuscarUnAvion(matricula);
            
                DestinosVuelos origen, destino;
                double precio = Convert.ToDouble(nudPrecio.Value);

                if (Enum.TryParse(cmbOrigen.Text.Replace(" ", "_"), out origen))
                {
                    if (Enum.TryParse(cmbDestino.Text.Replace(" ", "_"), out destino))
                    {
                        if (dtpFecha.Value >= DateTime.Now)
                        {
                            vueloModificar.Origen = origen;
                            vueloModificar.Destino = destino;
                            vueloModificar.HorasVuelo = (int)nudHoras.Value;
                            vueloModificar.CodigoVuelo = txtCodigo.Text;
                            vueloModificar.PrecioVuelo = precio * (double)nudHoras.Value;
                            vueloModificar.AvionVuelo = vueloAvion;
                            estado = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un avion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estado;
        }
    }
}