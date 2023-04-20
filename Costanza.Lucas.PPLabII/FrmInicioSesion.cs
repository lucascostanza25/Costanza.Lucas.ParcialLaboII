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
            listaUsuarios = miAerolinea.CargarUsuariosJson();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal formMenu;
            DateTime fecha = DateTime.Now;
            string fechaSinHora = fecha.ToString("dd/MM/yyyy");
            foreach(Usuarios miUsuario in listaUsuarios)
            {
                if(miUsuario.Correo == txtMail.Text && miUsuario.Clave == txtContrasenia.Text)
                {
                    switch(miUsuario.Perfil)
                    {
                        case "vendedor":
                            formMenu = new FrmMenuPrincipal(miUsuario.Nombre, miUsuario.Apellido, miUsuario.Perfil, fechaSinHora);
                            formMenu.ShowDialog();
                            break;

                        case "supervisor":
                            formMenu = new FrmMenuPrincipal(miUsuario.Nombre, miUsuario.Apellido, miUsuario.Perfil, fechaSinHora);
                            formMenu.ShowDialog();
                            break;

                        case "administrador":
                            formMenu = new FrmMenuPrincipal(miUsuario.Nombre, miUsuario.Apellido, miUsuario.Perfil, fechaSinHora);
                            formMenu.ShowDialog();
                            break;
                    }
                }
            }
        }
    }
}