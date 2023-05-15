using Entidades.PPLabII;

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
            MiAerolinea.DeserializarAvionesJson("aviones.json");
            MiAerolinea.DeserializarVuelosXml();
            CrearDataPrueba();
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
            DateTime fecha = DateTime.Now;
            string fechaSinHora = fecha.ToString("dd/MM/yyyy");
            
            foreach (Usuarios miUsuario in MiAerolinea.listaUsuarios)
            {
                if (miUsuario.Correo == txtMail.Text && miUsuario.Clave == txtContrasenia.Text)
                {
                    switch (miUsuario.Perfil)
                    {
                        case "vendedor":
                            this.Hide();
                            FrmMenuPrincipal formMenu = new FrmMenuPrincipal(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil);
                            formMenu.ShowDialog();
                            this.Show();
                            break;

                        case "supervisor":
                            this.Hide();
                            Supervisor formSupervisor = new Supervisor(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil);
                            formSupervisor.ShowDialog();
                            this.Show();
                            break;

                        case "administrador":
                            this.Hide();
                            FrmAdministrador formAdministrador = new FrmAdministrador(miUsuario.Nombre, miUsuario.Apellido, fechaSinHora, miUsuario.Perfil);
                            formAdministrador.ShowDialog();
                            this.Show();
                            break;
                    }
                    this.txtContrasenia.Text = null;
                    this.txtMail.Text = null;
                    
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            Application.Exit();
        }

        private void CrearDataPrueba()
        {
           // MiAerolinea.listaAviones = new List<Aviones>();
           //// MiAerolinea.listaPasajeros = new List<Pasajeros>();
           // MiAerolinea.listaAviones.Add(new Aviones("FJS50OP", 65, false, true, 3500, "Boeing 787"));
           // MiAerolinea.listaAviones.Add(new Aviones("GLT049T", 120, true, true, 5500, "Airbus A220"));
           // MiAerolinea.listaAviones.Add(new Aviones("TRF053T", 80, false, false, 4500, "Airbus A110"));
           // MiAerolinea.listaAviones.Add(new Aviones("UYI5904", 65, false, false, 4000, "Boeing 678"));
           // MiAerolinea.listaAviones.Add(new Aviones("HLY095N", 250, true, true, 13000, "Boeing 777"));
           // MiAerolinea.listaAviones.Add(new Aviones("HTF078P", 300, true, true, 15000, "Airbus A380"));
           // MiAerolinea.listaAviones.Add(new Aviones("HCV0952", 350, true, true, 15000, "Boeing 777"));

            //MiAerolinea.DeserializarAvionesJson("aviones.json");
        
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


            //MiAerolinea.SerializarVuelosXml(MiAerolinea.listaVuelos);
            

            MiAerolinea.DespacharEquipajeDePasajerosHechos();
        }
    }
}