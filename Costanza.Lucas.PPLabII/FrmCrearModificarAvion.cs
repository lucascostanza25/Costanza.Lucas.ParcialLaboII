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
    public partial class FrmCrearModificarAvion : Form
    {
        Aviones avion;
        public FrmCrearModificarAvion()
        {
            InitializeComponent();
            btnAceptar.Text = "Crear avion";
            avion = new Aviones();
        }

        public FrmCrearModificarAvion(Aviones avionEditar) : this()
        {
            btnAceptar.Text = "Editar avion";
            PintarDatosAvion(avionEditar);
            txtMatricula.Enabled = false;
            avion = avionEditar;
        }

        private void cbInternet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbComida_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Crear avion")
            {
                if (CrearAvion())
                {
                    MessageBox.Show("Avion creado exitosamente", "Avion creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo crear el avion", "Error de creado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (btnAceptar.Text == "Editar avion")
            {
                if(ModificarAvion(avion))
                {
                    MessageBox.Show("Avion modificado exitosamente", "Avion modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar a el avion", "Error de modificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        public bool CrearAvion()
        {
            bool estado = false;
            bool avionRepetido = false;
            double asientos, bodega;
            asientos = Convert.ToDouble(nudCantidadAsientos.Value);
            bodega = Convert.ToDouble(nudCapacidadBodega.Value);

            foreach (Aviones miAvion in MiAerolinea.listaAviones)
            {
                if (miAvion.Matricula == txtMatricula.Text)
                {
                    avionRepetido = true;
                    break;
                }
            }
            if (!avionRepetido)
            {
                if (cbComida.Checked && cbInternet.Checked)
                    MiAerolinea.listaAviones.Add(new Aviones(txtMatricula.Text, asientos, true, true, bodega, txtMarcaModelo.Text));
                if (cbComida.Checked && cbInternet.CheckState == CheckState.Unchecked)
                    MiAerolinea.listaAviones.Add(new Aviones(txtMatricula.Text, asientos, true, false, bodega, txtMarcaModelo.Text));
                if (cbComida.CheckState == CheckState.Unchecked && cbInternet.Checked)
                    MiAerolinea.listaAviones.Add(new Aviones(txtMatricula.Text, asientos, false, true, bodega, txtMarcaModelo.Text));
                if (cbComida.CheckState == CheckState.Unchecked && cbInternet.CheckState == CheckState.Unchecked)
                    MiAerolinea.listaAviones.Add(new Aviones(txtMatricula.Text, asientos, false, false, bodega, txtMarcaModelo.Text));
                estado = true;
            }

            return estado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PintarDatosAvion(Aviones avionEditar)
        {
            txtMarcaModelo.Text = avionEditar.ModeloAvion;
            txtMatricula.Text = avionEditar.Matricula;
            nudCantidadAsientos.Value = (int)avionEditar.CantidadAsientos;
            nudCapacidadBodega.Value = (int)avionEditar.CapacidadBodega;
            if (avionEditar.ServicioComida && avionEditar.ServicioInternet)
            {
                cbComida.CheckState = CheckState.Checked;
                cbInternet.CheckState = CheckState.Checked;
            }
            if(!avionEditar.ServicioInternet && avionEditar.ServicioComida)
            {
                cbComida.CheckState = CheckState.Checked;
                cbInternet.CheckState = CheckState.Unchecked;
            }
            if(avionEditar.ServicioInternet && !avionEditar.ServicioComida)
            {
                cbComida.CheckState = CheckState.Unchecked;
                cbInternet.CheckState = CheckState.Checked;
            }
            if(!avionEditar.ServicioComida && !avionEditar.ServicioInternet)
            {
                cbInternet.CheckState = CheckState.Unchecked;
                cbComida.CheckState = CheckState.Unchecked;
            }
        } 
        
        private bool ModificarAvion(Aviones avionEditar)
        {
            if(nudCapacidadBodega.Value > 100)
            {
                avionEditar.ModeloAvion = txtMarcaModelo.Text;
                avionEditar.CantidadAsientos = (double)nudCantidadAsientos.Value;
                avionEditar.CapacidadBodega = (double)nudCapacidadBodega.Value;

                if (cbComida.Checked && cbInternet.Checked)
                {
                    avionEditar.ServicioComida = true;
                    avionEditar.ServicioInternet = true;
                }
                if (cbComida.Checked && cbInternet.CheckState == CheckState.Unchecked)
                {
                    avionEditar.ServicioComida = true;
                    avionEditar.ServicioInternet = false;
                }
                if (cbComida.CheckState == CheckState.Unchecked && cbInternet.Checked)
                {
                    avionEditar.ServicioComida = false;
                    avionEditar.ServicioInternet = true;
                }
                if (cbComida.CheckState == CheckState.Unchecked && cbInternet.CheckState == CheckState.Unchecked)
                {
                    avionEditar.ServicioInternet = false;
                    avionEditar.ServicioComida = false;
                }
                return true;

            }
            return false;
        }
    }
}