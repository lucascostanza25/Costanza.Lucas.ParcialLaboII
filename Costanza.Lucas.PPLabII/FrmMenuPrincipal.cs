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
        private List<Pasajeros>? listaPasajerosVuelo;
        private List<Aviones>? listaAvionesVuelo;

        public FrmMenuPrincipal(string nombre, string apellido, string fecha, string cargo)
        {
            InitializeComponent();
            OcultarMenu();
            OcultarGroupBox();

            lblInformacionTrabajador.Text = $"Bienvenido {nombre} {apellido} - Perfil {cargo} - Fecha {fecha}";
            lblInformacionTrabajador.BackColor = Color.Transparent;

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

        #region DataGridViews
    
        private void CrearDataGridViewVuelos(DataGridView dgv, List<Vuelos> listaVuelos)
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

            foreach(Vuelos miVuelo in listaVuelos)
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

        private void CrearDataPrueba()
        {
            listaAvionesVuelo.Add(new Aviones("FJS50OP", 65, false, true, 3500, "Boeing 787"));
            listaAvionesVuelo.Add(new Aviones("GLT049T", 120, true, true, 5500, "Airbus A220"));
            listaAvionesVuelo.Add(new Aviones("TRF053T", 80, false, false, 4500, "Airbus A110"));
            listaAvionesVuelo.Add(new Aviones("UYI5904", 65, false, false, 4000, "Boeing 678"));
            listaAvionesVuelo.Add(new Aviones("HLY095N", 250, true, true, 13000, "Boeing 777"));
            listaAvionesVuelo.Add(new Aviones("HTF078P", 300, true, true, 15000, "Airbus A380"));
            listaAvionesVuelo.Add(new Aviones("HCV0952", 350, true, true, 15000, "Boeing 777"));


            //MiAerolinea.SerializarAvionesJson(listaAvionesVuelo);
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros1.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 07, 07, 11, 30, 00), "BRC2023", 2, DestinosVuelos.Trelew, DestinosVuelos.Neuquen, 50, "FJS50OP");
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros100.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 06, 09, 22, 30, 00), "ITA2353", 18, DestinosVuelos.Roma, DestinosVuelos.Buenos_aires, 100, "HTF078P");
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros100_2.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 06, 10, 19, 00, 00), "BUE2452", 18, DestinosVuelos.Buenos_aires, DestinosVuelos.Roma, 100, "HTF078P");
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros310.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 05, 29, 15, 30, 00), "USA5793", 12, DestinosVuelos.Buenos_aires, DestinosVuelos.Miami, 100, "HCV0952");
            listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros305.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 05, 29, 22, 30, 00), "BUE2432", 12, DestinosVuelos.Miami, DestinosVuelos.Buenos_aires, 100, "HCV0952");
            listaPasajerosVuelo = null;
            //listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros220.xml");
            //MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 05, 20, 12, 00, 00), "RCF9865", 6, DestinosVuelos.Buenos_aires, DestinosVuelos.Recife, 100, "HLY095N");
            //listaPasajerosVuelo = null;
            listaPasajerosVuelo = MiAerolinea.CargarPasajerosXml("Pasajeros62.xml");
            MiAerolinea.CrearVuelo(listaPasajerosVuelo, listaAvionesVuelo, new DateTime(2023, 07, 07, 13, 30, 00), "NEQ2685", 2, DestinosVuelos.Neuquen, DestinosVuelos.Trelew, 50, "FJS50OP");
            listaPasajerosVuelo = null;


            //miAerolinea.SerializarVuelosXml(miAerolinea.listaVuelos);
            //miAerolinea.DeserializarVuelosXml();

            MiAerolinea.DespacharEquipajeDePasajerosHechos();
        }

        private void CrearDataGridViewPasajeros(DataGridView dgv, List<Pasajeros> listaPasajeros)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("nombre", "Nombre");
            dgv.Columns.Add("apellido", "Apellido");
            dgv.Columns.Add("dni", "Dni");
            dgv.Columns.Add("edad", "Edad");
            dgv.Columns.Add("cantidad_equipajes", "Cantidad\nequipajes");
            dgv.Columns.Add("peso_equipaje", "Peso\nequipaje");
            dgv.Columns.Add("genero", "Género");
            dgv.Columns.Add("asiento_premium", "Asiento\npremium");

            dgv.Columns["nombre"].Width = 200;
            dgv.Columns["apellido"].Width = 200;
            dgv.Columns["dni"].Width = 120;
            dgv.Columns["edad"].Width = 50;
            dgv.Columns["cantidad_equipajes"].Width = 80;
            dgv.Columns["peso_equipaje"].Width = 80;
            dgv.Columns["genero"].Width = 80;
            dgv.Columns["asiento_premium"].Width = 100;

            foreach (Pasajeros miPasajero in listaPasajeros)
            {
                double pesoEquipaje = miPasajero.PesoEquipajeUno + miPasajero.PesoEquipajeDos;
                dgv.Rows.Add(miPasajero.Nombre,
                    miPasajero.Apellido,
                    miPasajero.Dni,
                    miPasajero.Edad,
                    miPasajero.CantidadEquipaje,
                    pesoEquipaje,
                    miPasajero.Genero,
                    miPasajero.AsientoPremium);
            }
        }
        #endregion

        #region Ver Vuelos
        private void btnVuelos_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuVuelos);
        }

        private void btnVerVuelos_Click(object sender, EventArgs e)
        {

            this.gbEstadisticas.Visible = false;
            this.gbVenderVuelos.Visible = false;
            this.gbVerVuelos.Visible = true;
            CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
        }

        private void dgvDatosVuelos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Pasajeros> listaPasajerosPorVuelo = new List<Pasajeros>(); ;

            if (dgvDatosVuelos.SelectedRows.Count > 0)
            {
                string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
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
            CrearDataGridViewPasajeros(dgvPasajeros, listaPasajerosPorVuelo);

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
                CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
            }
            else
            {
                vueloFiltrado = MiAerolinea.BuscarVuelo(codigoVuelo);
                CrearDataGridViewVuelos(dgvDatosVuelos, vueloFiltrado);
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
        private void btnVenderVueloLateral_Click(object sender, EventArgs e)
        {
            //OcultarGroupBox();
            this.gbVerVuelos.Visible = false;
            this.gbEstadisticas.Visible = false;
            this.gbVenderVuelos.Visible = true;
            //MiAerolinea.listaClientes.Add(new Cliente("Ramos", "Alfredo", 500, 5400934, 53, true, "Male", 2, 13, 16, DestinosVuelos.Trelew, DestinosVuelos.Neuquen, new DateTime(2023, 07, 07)));
            //MiAerolinea.listaClientes.Add(new Cliente("Juan", "Gutierrez", 400, 56565652, 80, "juanguti@gmail.com", false, 15, "Male"));

        }

        private void DatosCliente(Cliente miCliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {miCliente.Nombre}");
            sb.AppendLine($"Apellido: {miCliente.Apellido}");
            sb.AppendLine($"Dni: {miCliente.Dni}");
            sb.AppendLine($"Edad: {miCliente.Edad}");
            sb.AppendLine($"Dinero disponible: {miCliente.DineroDisponible}");
            sb.AppendLine($"Genero: {miCliente.Genero}");
            sb.AppendLine($"¿Desea asiento premium?: {miCliente.AsientoPremium}");

            lblInformacionCliente.Text = sb.ToString();
        }

        private void btnBuscarVuelos_Click(object sender, EventArgs e)
        {
            List<Vuelos> listaFiltradaIda = new List<Vuelos>();
            List<Vuelos> listaFiltradaVuelta = new List<Vuelos>();
            DestinosVuelos origen, destino;
            int servicio = 0;

            if (cbServicioComida.Checked && cbServicioInternet.Checked)
                servicio = 1;
            else if (cbServicioComida.Checked && cbServicioInternet.CheckState == CheckState.Unchecked)
                servicio = 2;
            else if (cbServicioInternet.Checked && cbServicioComida.CheckState == CheckState.Unchecked)
                servicio = 3;

            try
            {
                if (Enum.TryParse(cmbOrigen.Text.Replace(" ", "_"), out origen))
                {
                    if (Enum.TryParse(cmbDestino.Text.Replace(" ", "_"), out destino))
                    {
                        listaFiltradaIda = MiAerolinea.FiltrarVuelos(origen, destino, dtpFechaIda.Value.Date, servicio);
                        CrearDataGridViewVuelos(dgvVenderVuelosIda, listaFiltradaIda);
                        if(!cbSoloIda.Checked)
                        {
                            listaFiltradaVuelta = MiAerolinea.FiltrarVuelos(destino, origen, dtpFechaVuelta.Value.Date, servicio);
                            CrearDataGridViewVuelos(dgvVenderVuelosVuelta, listaFiltradaVuelta);
                        }
                    }
                }
                
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

        private void rbInternacional_CheckedChanged(object sender, EventArgs e)
        {
            CargarDestinos(2);
        }

        private void cbSoloIda_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoloIda.Checked)
            {
                dtpFechaVuelta.Enabled = false;
                dgvVenderVuelosVuelta.Hide();
                dgvVenderVuelosVuelta.Enabled = false;
                lblViajeVuelta.Enabled = false;
                lblInformacionVueloVuelta.Enabled = false;
            }
            else
            {
                dtpFechaVuelta.Enabled = true;
                dgvVenderVuelosVuelta.Show();
                dgvVenderVuelosVuelta.Enabled = true;
                lblViajeVuelta.Enabled = true;
                lblInformacionVueloVuelta.Enabled = true;
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVenderVuelo_Click(object sender, EventArgs e)
        {
            if (lblInformacionCliente.Text != "Llame a un cliente")
            {
                Vuelos vueloAVenderIda = BuscarVuelo(BuscarCodigoDgv(dgvVenderVuelosIda));
                foreach (Cliente cliente in MiAerolinea.listaClientes)
                {
                    try
                    {
                        if (MiAerolinea.VenderVuelo(vueloAVenderIda, cliente))
                        {
                            if (lblViajeVuelta.Enabled)
                            {
                                Vuelos vueloAVenderVuelta = BuscarVuelo(BuscarCodigoDgv(dgvVenderVuelosVuelta));
                                MiAerolinea.VenderVuelo(vueloAVenderVuelta, cliente);
                                MessageBox.Show("¡El vuelo de ida y vuelta fueron vendidos exitosamente!", "Vuelo vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("¡El vuelo de ida fue vendido exitosamente!", "Vuelo vendido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
            else
            {
                MessageBox.Show("Llame a un cliente primero");
            }
            lblInformacionCliente.Text = "Llame a un cliente";
            dgvVenderVuelosIda.Rows.Clear();
            dgvVenderVuelosVuelta.Rows.Clear();
        }

        private void dgvVenderVuelosIda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vuelos vueloIda = BuscarVuelo(BuscarCodigoDgv(dgvVenderVuelosIda));
            lblInformacionVueloIda.Text = MiAerolinea.RetornarDatosVuelo(vueloIda);
        }

        private Vuelos BuscarVuelo(string? codigo)
        {
            return MiAerolinea.BuscarUnVuelo(codigo);
        }

        private string? BuscarCodigoDgv(DataGridView dgv)
        {
            return dgv.SelectedRows[0].Cells["codigo"].Value.ToString();
        }

        private void dgvVenderVuelosVuelta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vuelos vueloVuelta = BuscarVuelo(BuscarCodigoDgv(dgvVenderVuelosVuelta));
            lblInformacionVueloVuelta.Text = MiAerolinea.RetornarDatosVuelo(vueloVuelta);
        }

        private void btnLlamarCliente_Click(object sender, EventArgs e)
        {
            foreach(Cliente miCliente in MiAerolinea.listaClientes)
            {
                DatosCliente(miCliente);
                break;
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelMenuEstadisticas);
        }


        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            FrmCrearModificarPersonas formCrearCliente = new FrmCrearModificarPersonas("Crear cliente", 1, -1);
            formCrearCliente.ShowDialog();
        }

        private void btnEditarPasajero_Click(object sender, EventArgs e)
        {
            FrmCrearModificarPersonas formEditarPasajero = new FrmCrearModificarPersonas("Editar pasajero", 0, int.Parse(txtDniPasajero.Text));
            formEditarPasajero.ShowDialog();
        }
        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            this.gbVerVuelos.Visible = false;
            this.gbVenderVuelos.Visible = false;
            this.gbEstadisticas.Visible = true;

            lblVueloMasPasajeros.Text = MiAerolinea.EstadisticaVueloMasPasajeros();
            lblRecaudacionTotal.Text = MiAerolinea.EstadisticaRecaudacionTotalVuelos();
            lblVueloMasPasajeros.Text = MiAerolinea.EstadisticaVueloMasRecaudo();
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Segudo que desea eliminar al pasajero?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultado == DialogResult.Yes)
            {
                if (MiAerolinea.EliminarPasajero(int.Parse(txtDniPasajero.Text)))
                {
                    MessageBox.Show("Pasajero eliminado");
                    CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
                    dgvPasajeros.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Se canceló la eliminación del pasajero");
            }
        }
    }
}
