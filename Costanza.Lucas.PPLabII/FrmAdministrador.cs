using Entidades.PPLabII;
using Entidades.PPLabII.Base_de_datos;
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
        Firebase<Aviones> firebaseAviones;
        Firebase<Vuelos> firebaseVuelos;

        TimeSpan tiempoRestante;

        public delegate void DelegadoTiempo(TimeSpan tiempo, Vuelos vuelo);
        public event DelegadoTiempo Enviar;

        private string temaActual;
        Serializadora<ConfigAPP> jsonConfig;
        public FrmAdministrador() 
        {
            InitializeComponent();
            if(MiAerolinea.listaVuelos.Count() > 0)
            {
                timerVueloAdmin.Start();
            }
            firebaseAviones = new Firebase<Aviones>();
            firebaseVuelos = new Firebase<Vuelos>();
            jsonConfig = new Serializadora<ConfigAPP>();
        }
        /// <summary>
        /// Constructor del form
        /// </summary>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fecha">Fecha que se inicia sesion</param>
        /// <param name="cargo">Cargo</param>
        public FrmAdministrador(string nombre, string apellido, string fecha, string cargo) : this()
        {
            this.gbAdministrarVuelos.Visible = false;
            OcultarMenu();


            lblInformacionTrabajador.Text = $"¡Bienvenido {cargo}!\n" +
                $"¡{nombre} {apellido}!\n" +
                $"Fecha: {fecha}";
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            ConfigAPP nuevaConfig = jsonConfig.Deserializar<ConfigAPP>("config.json");
            this.temaActual = nuevaConfig.Tema;

            switch (this.temaActual)
            {
                case "Oscuro":
                    TemaOscuro();
                    break;

                case "Claro":
                    TemaClaro();
                    break;

                case "Verde":
                    TemaVerde();
                    break;

                case "Rojo":
                    TemaRojo();
                    break;
            }
        }
        /// <summary>
        /// Metodo que oculta el menu del panel lateral
        /// </summary>
        protected void OcultarMenu()
        {
            this.panelMenuVuelos.Visible = false;
            this.panelTema.Visible = false;
        }
        /// <summary>
        /// Metodo que pinta el submenu del panel lateral
        /// </summary>
        protected void PintarSubMenu()
        {
            if(panelMenuVuelos.Visible == true)
            {
                panelMenuVuelos.Visible = false;
            }
            if(panelTema.Visible == true)
            {
                panelTema.Visible = false;
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
            if(MiAerolinea.listaVuelos is not null)
                CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
        }

        private void btnAdministrarVuelos_Click(object sender, EventArgs e)
        {
            this.gbAdministrarAviones.Visible = false;
            this.gbBaseDatos.Visible = false;
            this.gbAdministrarVuelos.Visible = true; 
            if(MiAerolinea.listaVuelos is not null)
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
                    if(MiAerolinea.listaVuelos is not null)
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
            if(MiAerolinea.listaAviones is not null)
                CrearDataGridViewAviones(MiAerolinea.listaAviones);
        }

        private void FrmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MiAerolinea.listaAviones is not null && MiAerolinea.listaVuelos is not null)
            {
                MiAerolinea.SerializarAvionesJson(MiAerolinea.listaAviones);
                MiAerolinea.SerializarVuelosXml(MiAerolinea.listaVuelos);
            }
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
            if(MiAerolinea.listaAviones is not null)
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
                    if(MiAerolinea.listaAviones is not null)
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
                    if(MiAerolinea.listaAviones is not null)
                        MiAerolinea.listaAviones.Remove(avionSeleccionado);
                    EliminarAvionSql("DELETE FROM aviones WHERE matricula = @matricula", avionSeleccionado);
                    Task<bool> respuesta = firebaseAviones.Eliminar("aviones", avionSeleccionado.Matricula);
                    bool resultadoRespuesta = await respuesta;
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

        private void EliminarAvionSql(string query, Aviones avionEliminar)
        {
            Sql<Aviones> sqlAviones = new Sql<Aviones>();
            sqlAviones.Eliminar(query, (comando) =>
            {
                comando.Parameters.AddWithValue("@matricula", avionEliminar.Matricula);
                comando.ExecuteNonQuery();
            });
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Task<bool> resultado = ElimiarVuelo();
            bool respuesta = await resultado;
            if(respuesta)
            {
                MessageBox.Show($"Se elminó el vuelo seleccionado exitosamente", "Eliminar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se elminó el vuelo seleccionado", "Eliminar vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    if (MiAerolinea.listaVuelos is not null)
                    {
                        MiAerolinea.listaVuelos.Remove(vuelo);
                        await firebaseVuelos.Eliminar("vuelos", vuelo.CodigoVuelo);
                    }
                    return true;
                }
                if(MiAerolinea.listaVuelos is not null)
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
            LimpiarDatos();
            Sql<Aviones> sqlAvion = new Sql<Aviones>();
            Sql<Vuelos> sqlVuelos = new Sql<Vuelos>();
            Sql<Pasajeros> sqlPasajeros = new Sql<Pasajeros>();
            List<Pasajeros> listaPasajerosVuelos = new List<Pasajeros>();

            try
            {
                baseSeleccionada = "SQL Server";
                lblTextoDb.Text = $"Base de datos seleccioanda: {baseSeleccionada}";
                //MiAerolinea.listaPasajeros = sqlPasajeros.Leer("SELECT * FROM pasajeros", (reader) =>
                //{
                //    return new Pasajeros
                //    {
                //        Apellido = reader["apellido"].ToString(),
                //        Nombre = reader["nombre"].ToString(),
                //        Dni = Convert.ToInt32(reader["dni"]),
                //        Edad = Convert.ToInt32(reader["edad"]),
                //        Genero = reader["genero"].ToString(),
                //        AsientoPremium = Convert.ToBoolean(reader["asiento_premium"]),
                //        CodigoVuelo = reader["codigo_vuelo"].ToString(),
                //        CantidadEquipaje = Convert.ToInt32(reader["cantidad_equipaje"]),
                //        PesoEquipajeUno = Convert.ToDouble(reader["peso_uno"]),
                //        PesoEquipajeDos = Convert.ToDouble(reader["peso_dos"])
                //    };
                //});

                MiAerolinea.listaAviones = sqlAvion.Leer("SELECT * FROM aviones", (reader) =>
                {
                    return new Aviones
                    {
                        Matricula = reader["matricula"].ToString(),
                        CantidadAsientos = Convert.ToInt32(reader["cantidad_asientos"]),
                        ServicioInternet = Convert.ToBoolean(reader["servicio_internet"]),
                        ServicioComida = Convert.ToBoolean(reader["servicio_comida"]),
                        CapacidadBodega = Convert.ToDouble(reader["capacidad_bodega"]),
                        ModeloAvion = reader["modelo"].ToString(),
                        CantidadAsientosNormales = Convert.ToInt32(reader["cantidad_asientos_normales"]),
                        CantidadAsientosPremium = Convert.ToInt32(reader["cantidad_asientos_premium"])
                    };
                });
                MiAerolinea.listaVuelos = VuelosDao.LeerVuelos();
            }
            catch (ExcepcionBaseDatos exB)
            {
                MessageBox.Show(exB.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (MiAerolinea.listaAviones is not null && MiAerolinea.listaPasajeros is not null && MiAerolinea.listaVuelos is not null)
            {
                MiAerolinea.listaAviones.Clear();
                MiAerolinea.listaPasajeros.Clear();
                MiAerolinea.listaVuelos.Clear();
            }
        }

        private async void btnFirebase_Click(object sender, EventArgs e)
        {
            try
            {
                baseSeleccionada = "Google Firebase";
                lblTextoDb.Text = $"Base de datos seleccioanda: {baseSeleccionada}";
                LimpiarDatos();
                Firebase<Aviones> firebaseAviones = new Firebase<Aviones>();
                MiAerolinea.listaAviones = await firebaseAviones.Traer("aviones");
                Firebase<Vuelos> firebaseVuelos = new Firebase<Vuelos>();
                MiAerolinea.listaVuelos = await firebaseVuelos.Traer("vuelos");
            
                //foreach(Aviones a in MiAerolinea.listaAviones)
                //{
                //    a.ActualizarAviones(a);
                //}

                //foreach(Vuelos v in MiAerolinea.listaVuelos)
                //{
                //    v.ActualizarDatosVuelo(v);
                //}
                timerVueloAdmin.Start();
            }
            catch(ExcepcionBaseDatos exB)
            {
                MessageBox.Show(exB.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gbBaseDatos_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<Vuelos> lista = new List<Vuelos>();
            if (MiAerolinea.listaVuelos is not null)
            {
                lista = MiAerolinea.listaVuelos;
            }
            Vuelos vuelo = lista[0];
            foreach(Vuelos v in lista)
            {
                if (v.FechaVuelo > DateTime.Now)
                {
                    if (v.FechaVuelo < vuelo.FechaVuelo)
                    {
                        vuelo = v;
                    }

                }
            }
            tiempoRestante = vuelo.FechaVuelo - DateTime.Now;
            sb.Append($"El proximo vuelo {vuelo.CodigoVuelo}, con destino a {vuelo.Destino.ToString().Replace("_", " ")} sale en: ");
            sb.Append(tiempoRestante.ToString(@"d\d\,\ h\h\,\ m\m\,\ s\s"));
            lblTimerVuelo.Text = sb.ToString();
            Enviar?.Invoke(tiempoRestante, vuelo);

        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelTema);
        }

        private void TemaRojo()
        {
            Color primario = Color.FromArgb(243, 139, 139);
            Color secundario = Color.FromArgb(194, 95, 95);
            Color terciario = Color.FromArgb(243, 37, 37);
            this.temaActual = "Rojo";
            CambiarTema(primario, secundario, terciario, Color.Black);
        }

        private void TemaOscuro()
        {
            Color primario = Color.FromArgb(60, 60, 60);
            Color secundario = Color.FromArgb(84, 84, 84);
            Color terciario = Color.DimGray;
            this.temaActual = "Oscuro";
            CambiarTema(primario, secundario, terciario, Color.White);
        }

        private void TemaVerde()
        {
            this.temaActual = "Verde";
            Color primario = Color.FromArgb(193, 231, 170);
            Color secundario = Color.FromArgb(109, 143, 88);
            Color terciario = Color.FromArgb(109, 122, 101);
            CambiarTema(primario, secundario, terciario, Color.Black);
        }

        private void TemaClaro()
        {
            this.temaActual = "Claro";
            Color primario = Color.FromArgb(239, 247, 255);
            Color secundario = Color.SteelBlue;
            Color terciario = Color.DarkSlateBlue;
            CambiarTema(primario, secundario, terciario, Color.Black);
        }

        private void CambiarTema(Color primario, Color secundario, Color terciario, Color colorLabel)
        {
            List<Panel> paneles = new List<Panel> { panelTema, panelMenuVuelos };
            foreach (Panel p in paneles)
            {
                p.BackColor = terciario;
            }
            this.panelMenu.BackColor = secundario;

            foreach (GroupBox gb in Controls.OfType<GroupBox>())
            {
                gb.BackColor = primario;
                foreach (Label lbl in gb.Controls.OfType<Label>())
                {
                    lbl.ForeColor = colorLabel;
                }
                foreach (RadioButton rb in gb.Controls.OfType<RadioButton>())
                {
                    rb.ForeColor = colorLabel;
                }
                foreach (CheckBox cb in gb.Controls.OfType<CheckBox>())
                {
                    cb.ForeColor = colorLabel;
                }
            }
        }

        private void rbTemaClaro_CheckedChanged(object sender, EventArgs e)
        {
            TemaClaro();
        }

        private void rbTemaOscuro_CheckedChanged(object sender, EventArgs e)
        {
            TemaOscuro();
        }

        private void rbTemaRojo_CheckedChanged(object sender, EventArgs e)
        {
            TemaRojo();
        }

        private void rbTemaVerde_CheckedChanged(object sender, EventArgs e)
        {
            TemaVerde();
        }
    }
}
