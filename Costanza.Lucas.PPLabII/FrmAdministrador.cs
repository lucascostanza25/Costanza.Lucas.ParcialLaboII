using Entidades.PPLabII;
using Entidades.PPLabII.Entidades_DAO;
using Entidades.PPLabII.Firebase;
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
    public partial class FrmAdministrador : Form
    {
        private string baseSeleccionada = "Ninguna";
        private bool solicitudCierre = false;
        BaseDeDatos<Aviones> firebaseAviones;
        BaseDeDatos<Vuelos> firebaseVuelos;
        /// <summary>
        /// Constructor del form
        /// </summary>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fecha">Fecha que se inicia sesion</param>
        /// <param name="cargo">Cargo</param>
        public FrmAdministrador(string nombre, string apellido, string fecha, string cargo)
        {
            InitializeComponent();
            this.gbAdministrarVuelos.Visible = false;
            OcultarMenu();
            firebaseAviones = new BaseDeDatos<Aviones>();
            firebaseVuelos = new BaseDeDatos<Vuelos>();

            lblInformacionTrabajador.Text = $"¡Bienvenido {cargo}!\n" +
                $"¡{nombre} {apellido}!\n" +
                $"Fecha: {fecha}";
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo que oculta el menu del panel lateral
        /// </summary>
        protected void OcultarMenu()
        {
            this.panelMenuVuelos.Visible = false;
        }
        /// <summary>
        /// Metodo que pinta el submenu del panel lateral
        /// </summary>
        protected void PintarSubMenu()
        {
            if (panelMenuVuelos.Visible == true)
            {
                panelMenuVuelos.Visible = false;
            }
        }
        /// <summary>
        /// Metodo que muestra el menu del panel lateral
        /// </summary>
        /// <param name="menu">Panel a mostrar</param>
        protected void MostrarMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                PintarSubMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuVuelos);
            

        }

        private void btnCrearVuelo_Click(object sender, EventArgs e)
        {
            FrmCrearModificarVuelo formCrearVuelo = new FrmCrearModificarVuelo();
            formCrearVuelo.ShowDialog();
            CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
        }

        private void btnAdministrarVuelos_Click(object sender, EventArgs e)
        {
            this.gbAdministrarAviones.Visible = false;
            this.gbBaseDatos.Visible = false;
            this.gbAdministrarVuelos.Visible = true; 
            CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
        }
        /// <summary>
        /// Metodo que crear la informacion del data grid view
        /// </summary>
        /// <param name="dgv">DataGridView a pintar</param>
        /// <param name="listaVuelos">Lista con la informacion</param>
        protected void CrearDataGridViewVuelos(DataGridView dgv, List<Vuelos> listaVuelos)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("codigo", "Código");
            dgv.Columns.Add("origen", "Origen");
            dgv.Columns.Add("destino", "Destino");
            dgv.Columns.Add("fecha", "Fecha");
            dgv.Columns.Add("precio", "Precio");
            dgv.Columns.Add("asientos_disponibles", "Asientos disponibles");
            dgv.Columns.Add("asientos_ocupados", "Asientos ocupados");
            dgv.Columns.Add("avion", "Avion");

            dgv.Columns["codigo"].Width = 100;
            dgv.Columns["origen"].Width = 200;
            dgv.Columns["destino"].Width = 200;
            dgv.Columns["fecha"].Width = 120;
            dgv.Columns["precio"].Width = 100;
            dgv.Columns["asientos_disponibles"].Width = 55;
            dgv.Columns["asientos_ocupados"].Width = 55;
            dgv.Columns["avion"].Width = 100;

            foreach (Vuelos miVuelo in listaVuelos)
            {
                if (miVuelo.FechaVuelo >= DateTime.Now)
                {
                    dgv.Rows.Add(miVuelo.CodigoVuelo,
                        miVuelo.Origen.ToString().Replace("_", " "),
                        miVuelo.Destino.ToString().Replace("_", " "),
                        miVuelo.FechaVuelo,
                        miVuelo.PrecioVuelo,
                        miVuelo.AsientosDisponibles,
                        miVuelo.AsientosOcupados,
                        miVuelo.AvionVuelo.ModeloAvion);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(lblInformacionVuelo.Text != "Seleccione un vuelo clickeando en la primera columna con la fecla de la fila deseada")
            {
                try
                {
                    string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
                    Vuelos vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);
                    FrmCrearModificarVuelo formEditarVuelo = new FrmCrearModificarVuelo(vuelo);
                    formEditarVuelo.ShowDialog();
                    CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
                    lblInformacionVuelo.Text = "Seleccione un vuelo clickeando en la primera columna con la fecla de la fila deseada";
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Por favor, vuelva a seleccionar un vuelo");
                }
            }
            else
            {
                MessageBox.Show("Para editar un vuelo, seleccionelo en la primera columna con la flecha de la fila deseada");
            }
        }

        private void dgvDatosVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
            Vuelos vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);

            lblInformacionVuelo.Text = MiAerolinea.RetornarDatosVuelo(vuelo);
        }
        /// <summary>
        /// Metodo que crear el DataGridView de los aviones
        /// </summary>
        /// <param name="listaAviones">lista de los aviones</param>
        protected void CrearDataGridViewAviones(List<Aviones> listaAviones)
        {
            dgvDatosAviones.Rows.Clear();
            dgvDatosAviones.Columns.Clear();
            dgvDatosAviones.Columns.Add("matricula", "Matricula");
            dgvDatosAviones.Columns.Add("modelo", "Modelo");
            dgvDatosAviones.Columns.Add("asientos", "Asientos");
            dgvDatosAviones.Columns.Add("asientos_premium", "Asientos\npremium");
            dgvDatosAviones.Columns.Add("capacidad_bodega", "Capacidad\nbodega");
            dgvDatosAviones.Columns.Add("internet", "Internet");
            dgvDatosAviones.Columns.Add("comida", "Comida");

            dgvDatosAviones.Columns["matricula"].Width = 220;
            dgvDatosAviones.Columns["modelo"].Width = 200;
            dgvDatosAviones.Columns["asientos"].Width = 100;
            dgvDatosAviones.Columns["asientos_premium"].Width = 100;
            dgvDatosAviones.Columns["capacidad_bodega"].Width = 100;
            dgvDatosAviones.Columns["internet"].Width = 100;
            dgvDatosAviones.Columns["comida"].Width = 100;

            foreach (Aviones avion in listaAviones)
            {
                dgvDatosAviones.Rows.Add(avion.Matricula,
                    avion.ModeloAvion,
                    avion.CantidadAsientos,
                    avion.CantidadAsientosPremium,
                    avion.CapacidadBodega,
                    avion.ServicioInternet,
                    avion.ServicioComida);
            }
        }

        private void btnAdministrarAviones_Click(object sender, EventArgs e)
        {
            this.gbAdministrarVuelos.Visible = false;
            this.gbBaseDatos.Visible = false;
            this.gbAdministrarAviones.Visible = true;
            CrearDataGridViewAviones(MiAerolinea.listaAviones);
        }

        private void FrmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiAerolinea.SerializarAvionesJson(MiAerolinea.listaAviones);
            MiAerolinea.SerializarVuelosXml(MiAerolinea.listaVuelos);
            if (!solicitudCierre)
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    solicitudCierre = true;
                    Application.Exit();
                }
            }
        }

        private void btnCrearAvion_Click(object sender, EventArgs e)
        {
            FrmCrearModificarAvion formCrearAvion = new FrmCrearModificarAvion();
            formCrearAvion.ShowDialog();
            CrearDataGridViewAviones(MiAerolinea.listaAviones);
        }

        private void btnEditarAvion_Click(object sender, EventArgs e)
        {
            if (lblInformacionAvion.Text != "Seleccione un avion clickeando en la primera columna con la flecha de la fila deseada")
            {
                try
                {
                    string? matriculaAvion = dgvDatosAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
                    Aviones avionEditar = new Aviones();
                    avionEditar = MiAerolinea.BuscarUnAvion(matriculaAvion);
                    FrmCrearModificarAvion formEditarAvion = new FrmCrearModificarAvion(avionEditar);
                    formEditarAvion.ShowDialog();
                    CrearDataGridViewAviones(MiAerolinea.listaAviones);
                    lblInformacionAvion.Text = "Seleccione un avion clickeando en la primera columna con la flecha de la fila deseada";
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Por favor, vuelva a seleccionar un avion");
                }
            }
            else
            {
                MessageBox.Show("Para editar un avion, seleccionelo en la primera columna con la flecha de la fila deseada");
            }
        }

        private void dgvDatosAviones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? matriculaAvion = dgvDatosAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
            Aviones avionSeleccionado = new Aviones();
            avionSeleccionado = MiAerolinea.BuscarUnAvion(matriculaAvion);
            lblInformacionAvion.Text = MiAerolinea.RetornarDatosAvion(avionSeleccionado);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                solicitudCierre = true;
                this.Close();
            }
        }

        private async void btnEliminarAvion_Click(object sender, EventArgs e)
        {
            await ElimiarAvion();
        }

        private async Task<bool> ElimiarAvion()
        {
            try
            {
                string? matriculaAvion = dgvDatosAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
                Aviones avionSeleccionado = new Aviones();
                avionSeleccionado = MiAerolinea.BuscarUnAvion(matriculaAvion);
                DialogResult resultado = MessageBox.Show($"¿Seguro que desea eliminar el avion {avionSeleccionado.ModeloAvion}?", "Eliminar avion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    MiAerolinea.listaAviones.Remove(avionSeleccionado);
                    Task<bool> respuesta = firebaseAviones.Eliminar("aviones", avionSeleccionado.Matricula);
                    bool resultadoRespuesta = await respuesta;
                    AvionesDao.EliminarAvion(avionSeleccionado);
                    return true;
                }
                else
                    MessageBox.Show($"No se elminó a el avion {avionSeleccionado.ModeloAvion}", "Eliminar avion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (MiAerolinea.listaAviones is not null)
                    CrearDataGridViewAviones(MiAerolinea.listaAviones);
                lblInformacionAvion.Text = "Seleccione un avion clickeando en la primera columna con la flecha de la fila deseada";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vuelo para eliminar primero");
            }

            return false;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await ElimiarVuelo();
        }

        private async Task<bool> ElimiarVuelo()
        {
            try
            {
                string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
                Vuelos vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);
                DialogResult resutado = MessageBox.Show($"¿Seguro que desea eliminar el vuelo {vuelo.CodigoVuelo}?", "Eliminar vuelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resutado == DialogResult.Yes)
                {
                    MiAerolinea.listaVuelos.Remove(vuelo);
                    return true;
                }
                else
                    MessageBox.Show($"No se elminó el vuelo {vuelo.CodigoVuelo}", "Eliminar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
                lblInformacionVuelo.Text = "Seleccione un vuelo clickeando en la primera columna con la fecla de la fila deseada";
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vuelo para eliminar primero");
            }

            return false;
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            baseSeleccionada = "SQL Server";
            lblTextoDb.Text = $"Base de datos seleccioanda: {baseSeleccionada}";
            LimpiarDatos();
            MiAerolinea.listaPasajeros = PasajerosDao.LeerPasajeros();
            MiAerolinea.listaAviones = AvionesDao.LeerAviones();
            MiAerolinea.listaVuelos = VuelosDao.LeerVuelos();
        }

        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            lblTextoDb.Text = $"Base de datos seleccioanda: {baseSeleccionada}";
            this.gbAdministrarAviones.Visible = false;
            this.gbAdministrarVuelos.Visible = false;
            this.gbBaseDatos.Visible = true;
        }

        private void LimpiarDatos()
        {
            MiAerolinea.listaAviones.Clear();
            MiAerolinea.listaPasajeros.Clear();
            MiAerolinea.listaVuelos.Clear();
        }

        private async void btnFirebase_Click(object sender, EventArgs e)
        {
            baseSeleccionada = "Google Firebase";
            lblTextoDb.Text = $"Base de datos seleccioanda: {baseSeleccionada}";
            LimpiarDatos();
            BaseDeDatos<Aviones> firebaseAviones = new BaseDeDatos<Aviones>();
            MiAerolinea.listaAviones = await firebaseAviones.Traer("aviones");
            BaseDeDatos<Vuelos> firebaseVuelos = new BaseDeDatos<Vuelos>();
            MiAerolinea.listaVuelos = await firebaseVuelos.Traer("vuelos");
        }

        private void gbBaseDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
