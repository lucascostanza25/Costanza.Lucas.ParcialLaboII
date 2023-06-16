using Entidades.PPLabII;
using Entidades.PPLabII.Entidades_DAO;
using Entidades.PPLabII.Firebase;
using Google.Cloud.Firestore.V1;

namespace Costanza.Lucas.PPLabII
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
            MiAerolinea.DeserializarUsuarios("usuarios.json");
            lblMail.Visible = false;
            lblContrasenia.Visible = false;
            txtContrasenia.Visible = false;
            txtMail.Visible = false;
            btnLogearse.Visible = false;
            //MiAerolinea.DeserializarAvionesJson("aviones.json");
            //MiAerolinea.DeserializarVuelosXml();

            ////MiAerolinea.CargarPasajerosXml("NuevosPasajeros.xml");
            //MiAerolinea.listaPasajeros = PasajerosDao.LeerPasajeros();
            //MiAerolinea.listaAviones = AvionesDao.LeerAviones();
            //MiAerolinea.listaVuelos = VuelosDao.LeerVuelos();


        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            pbFotoAvion.Image = System.Drawing.Image.FromFile("FotoAvionEditada.png");

            lblMail.Visible = true;
            lblContrasenia.Visible = true;
            txtContrasenia.Visible = true;
            txtMail.Visible = true;
            btnLogearse.Visible = true;

            
        }

        private void btnLogearse_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            try
            {
                DateTime fecha = DateTime.Now;
                string fechaSinHora = fecha.ToString("dd/MM/yyyy");
                string rutaArchivo = "log.txt";
                bool usuarioEncontrado = false;

                foreach (Usuarios miUsuario in MiAerolinea.listaUsuarios)
                {
                    if (miUsuario.Correo == txtMail.Text && miUsuario.Clave == txtContrasenia.Text)
                    {
                        usuarioEncontrado = true;
                        using (StreamWriter archivo = new StreamWriter(rutaArchivo, true))
                        {
                            switch (miUsuario.Perfil)
                            {
                                case "vendedor":
                                    archivo.WriteLine($"{fecha} -> INICIO SESION: {miUsuario.Nombre} {miUsuario.Apellido} - {miUsuario.Perfil}");
                                    this.Hide();
                                    FrmVendedor formMenu = new FrmVendedor(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil);
                                    formMenu.ShowDialog();
                                    this.Show();
                                    break;

                                case "supervisor":
                                    archivo.WriteLine($"{fecha} -> INICIO SESION: {miUsuario.Nombre} {miUsuario.Apellido} - {miUsuario.Perfil}");
                                    this.Hide();
                                    Supervisor formSupervisor = new Supervisor(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil);
                                    formSupervisor.ShowDialog();
                                    this.Show();
                                    break;

                                case "administrador":
                                    archivo.WriteLine($"{fecha} -> INICIO SESION: {miUsuario.Nombre} {miUsuario.Apellido} - {miUsuario.Perfil}");
                                    this.Hide();
                                    FrmAdministrador formAdministrador = new FrmAdministrador(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil);
                                    formAdministrador.ShowDialog();
                                    this.Show();
                                    break;
                            }
                            this.txtContrasenia.Text = null;
                            this.txtMail.Text = null;
                            archivo.Flush();
                        }
                    }
                }

                if (!usuarioEncontrado)
                {
                    throw new Exception("Correo o contraseña incorrectos. Por favor, inténtelo nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private async void CrearDataPrueba()
        {
        
            //MiAerolinea.SerializarAvionesJson(MiAerolinea.listaAviones);
            //MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros1.xml");
            //MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 07, 07, 11, 30, 00), "BRC2023", 2, DestinosVuelos.Trelew, DestinosVuelos.Neuquen, 50, "FJS50OP");
            //MiAerolinea.listaPasajeros = null;
            //MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros100.xml");
            //MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 06, 09, 22, 30, 00), "ITA2353", 18, DestinosVuelos.Roma, DestinosVuelos.Buenos_aires, 100, "HTF078P");
            //MiAerolinea.listaPasajeros = null;
            //MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros100_2.xml");
            //MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 06, 10, 19, 00, 00), "BUE2452", 18, DestinosVuelos.Buenos_aires, DestinosVuelos.Roma, 100, "HTF078P");
            //MiAerolinea.listaPasajeros = null;
            //MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros310.xml");
            //MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 05, 29, 15, 30, 00), "USA5793", 12, DestinosVuelos.Buenos_aires, DestinosVuelos.Miami, 100, "HCV0952");
            //MiAerolinea.listaPasajeros = null;
            //MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros305.xml");
            //MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 05, 29, 22, 30, 00), "BUE2432", 12, DestinosVuelos.Miami, DestinosVuelos.Buenos_aires, 100, "HCV0952");
            //MiAerolinea.listaPasajeros = null;
            ////MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros220.xml");
            ////MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 05, 20, 12, 00, 00), "RCF9865", 6, DestinosVuelos.Buenos_aires, DestinosVuelos.Recife, 100, "HLY095N");
            ////MiAerolinea.listaPasajeros = null;
            //MiAerolinea.listaPasajeros = MiAerolinea.CargarPasajerosXml("Pasajeros62.xml");
            //MiAerolinea.CrearVuelo(MiAerolinea.listaPasajeros, MiAerolinea.listaAviones, new DateTime(2023, 07, 07, 13, 30, 00), "NEQ2685", 2, DestinosVuelos.Neuquen, DestinosVuelos.Trelew, 50, "FJS50OP");
            //MiAerolinea.listaPasajeros = null;

            List<Pasajeros> listaPasajeros = new List<Pasajeros>();
            listaPasajeros = MiAerolinea.CargarPasajerosXml("NuevosPasajeros305.xml");
            MiAerolinea.DespacharEquipajeDePasajerosHechos(listaPasajeros);
            Vuelos vueloNuevo = new Vuelos(new DateTime(2023, 06, 29, 17, 00, 00), "MIA8956", DestinosVuelos.Buenos_aires, DestinosVuelos.Miami, 10, 100, "HCV0952", listaPasajeros);
            BaseDeDatos<Vuelos> firebaseVuelo = new BaseDeDatos<Vuelos>();
            await firebaseVuelo.Agregar(vueloNuevo, "vuelos", vueloNuevo.CodigoVuelo);
            //MiAerolinea.SerializarVuelosXml(MiAerolinea.listaVuelos);


            //MiAerolinea.DespacharEquipajeDePasajerosHechos();
        }
    }
}
