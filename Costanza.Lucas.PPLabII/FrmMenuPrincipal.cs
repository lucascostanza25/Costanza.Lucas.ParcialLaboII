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
    public partial class FrmMenuPrincipal : Form
    {
        private DataTable dtVuelos;
        private List<Pasajeros>? listaPasajerosVuelo;
        private List<Aviones>? listaAvionesVuelo;

        public FrmMenuPrincipal(string nombre, string apellido, string fecha, string cargo)
        {
            InitializeComponent();
            OcultarMenu();

            lblInformacionTrabajador.Text = $"Bienvenido {nombre} {apellido} - Perfil {cargo} - Fecha {fecha}";

            dtVuelos = new DataTable();
            listaPasajerosVuelo = new List<Pasajeros>();
            listaAvionesVuelo = new List<Aviones>();

            CrearDataPrueba();
        }

        private void OcultarGroupBox()
        {
            this.gbVerVuelos.Visible = false;

        }

        private void OcultarMenu()
        {
            this.panelMenuVuelos.Visible = false;
            this.panelMenuEstadisticas.Visible = false;
        }

        private void PintarSubMenu()
        {
            if (panelMenuVuelos.Visible == true)
            {
                panelMenuVuelos.Visible = false;
            }
            if (panelMenuEstadisticas.Visible == true)
            {
                panelMenuEstadisticas.Visible = false;
            }
        }

        private void MostrarMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                PintarSubMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuVuelos);
        }

        private void btnVerVuelos_Click(object sender, EventArgs e)
        {
            gbVerVuelos.Visible = true;
            gbVerVuelos.Location = new Point(200, 167);
            PintarDataGriedView();
        }

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

            foreach (VuelosNacionales miVuelo in miAerolinea.listaVuelosNacionales)
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

        private void CrearDataPrueba()
        {
            listaAvionesVuelo.Add(new Aviones("FJS50OP", 60, false, true, 2400, "Boeing 787", "BRC2023"));
            listaAvionesVuelo.Add(new Aviones("GLT049T", 120, true, true, 4800, "Airbus A220", "MDZ4267"));
            listaAvionesVuelo.Add(new Aviones("UYI5904", 60, false, false, 2400, "Boeing 678", "TUT5563")); //viaje de tucuman a trelew
            listaAvionesVuelo.Add(new Aviones("HLY095N", 250, true, true, 10000, "Boeing 777", "BRZ9865")); //viaje de brasil a mezico
            listaAvionesVuelo.Add(new Aviones("HTF078P", 300, true, true, 12000, "Airbus A380", "MXE2353")); //viaje de mexico a italia
            listaAvionesVuelo.Add(new Aviones("HCV0952", 300, true, true, 12000, "Boeing 777", "UIT5793")); //viaje de eeuu a italia


            miAerolinea.SerializarAvionesJson(listaAvionesVuelo);
            listaPasajerosVuelo = miAerolinea.CargarPasajerosXml("Pasajeros1.xml");
            miAerolinea.CrearVueloNacional(listaPasajerosVuelo, listaAvionesVuelo, DateTime.Now, "BRC2023", 2, DestinosNacionalesVuelos.Trelew, DestinosNacionalesVuelos.Neuquen);
            listaPasajerosVuelo = null;
        }

        private void dgvDatosVuelos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDatosVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Pasajeros> listaPasajerosPorVuelo = new List<Pasajeros>();

            //listaPasajerosVuelo.Clear();
            if (dgvDatosVuelos.SelectedRows.Count > 0)
            {
                string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["Código"].Value.ToString();
                //listaPasajerosPorVuelo = miAerolinea.RetornarPasajerosPorVuelo(codigoVueloSeleccionado);

                foreach (VuelosNacionales miVuelo in miAerolinea.listaVuelosNacionales)
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cerrar sesion?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            Application.Restart();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVenderVuelo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
