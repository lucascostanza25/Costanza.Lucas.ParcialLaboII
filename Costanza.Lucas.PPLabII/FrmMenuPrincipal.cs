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
        public FrmMenuPrincipal(string nombre, string apellido, string perfil, string fecha)
        {
            InitializeComponent();

            lblInformacionOperador.Text = $"Bienvenido {nombre} {apellido} - Perfil: {perfil} - Fecha: {fecha}";

            PintarForm(perfil);
        }

        private void PintarForm(string perfil)
        {
            switch(perfil) 
            {
                case "vendedor":

                    break;

                case "supervisor":

                    break;

                case "administrador":

                    break;
            }
        }
    }
}
