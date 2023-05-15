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
    public partial class Supervisor : FrmMenuPrincipal
    {
        Vuelos vuelo;
        public Supervisor()
        {
            InitializeComponent();
            vuelo = new Vuelos();
            this.btnVenderVueloLateral.Enabled = false;
            //OcultarGroupBox();
            OcultarMenu();
        }

        public Supervisor(string nombre, string apellido, string fecha) : this()
        {

        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            string? codigoVueloSeleccionado = dgvDatosVuelos.SelectedRows[0].Cells["codigo"].Value.ToString();
            vuelo = MiAerolinea.BuscarUnVuelo(codigoVueloSeleccionado);
            FrmCrearModificarPersonas formAgregarPasajero = new FrmCrearModificarPersonas("Agregar pasajero SUPERVISOR", 3, -1, vuelo);
            formAgregarPasajero.ShowDialog();
            CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
            dgvPasajeros.Rows.Clear();
        }

        //protected void OcultarMenu()
        //{
        //    this.panelMenuVuelos.Visible = false;
        //    this.panelMenuEstadisticas.Visible = false;
        //}

        //protected void PintarSubMenu()
        //{
        //    if (panelMenuVuelos.Visible == true)
        //    {
        //        panelMenuVuelos.Visible = false;
        //    }
        //    if (panelMenuEstadisticas.Visible == true)
        //    {
        //        panelMenuEstadisticas.Visible = false;
        //    }
        //}

        //protected void MostrarMenu(Panel menu)
        //{
        //    if (menu.Visible == false)
        //    {
        //        PintarSubMenu();
        //        menu.Visible = true;
        //    }
        //    else
        //        menu.Visible = false;
        //}
    }
}
