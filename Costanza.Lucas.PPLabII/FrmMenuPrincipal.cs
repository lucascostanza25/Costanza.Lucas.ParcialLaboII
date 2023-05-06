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
        private DataTable dtPasajeros;
        private List<Pasajeros>? listaPasajerosVuelo;
        private List<Aviones>? listaAvionesVuelo;

        public FrmMenuPrincipal(string nombre, string apellido, DateTime fecha, string cargo)
        {
            InitializeComponent();
            OcultarMenu();
            OcultarGroupBox();

            lblInformacionTrabajador.Text = $"Bienvenido {nombre} {apellido} - Perfil {cargo} - Fecha {fecha.ToString()}";

            dtVuelos = new DataTable();
            dtPasajeros = new DataTable();
            listaPasajerosVuelo = new List<Pasajeros>();
            listaAvionesVuelo = new List<Aviones>();

            
            CrearDataPrueba();
        }
        #region Menu lateral
        private void OcultarGroupBox()
        {
            this.gbVerVuelos.Visible = false;
            this.gbVenderVuelos.Visible = false;

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
        #endregion

        #region Ver Vuelos
        private void btnVuelos_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuVuelos);
        }

        private void btnVerVuelos_Click(object sender, EventArgs e)
        {
            //OcultarGroupBox();
            this.gbVenderVuelos.Visible =false;
            this.gbVerVuelos.Visible = true;

            CrearDataGridViewPasajeros();
            CrearDataGridViewVuelos(dgvDatosVuelos);
            PintarDataGriedViewVuelos(MiAerolinea.listaVuelos);
        }

        #region DataGridViews
        private void CrearDataGridViewVuelos(DataGridView dgv)
        {
            dtVuelos.Clear();
            if (!dtVuelos.Columns.Contains("Código") && !dtVuelos.Columns.Contains("Origen") && !dtVuelos.Columns.Contains("Destino") &&
                !dtVuelos.Columns.Contains("Fecha") && !dtVuelos.Columns.Contains("Precio") && !dtVuelos.Columns.Contains("Asientos disponibles") &&
                !dtVuelos.Columns.Contains("Asientos ocupados") && !dtVuelos.Columns.Contains("Avion"))
            {
                dtVuelos.Columns.Add("Código");
                dtVuelos.Columns.Add("Origen");
                dtVuelos.Columns.Add("Destino");
                dtVuelos.Columns.Add("Fecha");
                dtVuelos.Columns.Add("Precio");
                dtVuelos.Columns.Add("Asientos disponibles");
                dtVuelos.Columns.Add("Asientos ocupados");
                dtVuelos.Columns.Add("Avion");
            }


            dgv.DataSource = null;
            dgv.DataSource = dtVuelos;
            dgv.Columns["Código"].Width = 100;
            dgv.Columns["Origen"].Width = 200;
            dgv.Columns["Destino"].Width = 200;
            dgv.Columns["Fecha"].Width = 120;
            dgv.Columns["Precio"].Width = 100;
            dgv.Columns["Asientos disponibles"].Width = 55;
            dgv.Columns["Asientos ocupados"].Width = 55;
            dgv.Columns["Avion"].Width = 100;
        }

        private void PintarDataGriedViewVuelos(List<Vuelos> listaVuelos)
        {
            dtVuelos.Rows.Clear();
            dtVuelos.Clear();
            foreach (Vuelos miVuelo in listaVuelos)
            {
                DataRow row = dtVuelos.NewRow();
                row["Código"] = miVuelo.CodigoVuelo;
                string origen = miVuelo.Origen.ToString().Replace("_", " ");
                row["Origen"] = origen;
                string destino = miVuelo.Destino.ToString().Replace("_", " ");
                row["Destino"] = destino;
                row["Fecha"] = miVuelo.FechaVuelo;
                row["Precio"] = miVuelo.PrecioVuelo;
                row["Asientos disponibles"] = miVuelo.AsientosDisponibles;
                row["Asientos ocupados"] = miVuelo.AsientosOcupados;
                row["Avion"] = miVuelo.AvionVuelo.ModeloAvion;
                dtVuelos.Rows.Add(row);
            }
        }
        private void LimpiarDataGridView(DataTable dt)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
        }

        private void CrearDataPrueba()
        {
            listaAvionesVuelo.Add(new Aviones("FJS50OP", 60, false, true, 2400, "Boeing 787", "BRC2023"));
            listaAvionesVuelo.Add(new Aviones("GLT049T", 120, true, true, 4800, "Airbus A220", "MDZ4267"));
            listaAvionesVuelo.Add(new Aviones("UYI5904", 60, false, false, 2400, "Boeing 678", "TUT5563")); //viaje de tucuman a trelew
            listaAvionesVuelo.Add(new Aviones("HLY095N", 250, true, true, 10000, "Boeing 777", "RCF9865")); //viaje de bsas a recife
            listaAvionesVuelo.Add(new Aviones("HTF078P", 300, true, true, 12000, "Airbus A380", "ITA2353")); //viaje de bsas a italia
            listaAvionesVuelo.Add(new Aviones("HCV0952", 350, true, true, 12000, "Boeing 777", "USA5793")); //viaje de bsas a eeuu


            MiAerolinea.SerializarAvionesJson(listaAvionesVuelo);
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros1.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, DateTime.Now, "BRC2023", 2, DestinosVuelos.Trelew, DestinosVuelos.Neuquen, 50);
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros100.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, DateTime.Now, "ITA2353", 18, DestinosVuelos.Buenos_aires, DestinosVuelos.Roma, 100);
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros310.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, DateTime.Now, "USA5793", 12, DestinosVuelos.Buenos_aires, DestinosVuelos.Miami, 100);
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros220.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 05, 15), "RCF9865", 6, DestinosVuelos.Buenos_aires, DestinosVuelos.Recife, 100);
            listaPasajerosVuelo = null;


            //miAerolinea.SerializarVuelosXml(miAerolinea.listaVuelos);
            //miAerolinea.DeserializarVuelosXml();
        }

        private void CrearDataGridViewPasajeros()
        {
            //dtPasajeros.Columns.Clear();
            if (!dtPasajeros.Columns.Contains("Nombre") && !dtPasajeros.Columns.Contains("Apellido") && !dtPasajeros.Columns.Contains("Dni")
                && !dtPasajeros.Columns.Contains("Edad") && !dtPasajeros.Columns.Contains("Peso\nequipaje") && !dtPasajeros.Columns.Contains("Género")
                && !dtPasajeros.Columns.Contains("Asiento\npremium"))
            {
                dtPasajeros.Columns.Add("Nombre");
                dtPasajeros.Columns.Add("Apellido");
                dtPasajeros.Columns.Add("Dni");
                dtPasajeros.Columns.Add("Edad");
                dtPasajeros.Columns.Add("Peso\nequipaje");
                dtPasajeros.Columns.Add("Género");
                dtPasajeros.Columns.Add("Asiento\npremium");

            }
            
            dgvPasajeros.DataSource = null;
            dgvPasajeros.DataSource = dtPasajeros;
            dgvPasajeros.Columns["Nombre"].Width = 200;
            dgvPasajeros.Columns["Apellido"].Width = 200;
            dgvPasajeros.Columns["Dni"].Width = 120;
            dgvPasajeros.Columns["Edad"].Width = 100;
            dgvPasajeros.Columns["Peso\nequipaje"].Width = 100;
            dgvPasajeros.Columns["Género"].Width = 100;
            dgvPasajeros.Columns["Asiento\npremium"].Width = 100;
        }

        private void PintarDataGridViewPasajeros(List<Pasajeros> listaPasajeros)
        {
            dtPasajeros.Rows.Clear();
            foreach (Pasajeros miPasajero in listaPasajeros)
            {
                DataRow row = dtPasajeros.NewRow();
                row["Nombre"] = miPasajero.Nombre;
                row["Apellido"] = miPasajero.Apellido;
                row["Dni"] = miPasajero.Dni;
                row["Edad"] = miPasajero.Edad;
                row["Peso\nequipaje"] = miPasajero.PesoEquipaje;
                row["Género"] = miPasajero.Genero;
                row["Asiento\npremium"] = miPasajero.AsientoPremium;
                dtPasajeros.Rows.Add(row);
            }
        }
        #endregion

        private void dgvDatosVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Pasajeros> listaPasajerosPorVuelo = new List<Pasajeros>(); ;

            if (dgvDatosVuelos.SelectedRows.Count > 0)
            {
                string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["Código"].Value.ToString();
                listaPasajerosPorVuelo = MiAerolinea.RetornarPasajerosPorVuelo(codigoVueloSeleccionado);

                foreach (Vuelos miVuelo in MiAerolinea.listaVuelos)
                {
                    if (miVuelo.CodigoVuelo == codigoVueloSeleccionado)
                    {
                        listaPasajerosPorVuelo = miVuelo.ListaPasajeros;
                        lblPasajerosVuelo.Text = $"PASAJEROS DEL VUELO: {miVuelo.CodigoVuelo}";

                        lblInformacionVuelo.Text = MiAerolinea.RetornarDatosVuelo(miVuelo);
                        break;
                    }
                }

            }
            PintarDataGridViewPasajeros(listaPasajerosPorVuelo);

        }

        #region FormClosing
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
        #endregion
        

        private void txtCodigoVuelo_TextChanged(object sender, EventArgs e)
        {
            List<Vuelos> vueloFiltrado = new List<Vuelos>();
            string codigoVuelo = txtCodigoVuelo.Text;

            if(String.IsNullOrEmpty(txtCodigoVuelo.Text))
            {
                PintarDataGriedViewVuelos(MiAerolinea.listaVuelos);
            }
            else
            {
                vueloFiltrado = MiAerolinea.BuscarVuelo(codigoVuelo);
                PintarDataGriedViewVuelos(vueloFiltrado);
            }
            vueloFiltrado.Clear();
        }

        private void txtDniPasajero_TextChanged(object sender, EventArgs e)
        {
            int dni;
            if(int.TryParse(txtDniPasajero.Text, out dni))
            {
                lblInformacionPasajero.Text = MiAerolinea.BuscarUnPasajero(dni);
            }
        }
        #endregion

        #region Vender Vuelos
        private void btnVenderVuelo_Click(object sender, EventArgs e)
        {
            //OcultarGroupBox();
            this.gbVerVuelos.Visible = false;
            this.gbVenderVuelos.Visible = true;
            CrearDataGridViewVuelos(dgvVenderVuelosDisponibles);

            Cliente cliente1 = new Cliente("Alfredo", "Ramos", 100, 45300905, "alfredoramos@gmail.com");
            lblInformacionCliente.Text = DatosCliente(cliente1);
            
        }

        private string DatosCliente(Cliente miCliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {miCliente.Nombre}");
            sb.AppendLine($"Apellido: {miCliente.Apellido}");
            sb.AppendLine($"Dni: {miCliente.Dni}");
            sb.AppendLine($"Mail: {miCliente.Mail}");
            sb.AppendLine($"Dinero disponible: {miCliente.DineroDisponible}");

            return sb.ToString();
        }

        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            List<Vuelos> listaFiltrada = new List<Vuelos>();
            DestinosVuelos origen, destino;

            try
            {
                if (Enum.TryParse(cmbOrigen.Text.Replace(" ", "_"), out origen))
                    if (Enum.TryParse(cmbDestino.Text.Replace(" ", "_"), out destino))
                        listaFiltrada = MiAerolinea.FiltrarVuelos(origen, destino, dtpFechaIda.Value);
                PintarDataGriedViewVuelos(listaFiltrada);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDestinos(int tipoVuelo)
        {
            cmbDestino.Items.Clear();
            cmbOrigen.Items.Clear();
            
            foreach(DestinosVuelos destino in MiAerolinea.destinoPorVuelo[tipoVuelo])
            {
                string destinoString = destino.ToString().Replace("_",  " ");
                if(tipoVuelo == 1)
                {
                    cmbDestino.Items.Add(destinoString);
                    cmbOrigen.Items.Add(destinoString);
                }
                else if(tipoVuelo == 2)
                {
                    if(destino != DestinosVuelos.Buenos_aires)
                        cmbDestino.Items.Add(destinoString);
                    else if(destino == DestinosVuelos.Buenos_aires)
                        cmbOrigen.Items.Add(destinoString);
                }
            }
        }
        #endregion

        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {
            CargarDestinos(1);
        }

        private void rbInternacional_Click(object sender, EventArgs e)
        {
            CargarDestinos(2);
        }

        private void cbSoloIda_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSoloIda.Checked)
                dtpFechaVuelta.Enabled = false;
            else
                dtpFechaVuelta.Enabled = true;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
