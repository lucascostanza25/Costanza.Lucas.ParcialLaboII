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
        public FrmAdministrador()
        {
            InitializeComponent();
            this.gbAdministrarVuelos.Visible = false;
            OcultarMenu();
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
            string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
            Vuelos vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);
            FrmCrearModificarVuelo formEditarVuelo = new FrmCrearModificarVuelo(vuelo);
            formEditarVuelo.ShowDialog();
            CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
        }

        private void dgvDatosVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
            Vuelos vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);

            lblInformacionVuelo.Text = MiAerolinea.RetornarDatosVuelo(vuelo);
        }
    }
}
