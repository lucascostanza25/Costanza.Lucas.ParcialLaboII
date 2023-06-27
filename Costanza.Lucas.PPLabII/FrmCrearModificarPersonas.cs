﻿using Entidades.PPLabII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costanza.Lucas.PPLabII
{
    public partial class FrmCrearModificarPersonas : Form
    {
        private int tipo = -1;
        Pasajeros miPasajero;
        Vuelos vueloPasajero;

        public FrmCrearModificarPersonas(string titulo)
        {
            InitializeComponent();

            this.Text = titulo;
            btnAceptar.Text = "Crear cliente";
            miPasajero = new Pasajeros();
            vueloPasajero = new Vuelos();
            if (cbAsientoPremium.CheckState == CheckState.Unchecked)
            {
                cmbCantidadEquipajes.Items.Clear();
                cmbCantidadEquipajes.Items.Add(1);
                nudPesoEquipajeDos.Enabled = false;
            }
        }
        /// <summary>
        /// Sobrecarga del constructor destinada para editar pasajero
        /// </summary>
        /// <param name="titulo">titulo del form</param>
        /// <param name="dni">dni del pasajero</param>
        public FrmCrearModificarPersonas(string titulo, int dni) : this(titulo)
        {
            this.Text = titulo;
            btnAceptar.Text = "Editar pasajero";
            PintarDatosPasajero(dni);
        }
        /// <summary>
        /// Sobrecarga del constructor pensado para el supervisor
        /// </summary>
        /// <param name="titulo">titulo del boton</param>
        /// <param name="dni">dni del pasajero, en este caso 0 o -1</param>
        /// <param name="vuelo">vuelo del pasajero a crear</param>
        public FrmCrearModificarPersonas(string titulo, int dni, Vuelos vuelo) : this(titulo, dni)
        {
            vueloPasajero = vuelo;
            btnAceptar.Text = titulo;
        }
        /// <summary>
        /// Metodo que pinta los datos del pasajero a editar
        /// </summary>
        /// <param name="dni">dni del pasajero</param>
        private void PintarDatosPasajero(int dni)
        {
            nudDineroDisponible.Enabled = false;
            nudDni.Enabled = false;
            miPasajero = MiAerolinea.RetornarUnPasajero(dni);


            txtApellido.Text = miPasajero.Apellido;
            txtNombre.Text = miPasajero.Nombre;
            nudDni.Value = miPasajero.Dni;
            nudEdad.Value = miPasajero.Edad;
            cmbGenero.Text = miPasajero.Genero;
            cmbCantidadEquipajes.Text = miPasajero.CantidadEquipaje.ToString();
            nudPesoEquipajeUno.Value = Convert.ToDecimal(miPasajero.PesoEquipajeUno);
            if (miPasajero.AsientoPremium)
            {
                nudPesoEquipajeDos.Value = Convert.ToDecimal(miPasajero.PesoEquipajeDos);
                cbAsientoPremium.CheckState = CheckState.Checked;
            }

        }

        private void cbAsientoPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAsientoPremium.Checked)
            {
                nudPesoEquipajeUno.Maximum = 21;
                nudPesoEquipajeDos.Maximum = 21;
                nudPesoEquipajeDos.Enabled = true;
                cmbCantidadEquipajes.Items.Clear();
                cmbCantidadEquipajes.Items.Add(1);
                cmbCantidadEquipajes.Items.Add(2);
            }
            else
            {
                nudPesoEquipajeUno.Maximum = 25;
                nudPesoEquipajeDos.Enabled = false;
                cmbCantidadEquipajes.Items.Clear();
                cmbCantidadEquipajes.Items.Add(1);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (btnAceptar.Text == "Crear cliente")
            {
                if (CrearCliente())
                {
                    MessageBox.Show("Cliente creado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo crear al cliente");
                }
            }
            else if (btnAceptar.Text == "Editar pasajero")
            {

                if (ActualizarPasajero())
                {
                    MessageBox.Show("Pasajero actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar al pasajero");
                }
            }
            else if (btnAceptar.Text == "Crear pasajero SUPERVISOR")
            {
                SupervisorAgregarPasajero(vueloPasajero);
            }


            this.Close();

        }
        /// <summary>
        /// Metodo que crea un cliente
        /// </summary>
        /// <returns>Retorna true si lo pudo crear, false si no</returns>
        private bool CrearCliente()
        {
            int dni, edad, dinero;
            dni = Convert.ToInt32(nudDni.Value);
            edad = Convert.ToInt32(nudEdad.Value);
            dinero = Convert.ToInt32(nudDineroDisponible.Value);
            bool clienteDuplicado = false;
            bool estado = false;
            bool pasajeroDuplicado = false;

            if (String.IsNullOrEmpty(txtApellido.Text) && String.IsNullOrEmpty(txtNombre.Text) && dni <= 1000 && edad <= 0)
            {
                MessageBox.Show("Por favor, verifique los campos");
            }
            else
            {
                if (MiAerolinea.listaVuelos is not null)
                {
                    foreach (Vuelos vuelo in MiAerolinea.listaVuelos)
                    {
                        foreach (Pasajeros pasajero in vuelo.ListaPasajeros)
                        {
                            if (pasajero.Dni == dni)
                            {
                                pasajeroDuplicado = true;
                                break;

                            }
                        }
                    }
                }
                if (MiAerolinea.listaClientes is not null)
                {
                    foreach (Cliente cliente in MiAerolinea.listaClientes)
                    {
                        if (cliente.Dni == dni)
                        {
                            clienteDuplicado = true;
                            break;
                        }
                    }
                    if (!pasajeroDuplicado && !clienteDuplicado)
                    {
                        if (cbAsientoPremium.Checked)
                        {
                            MiAerolinea.listaClientes.Add(new Cliente(txtApellido.Text, txtNombre.Text, dinero, dni, edad, true, cmbGenero.Text, int.Parse(cmbCantidadEquipajes.Text), (double)nudPesoEquipajeUno.Value, (double)nudPesoEquipajeDos.Value));
                        }
                        else
                        {
                            MiAerolinea.listaClientes.Add(new Cliente(txtApellido.Text, txtNombre.Text, dinero, dni, edad, false, cmbGenero.Text, 1, (double)nudPesoEquipajeUno.Value, 0));
                        }
                        MessageBox.Show("Cliente agregado correctamente");
                        estado = true;
                    }
                }
            }

            return estado;
        }

        private void cmbCantidadEquipajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidadEquipajes.SelectedIndex == 0)
            {
                nudPesoEquipajeDos.Enabled = false;
            }
            else
                nudPesoEquipajeDos.Enabled = true;
        }
        /// <summary>
        /// Metodo que actualiza un pasajero
        /// </summary>
        /// <returns>retorna tru si lo pudo modificar, false si no</returns>
        private bool ActualizarPasajero()
        {
            bool estado = false;
            miPasajero.Apellido = txtApellido.Text;
            miPasajero.Nombre = txtNombre.Text;
            miPasajero.Edad = (int)nudEdad.Value;
            miPasajero.Genero = cmbGenero.Text;
            miPasajero.CantidadEquipaje = int.Parse(cmbCantidadEquipajes.Text);
            miPasajero.PesoEquipajeUno = (double)nudPesoEquipajeUno.Value;
            miPasajero.AsientoPremium = false;
            if (cbAsientoPremium.Checked)
            {
                miPasajero.PesoEquipajeDos = (double)nudPesoEquipajeDos.Value;
                miPasajero.AsientoPremium = true;
            }
            estado = true;

            PasajerosDao.ActualizarPasajero(miPasajero);
            //Falta implementar firebase

            return estado;
        }
        /// <summary>
        /// Metodo que agrega un pasajero para el supervisor
        /// </summary>
        /// <param name="vuelo">Vuelo a agregar el pasajero</param>
        /// <returns>Retoran true si lo pudo agregar, false si no</returns>
        public bool SupervisorAgregarPasajero(Vuelos vuelo)
        {
            int dni, edad;
            double pesoEquipajeUno, pesoEquipajeDos;
            dni = Convert.ToInt32(nudDni.Value);
            edad = Convert.ToInt32(nudEdad.Value);
            pesoEquipajeUno = Convert.ToDouble(nudPesoEquipajeUno.Value);
            pesoEquipajeDos = Convert.ToDouble(nudPesoEquipajeDos.Value);
            foreach (Pasajeros pasajero in vuelo.ListaPasajeros)
            {
                if (pasajero.Dni != dni)
                {
                    if (this.tipo == 3)
                    {
                        if (cbAsientoPremium.Checked)
                        {
                            //vuelo.ListaPasajeros.Add(new Pasajeros(txtApellido.Text, txtNombre.Text, dni, edad, cmbGenero.Text, true, int.Parse(cmbCantidadEquipajes.Text), pesoEquipajeUno, pesoEquipajeDos));
                        }
                        else
                        {
                            //svuelo.ListaPasajeros.Add(new Pasajeros(txtApellido.Text, txtNombre.Text, dni, edad, cmbGenero.Text, false, 1, pesoEquipajeUno, pesoEquipajeDos));
                        }
                        MessageBox.Show("Pasajero agregado correctamente");
                        //vuelo.ActualizarDatosVuelo(vuelo.ListaPasajeros);
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
