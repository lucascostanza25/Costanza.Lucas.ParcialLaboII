using Entidades.PPLabII;
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
    public partial class FrmCrearModificarPersonas : Form
    {
        private int tipo = -1;
        Pasajeros miPasajero;

        public FrmCrearModificarPersonas(string titulo, int tipo, int dni)
        {
            InitializeComponent();

            this.Text = titulo;
            this.tipo = tipo;
            miPasajero = new Pasajeros();
            if (tipo == 0)
                PintarDatosPasajero(dni);
            if (tipo == 1)
            {
                if(cbAsientoPremium.CheckState == CheckState.Unchecked)
                {
                    cmbCantidadEquipajes.Items.Add(1);
                    nudPesoEquipajeDos.Enabled = false;
                }
            }
        }

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
            
            if(this.tipo == 1)
            {
                int dni, edad, dinero;
                double pesoEquipajeUno, pesoEquipajeDos;
                dni = Convert.ToInt32(nudDni.Value);
                edad = Convert.ToInt32(nudEdad.Value);
                pesoEquipajeUno = Convert.ToDouble(nudPesoEquipajeUno.Value);
                pesoEquipajeDos = Convert.ToDouble(nudPesoEquipajeDos.Value);
                dinero = Convert.ToInt32(nudDineroDisponible.Value);

                if (String.IsNullOrEmpty(txtApellido.Text) && String.IsNullOrEmpty(txtNombre.Text) && dni <= 1000 && edad <= 0)
                {
                    MessageBox.Show("Por favor, verifique los campos");
                }
                else
                {
                    foreach (Vuelos vuelo in MiAerolinea.listaVuelos)
                    {
                        foreach (Pasajeros pasajero in vuelo.ListaPasajeros)
                        {
                            if (pasajero.Dni != dni)
                            {
                                if (cbAsientoPremium.Checked)
                                {
                                    MiAerolinea.listaClientes.Add(new Cliente(txtApellido.Text, txtNombre.Text, dinero, dni, edad, true, cmbGenero.Text, int.Parse(cmbCantidadEquipajes.Text), pesoEquipajeUno, pesoEquipajeDos));
                                }
                                else
                                {
                                    MiAerolinea.listaClientes.Add(new Cliente(txtApellido.Text, txtNombre.Text, dinero, dni, edad, false, cmbGenero.Text, 1, pesoEquipajeUno, 0));
                                }
                                MessageBox.Show("Pasajero agregado correctamente");
                            }
                            else
                            {
                                MessageBox.Show("Este pasajero ya existe");
                            }

                            break;
                        }
                        break;
                    }
                }
            }
            else if(this.tipo == 0)
            {
                
                if(ActualizarPasajero())
                {
                    MessageBox.Show("Pasajero actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar al pasajero");
                }
            }

            this.Close();
           
        }

        private void cmbCantidadEquipajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCantidadEquipajes.SelectedIndex == 0)
            {
                nudPesoEquipajeDos.Enabled = false;
            }
            else
                nudPesoEquipajeDos.Enabled = true;
        }

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

            return estado;
        }
    }
}
