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
    public partial class FrmVendedor : FrmInicioSesion
    {
        private DataTable dtVuelos;
        private List<Pasajeros>? listaPasajerosVuelo;
        private List<Aviones>? listaAvionesVuelo;
        public FrmVendedor(string nombre, string apellido, string fecha) : base()
        {
            InitializeComponent();
            lblInformacionVendedeor.Text = $"Bienvenido vendedor {nombre} {apellido} - Fecha: {fecha}";
            panelMenuVuelos.Visible = false;
            panelMenuEstadisticas.Visible = false;
            lblBuscarVuelo.Visible = false;
            txtCodigoVuelo.Visible = false;
            dgvDatosVuelos.Visible = false;
            panelMenuEstadisticas.Visible = false;
             
            dtVuelos = new DataTable();
            listaAvionesVuelo = new List<Aviones>();
            listaAvionesVuelo.Add(new Aviones("FJS50OP", 60, false, true, 2400, "Boeing 777", "BRC2023"));
            listaAvionesVuelo.Add(new Aviones("GLT049T", 120, true, true, 4800, "Airbus A220", "MDZ4267"));


        //    miAerolinea.SerializarAvionesJson(listaAvionesVuelo);
        //    listaPasajerosVuelo = miAerolinea.CargarPasajerosXml("Pasajeros1.xml");
        //    miAerolinea.CrearVueloNacional(DestinosNacionalesVuelos.Trelew, DestinosNacionalesVuelos.Neuquen, DateTime.Now, 11000, listaPasajerosVuelo, listaAvionesVuelo, "BRC2023");
        //    listaPasajerosVuelo = null;
        //    listaPasajerosVuelo = miAerolinea.CargarPasajerosXml("Pasajeros2.xml");
        //    miAerolinea.CrearVueloNacional(DestinosNacionalesVuelos.Mendoza, DestinosNacionalesVuelos.Iguazu, DateTime.Now, 20000, listaPasajerosVuelo, listaAvionesVuelo, "MDZ4267");
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuVuelos);
        }

        private void PintarSubMenu()
        {
            if(panelMenuVuelos.Visible  == true)
            {
                panelMenuVuelos.Visible = false;
            }
            if(panelMenuEstadisticas.Visible == true) 
            {
                panelMenuEstadisticas.Visible = false;
            }
        }

        private void MostrarMenu(Panel menu)
        {
            if(menu.Visible ==  false)
            {
                PintarSubMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btnVerVuelos_Click(object sender, EventArgs e)
        {
            lblBuscarPasajero.Visible = true;
            lblDetallesVuelo.Visible = true;
            txtDniPasajero.Visible = true;
            dgvPasajeros.Visible = true;
            lblTitulo.Visible = true;
            lblBuscarVuelo.Visible = true;
            txtCodigoVuelo.Visible = true;
            dgvDatosVuelos.Visible = true;
            lblPasajerosVuelo.Visible = true;

            PintarDataGriedView();
        }

        #region DataGridView
        private void PintarDataGriedView()
        {
            LimpiarDataGridView();
            dtVuelos.Columns.Add("Código");
            dtVuelos.Columns.Add("Origen");
            dtVuelos.Columns.Add("Destino");
            dtVuelos.Columns.Add("Fecha");
            dtVuelos.Columns.Add("Precio");
            dtVuelos.Columns.Add("Asientos disponibles");
            dtVuelos.Columns.Add("Asientos ocupados");
            dtVuelos.Columns.Add("Avion");

            dgvDatosVuelos.DataSource = null;
            dgvDatosVuelos.DataSource = dtVuelos;
            dgvDatosVuelos.Columns["Código"].Width = 100;
            dgvDatosVuelos.Columns["Origen"].Width = 200;
            dgvDatosVuelos.Columns["Destino"].Width = 200;
            dgvDatosVuelos.Columns["Fecha"].Width = 120;
            dgvDatosVuelos.Columns["Precio"].Width = 100;
            dgvDatosVuelos.Columns["Asientos disponibles"].Width = 55;
            dgvDatosVuelos.Columns["Asientos ocupados"].Width = 55;
            dgvDatosVuelos.Columns["Avion"].Width = 100;

            foreach(VuelosNacionales miVuelo in miAerolinea.listaVuelosNacionales)
            {
                DataRow row = dtVuelos.NewRow();
                row["Código"] = miVuelo.CodigoVuelo;
                row["Origen"] = miVuelo.OrigenVuelo;
                row["Destino"] = miVuelo.DestinoVuelo;
                row["Fecha"] = miVuelo.FechaVuelo;
                row["Precio"] = miVuelo.PrecioVuelosNacionales;
                row["Asientos disponibles"] = miVuelo.AsientosDisponibles;
                row["Asientos ocupados"] = miVuelo.AsientosOcupados;
                row["Avion"] = miVuelo.AvionVuelo.ModeloAvion;
                dtVuelos.Rows.Add(row);
            }
        }

        private void LimpiarDataGridView()
        {
            dtVuelos.Columns.Clear();
            dtVuelos.Rows.Clear();
            dgvDatosVuelos.DataSource = null;
            dgvDatosVuelos.DataSource = dtVuelos;
        }
        #endregion

        private void btnVenderVuelo_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatosVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Pasajeros> listaPasajerosPorVuelo = new List<Pasajeros>();
            
            //listaPasajerosVuelo.Clear();
            if(dgvDatosVuelos.SelectedRows.Count > 0)
            {
                string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["Código"].Value.ToString();
                //listaPasajerosPorVuelo = miAerolinea.RetornarPasajerosPorVuelo(codigoVueloSeleccionado);

                foreach(VuelosNacionales miVuelo in miAerolinea.listaVuelosNacionales)
                {
                    if (miVuelo.CodigoVuelo == codigoVueloSeleccionado)
                    {
                        listaPasajerosPorVuelo = miVuelo.ListaPasajeros;
                        lblPasajerosVuelo.Text = $"PASAJEROS DEL VUELO: {miVuelo.CodigoVuelo}";

                        lblInformacionVuelo.Text = miAerolinea.RetornarDatosVuelo(miVuelo);
                        break;
                    }
                }    

                dgvPasajeros.DataSource = null;
                dgvPasajeros.Rows.Clear();

                dgvPasajeros.Columns.Clear();
                dgvPasajeros.AutoGenerateColumns = true;
                dgvPasajeros.DataSource = listaPasajerosPorVuelo;
                dgvPasajeros.Refresh();
            }
        }

        private void lblBuscarPasajero_Click(object sender, EventArgs e)
        {

        }

        private void txtDniPasajero_TextChanged(object sender, EventArgs e)
        {
            int dniPasajero;

            if(int.TryParse(txtDniPasajero.Text, out dniPasajero))
            {
                Pasajeros miPasajero = miAerolinea.RetornarUnPasajero(dniPasajero);

                List<Pasajeros> listaPasajero = new List<Pasajeros>();
                listaPasajero.Add(miPasajero);

                dgvDatosVuelos.DataSource = listaPasajero;

            }
            

            //dgvPasajeros.DataSource = miPasajero;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuEstadisticas);
        }
    }
}
