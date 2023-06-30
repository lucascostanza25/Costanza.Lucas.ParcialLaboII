using Entidades.PPLabII;
using Entidades.PPLabII.Firebase;
using Google.Cloud.Firestore.V1;
using System.Windows.Forms;

namespace Costanza.Lucas.PPLabII
{
    public partial class FrmInicioSesion : Form
    {
        private string? temaActual;
        Serializadora<ConfigAPP> jsonConfig;
        public FrmInicioSesion()
        {
            InitializeComponent();
            lblMail.Visible = false;
            lblContrasenia.Visible = false;
            txtContrasenia.Visible = false;
            txtMail.Visible = false;
            btnLogearse.Visible = false;

            Serializadora<Usuarios> serializadora = new Serializadora<Usuarios>();
            MiAerolinea.listaUsuarios = serializadora.Deserializar<List<Usuarios>>("usuarios.json");
            jsonConfig = new Serializadora<ConfigAPP>();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Metodo que inicia sesion en el sistema
        /// </summary>
        private void IniciarSesion()
        {
            try
            {
                DateTime fecha = DateTime.Now;
                string fechaSinHora = fecha.ToString("dd/MM/yyyy");
                string rutaArchivo = "logUsuarios.txt";
                bool usuarioEncontrado = false;
                if(MiAerolinea.listaUsuarios is not null)
                {
                    foreach (Usuarios miUsuario in MiAerolinea.listaUsuarios)
                    {
                        if (miUsuario.Correo == txtMail.Text && miUsuario.Clave == txtContrasenia.Text)
                        {
                            usuarioEncontrado = true;
                            using (StreamWriter archivo = new StreamWriter(rutaArchivo, true))
                            {
                                if (miUsuario.Nombre is not null && miUsuario.Apellido is not null)
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
                                }
                                this.txtContrasenia.Text = null;
                                this.txtMail.Text = null;
                                archivo.Flush();
                            }
                        }
                    }
                }

                if (!usuarioEncontrado)
                {
                    throw new MiExcepcion("Correo o contraseña incorrectos. Por favor, inténtelo nuevamente.");
                }
            }
            catch (MiExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ex.GuardarMiExcepcion();
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            ConfigAPP config = jsonConfig.Deserializar<ConfigAPP>("config.json");
            this.temaActual = config.Tema;

            switch (this.temaActual)
            {
                case "Oscuro":
                    this.panelMenu.BackColor = Color.FromArgb(84, 84, 84);
                    break;

                case "Claro":
                    this.panelMenu.BackColor = Color.SteelBlue;
                    break;

                case "Verde":
                    this.panelMenu.BackColor = Color.FromArgb(109, 143, 88);
                    break;

                case "Rojo":
                    this.panelMenu.BackColor = Color.FromArgb(194, 95, 95);
                    break;
            }
        }
    }
}
