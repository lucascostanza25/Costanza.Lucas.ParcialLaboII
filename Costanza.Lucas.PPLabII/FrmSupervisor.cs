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
    public partial class Supervisor : FrmVendedor
    {
        Vuelos vuelo;
        public Supervisor(string nombre, string apellido, string fecha, string cargo)
        {
            InitializeComponent();
            vuelo = new Vuelos();
            this.btnVenderVueloLateral.Enabled = false;
            OcultarMenu();

            lblInformacionTrabajador.Text = $"¡Bienvenido {cargo}!\n" +
                $"¡{nombre} {apellido}!\n" +
                $"Fecha: {fecha}";

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {

            FrmCrearModificarPersonas formAgregarPasajero = new FrmCrearModificarPersonas("Crear pasajero SUPERVISOR", 0, vuelo);
            formAgregarPasajero.ShowDialog();
            if(MiAerolinea.listaVuelos is not null)
                CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
            dgvPasajeros.Rows.Clear();
            
        }

        private void Supervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MiAerolinea.listaVuelos is not null)
                MiAerolinea.SerializarVuelosXml(MiAerolinea.listaVuelos);
        }
    }
}
