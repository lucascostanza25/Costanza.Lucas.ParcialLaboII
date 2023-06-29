using Aspose.Pdf;
using Entidades.PPLabII;
using System.Text;

namespace Costanza.Lucas.PPLabII
{
    public partial class Supervisor : FrmVendedor
    {
        Vuelos vuelo;
        private string temaActual;
        Serializadora<ConfigAPP> jsonConfig;
        TimeSpan tiempoRestante;
        Vuelos vueloMasCercano;
        public Supervisor(string nombre, string apellido, string fecha, string cargo)
        {
            InitializeComponent();
            vuelo = new Vuelos();
            this.btnVenderVueloLateral.Enabled = false;
            OcultarMenu();

            lblInformacionTrabajador.Text = $"¡Bienvenido {cargo}!\n" +
                $"¡{nombre} {apellido}!\n" +
                $"Fecha: {fecha}";
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {

            FrmCrearModificarPersonas formAgregarPasajero = new FrmCrearModificarPersonas("Crear pasajero SUPERVISOR", 0, vuelo);
            formAgregarPasajero.ShowDialog();
            if (MiAerolinea.listaVuelos is not null)
                CrearDataGridViewVuelos(dgvDatosVuelos, MiAerolinea.listaVuelos);
            dgvPasajeros.Rows.Clear();

        }

        private void Supervisor_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void pbGuardarPdf_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            lista.Add(MiAerolinea.EstadisticaVueloMasPasajeros());
            lista.Add(MiAerolinea.EstadisticaRecaudacionTotalVuelos());
            lista.Add(MiAerolinea.EstadisticaVueloMasRecaudo());
            lista.Add(MiAerolinea.EstadisticaRecaudacionTodosLosVuelo());
            GuardarPdf(lista);
        }

        private void GuardarPdf(List<string> lineas)
        {
            Document documento = new Document();
            Page pagina = documento.Pages.Add();

            foreach(string texto in lineas)
            {
                pagina.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(texto));
            }

            documento.Save("estadisticas.pdf");
        }
    }
}
