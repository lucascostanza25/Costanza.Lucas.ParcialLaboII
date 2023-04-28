using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    [XmlInclude(typeof(VuelosNacionales))]
    public class Vuelos
    {
        private List<Pasajeros> listaPasajeros;
        private Aviones avionVuelo;
        private DateTime fechaVuelo;
        private int asientosDisponibles;
        private int asientosOcupados;
        private int asientosPremium;
        private string codigoVuelo;

        public Vuelos()
        {
            this.listaPasajeros = new List<Pasajeros>();
            this.avionVuelo = new Aviones();
            this.asientosDisponibles = 0;
            this.asientosOcupados = 0;
            this.codigoVuelo = "";
        }

        public Vuelos(List<Pasajeros> listaPasajeros, Aviones avionVuelo, DateTime fechaVuelo, string codigo)
        {
            this.listaPasajeros = listaPasajeros;
            this.avionVuelo = avionVuelo;
            this.fechaVuelo = fechaVuelo;
            this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaPasajeros.Count();
            this.asientosPremium = (int)avionVuelo.CantidadAsientosPremium;
            this.asientosOcupados = listaPasajeros.Count();
            this.codigoVuelo = codigo;
        }

        [XmlElement("pasajeros")]
        public List<Pasajeros> ListaPasajeros
        {
            get { return this.listaPasajeros; }
            set { this.listaPasajeros = value; }
        }
        [XmlElement("avion")]
        public Aviones AvionVuelo
        {
            get { return this.avionVuelo; }
            set { this.avionVuelo = value; }
        }
        [XmlElement("fecha")]
        public DateTime FechaVuelo
        {
            get { return this.fechaVuelo; }
            set { this.fechaVuelo = value; }
        }
        [XmlElement("asientos_disponibles")]
        public int AsientosDisponibles
        {
            get { return this.asientosDisponibles; }
            set { this.asientosDisponibles = value; }
        }
        [XmlElement("asientos_ocupados")]
        public int AsientosOcupados
        {
            get { return this.asientosOcupados; }
            set { this.asientosOcupados = value; }
        }
        [XmlElement("codigo")]
        public string CodigoVuelo
        {
            get { return this.codigoVuelo; }
            set { this.codigoVuelo = value; }
        }
    }
}
