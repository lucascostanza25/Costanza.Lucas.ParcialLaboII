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
    public partial class FrmVendedor : FrmInicioSesion
    {
        private DataTable dtVuelos;
        public FrmVendedor(string nombre, string apellido, string fecha) : base()
        {
            InitializeComponent();
            lblInformacionVendedeor.Text = $"Bienvenido vendedor {nombre} {apellido} - Fecha: {fecha}";
            panelMenuVuelos.Visible = false;
            //pbFotoAvion.Image = System.Drawing.Image.FromFile("FondoPrueba.png");
            lblBuscarVuelo.Visible = false;
            txtCodigoVuelo.Visible = false;
            dgvDatosVuelos.Visible = false;
             
            dtVuelos = new DataTable();

            Aviones miAvionPrueba = new Aviones("FJS50OP", 60, false, true, 89, "Boeing 777");
            List<Pasajeros> listaPasajeros = new List<Pasajeros>();
            listaPasajeros.Add(new Pasajeros("Lucas", "Costanza", 42200903, 23));
            listaPasajeros.Add(new Pasajeros("Eliana", "Gonzales", 50526013, 23));
            miAerolinea.CrearVueloNacional(DestinosNacionalesVuelos.Trelew, DestinosNacionalesVuelos.Neuquen, DateTime.Now, 11000, listaPasajeros, miAvionPrueba, "brc2023");
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
            lblTitulo.Visible = true;
            lblBuscarVuelo.Visible = true;
            txtCodigoVuelo.Visible = true;
            dgvDatosVuelos.Visible = true;

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

            List<Vuelos> listaVuelos = miAerolinea.RetornarListaVuelos();

            foreach(Vuelos miVuelo in listaVuelos)
            {
                DataRow row = dtVuelos.NewRow();
                row["Código"] = miVuelo.CodigoVuelo;
                row["Origen"] = miVuelo.OrigenVuelo;
                row["Destino"] = miVuelo.DestinoVuelo;
                row["Fecha"] = miVuelo.FechaVuelo;
                row["Precio"] = miVuelo.Precio;
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
    }
}
