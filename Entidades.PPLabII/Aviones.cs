using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    public class Aviones
    {
        private string matricula;
        private double cantidadAsientos;
        private double cantidadAsientosPremium;
        private bool servicioInternet;
        private bool servicioComida;
        private double capacidadBodega;
        private string modeloAvion;
        private string codigoVuelo;

        public Aviones()
        {
            this.matricula = "";
            this.cantidadAsientos = 0;
            this.servicioInternet = false;
            this.servicioComida = false;
            this.capacidadBodega = 0;
            this.cantidadAsientosPremium = cantidadAsientos * 0.2;
            this.modeloAvion = "";
            this.codigoVuelo = "";
        }

        public Aviones(string matricula, double cantidadAsientos, bool servicioInternet, bool servicioComida, double capacidadBodega, string modeloAvion, string codigoVuelo)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.servicioInternet = servicioInternet;
            this.servicioComida = servicioComida;
            this.capacidadBodega = capacidadBodega;
            this.cantidadAsientosPremium = cantidadAsientos * 0.2;
            this.modeloAvion = modeloAvion;
            this.codigoVuelo = codigoVuelo;
        }

        #region Propiedades
        [XmlElement("matricula")]
        [JsonPropertyName("matricula")]
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        [XmlElement("cantidad_asientos")]
        [JsonPropertyName("cantidad_asientos")]
        public double CantidadAsientos
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }
        [XmlElement("cantidad_asientos_premium")]
        [JsonPropertyName("cantidad_asientos_premium")]
        public double CantidadAsientosPremium
        {
            get { return cantidadAsientosPremium; }
            set { cantidadAsientos = value; }
        }
        [XmlElement("servicio_internet")]
        [JsonPropertyName("servicio_internet")]
        public bool ServicioInternet
        {
            get { return servicioInternet; }
            set { servicioInternet = value; }
        }
        [XmlElement("servicio_comida")]
        [JsonPropertyName("servicio_comida")]
        public bool ServicioComida
        {
            get { return servicioComida; }
            set { servicioComida = value; }
        }
        [XmlElement("capacidad_bodega")]
        [JsonPropertyName("capacidad_bodega")]
        public double CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }
        [XmlElement("modelo")]
        [JsonPropertyName("modelo")]
        public string ModeloAvion
        {
            get { return modeloAvion; }
            set { modeloAvion = value; }
        }
        [XmlElement("codigo")]
        [JsonPropertyName("codigo")]
        public string CodigoVuelo
        {
            get { return codigoVuelo; }
            set { codigoVuelo = value; }
        }
        #endregion

        public static bool operator == (Aviones a1, Aviones a2)
        {
            if (a1.codigoVuelo == a2.codigoVuelo)
                return true;
            else return false;
        }

        public static bool operator !=(Aviones a1, Aviones a2)
        {
            return !(a1 == a2);
        }
    }
}
