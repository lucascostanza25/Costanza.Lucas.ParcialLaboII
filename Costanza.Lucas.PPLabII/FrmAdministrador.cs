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
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador(string nombre, string apellido, string fecha, string cargo)
        {
            InitializeComponent();
            this.gbAdministrarVuelos.Visible = false;
            OcultarMenu();

            lblInformacionTrabajador.Text = $"¡Bienvenido {cargo}!\n" +
                $"¡{nombre} {apellido}!\n" +
                $"Fecha: {fecha}";
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {

        }

        protected void OcultarMenu()
        {
            this.panelMenuVuelos.Visible = false;
        }

        protected void PintarSubMenu()
        {
            if (panelMenuVuelos.Visible == true)
            {
                panelMenuVuelos.Visible = false;
            }
        }

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
            this.gbAdministrarVuelos.Visible = true;
            CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
        }

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
            this.gbAdministrarAviones.Visible = true;
            CrearDataGridViewAviones(MiAerolinea.listaAviones);
        }

        private void FrmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiAerolinea.SerializarAvionesJson(MiAerolinea.listaAviones);
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
                this.Close();
        }

        private void btnEliminarAvion_Click(object sender, EventArgs e)
        {
            try
            {
                string? matriculaAvion = dgvDatosAviones.SelectedRows[0].Cells["matricula"].Value.ToString();
                Aviones avionSeleccionado = new Aviones();
                avionSeleccionado = MiAerolinea.BuscarUnAvion(matriculaAvion);
                DialogResult resutado = MessageBox.Show($"¿Seguro que desea eliminar el avion {avionSeleccionado.ModeloAvion}?", "Eliminar avion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resutado == DialogResult.Yes)
                    MiAerolinea.listaAviones.Remove(avionSeleccionado);
                else
                    MessageBox.Show($"No se elminó a el avion {avionSeleccionado.ModeloAvion}", "Eliminar avion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                CrearDataGridViewAviones(MiAerolinea.listaAviones);
                lblInformacionAvion.Text = "Seleccione un avion clickeando en la primera columna con la flecha de la fila deseada";
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vuelo para eliminar primero");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
                Vuelos vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);
                DialogResult resutado = MessageBox.Show($"¿Seguro que desea eliminar el vuelo {vuelo.CodigoVuelo}?", "Eliminar vuelo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resutado == DialogResult.Yes)
                    MiAerolinea.listaVuelos.Remove(vuelo);
                else
                    MessageBox.Show($"No se elminó el vuelo {vuelo.CodigoVuelo}", "Eliminar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
                lblInformacionVuelo.Text = "Seleccione un vuelo clickeando en la primera columna con la fecla de la fila deseada";
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione un vuelo para eliminar primero");
            }
        }
    }
}
