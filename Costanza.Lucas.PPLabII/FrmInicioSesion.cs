using Entidades.PPLabII;
using Entidades.PPLabII.Entidades_DAO;
using Entidades.PPLabII.Firebase;
using Google.Cloud.Firestore.V1;

namespace Costanza.Lucas.PPLabII
{
    public partial class FrmInicioSesion : Form
    {
        TimeSpan tiempoRestante;   
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
                string rutaArchivo = "logUsuarios.txt";
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
                                    FrmVendedor formMenu = new FrmVendedor(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil, tiempoRestante);
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
                GuardadorExcepciones guardador = new GuardadorExcepciones("log.txt");
                guardador.GuardarExcepcion(ex);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        
    }
}
