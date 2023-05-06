using Entidades.PPLabII;

namespace Costanza.Lucas.PPLabII
{
    public partial class FrmInicioSesion : Form
    {
        public static List<Usuarios> listaUsuarios;
        public FrmInicioSesion()
        {
            InitializeComponent();
            listaUsuarios = new List<Usuarios>();
            listaUsuarios = MiAerolinea.CargarUsuariosJson();
            lblMail.Visible = false;
            lblContrasenia.Visible = false;
            txtContrasenia.Visible = false;
            txtMail.Visible = false;
            btnLogearse.Visible = false;
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
            List<Usuarios> copiaLista = listaUsuarios.ToList();
            foreach (Usuarios miUsuario in copiaLista)
            {
                if (miUsuario.Correo == txtMail.Text && miUsuario.Clave == txtContrasenia.Text)
                {
                    switch (miUsuario.Perfil)
                    {
                        case "vendedor":
                            //FrmVendedor formVendedor = new FrmVendedor(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora);
                            //formVendedor.ShowDialog();
                            FrmMenuPrincipal formMenu = new FrmMenuPrincipal(miUsuario.Nombre, miUsuario.Apellido, DateTime.Now.Date, miUsuario.Perfil);
                            formMenu.ShowDialog();
                            break;

                        case "supervisor":
                           
                            break;

                        case "administrador":
                            
                            break;
                    }
                    this.txtContrasenia.Text = null;
                    this.txtMail.Text = null;
                    this.Close();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            Application.Exit();
        }
    }
}