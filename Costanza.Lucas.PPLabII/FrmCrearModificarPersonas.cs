using Entidades.PPLabII;
using Entidades.PPLabII.Base_de_datos;
using Entidades.PPLabII.Firebase;
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

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnAceptar.Text == "Editar pasajero")
            {
                Task<bool> respuesta = ActualizarPasajero();
                bool resultado = await respuesta;
                if (resultado)
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
        private async Task<bool> ActualizarPasajero()
        {
            Firebase<Vuelos> firebaseVuelos = new Firebase<Vuelos>();
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

            ActualizarPasajeroSql(miPasajero);
            if (MiAerolinea.listaVuelos is not null )
            {
                Vuelos? vuelo = MiAerolinea.listaVuelos.FirstOrDefault((Vuelos) => Vuelos.CodigoVuelo == miPasajero.CodigoVuelo);
                if(vuelo is not null && vuelo.CodigoVuelo is not null)
                {
                    await firebaseVuelos.Actualizar(vuelo, "vuelos", vuelo.CodigoVuelo);
                }
            }
            return estado;
        }

        /// <summary>
        /// Metodo que actualiza un pasajero de sql
        /// </summary>
        /// <param name="pasajero">Pasajero a editar</param>
        private void ActualizarPasajeroSql(Pasajeros pasajero)
        {
            Sql<Pasajeros> sqlPasajeros = new Sql<Pasajeros>();
            sqlPasajeros.Actualizar("UPDATE pasajeros SET nombre = @nombre, apellido = @apellido, genero = @genero, asiento_premium = @asiento_premium, cantidad_equipaje = @cantidad_equipaje, peso_uno = @peso_uno, peso_dos = @peso_dos, edad = @edad WHERE dni = @dni",
                (comando) =>
                {
                    comando.Parameters.AddWithValue("@nombre", pasajero.Nombre);
                    comando.Parameters.AddWithValue("@apellido", pasajero.Apellido);
                    comando.Parameters.AddWithValue("@genero", pasajero.Genero);
                    if (pasajero.AsientoPremium)
                        comando.Parameters.AddWithValue("@asiento_premium", 1);
                    else
                        comando.Parameters.AddWithValue("@asiento_premium", 0);
                    comando.Parameters.AddWithValue("@cantidad_equipaje", (int)pasajero.CantidadEquipaje);
                    comando.Parameters.AddWithValue("@peso_uno", (float)pasajero.PesoEquipajeUno);
                    comando.Parameters.AddWithValue("@peso_dos", (float)pasajero.PesoEquipajeDos);
                    comando.Parameters.AddWithValue("@edad", pasajero.Edad);
                    comando.Parameters.AddWithValue("@dni", pasajero.Dni);
                });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
