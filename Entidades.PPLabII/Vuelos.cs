using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    public class Vuelos
    {
        private List<Pasajeros> listaPasajeros;
        private Aviones avionVuelo;
        private DateTime fechaVuelo;
        private int asientosDisponibles;
        private int asientosOcupados;
        private int asientosPremium;
        private string codigoVuelo;
        private DestinosVuelos destino;
        private DestinosVuelos origen;
        private int horasVuelo;
        private double precioVuelo;
        private double capacidadDisponibleBodega;

        public Vuelos()
        {
           
        }

        public Vuelos(List<Pasajeros> listaPasajeros, Aviones avionVuelo, DateTime fechaVuelo, string codigo, DestinosVuelos origen, DestinosVuelos destino, int horasVuelo, double precioVuelo)
        {
            this.listaPasajeros = listaPasajeros;
            this.avionVuelo = avionVuelo;
            this.fechaVuelo = fechaVuelo;
            this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaPasajeros.Count();
            this.asientosPremium = (int)avionVuelo.CantidadAsientosPremium;
            this.asientosOcupados = listaPasajeros.Count();
            this.codigoVuelo = codigo;
            this.horasVuelo = horasVuelo;
            this.precioVuelo = horasVuelo * precioVuelo;
            this.destino = destino;
            this.origen = origen;
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
        [XmlElement("origen")]
        public DestinosVuelos Origen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }
        [XmlElement("destino")]
        public DestinosVuelos Destino
        {
            get { return this.destino; }
            set { this.destino = value; }
        }
        [XmlElement("horas")]
        public int HorasVuelo
        {
            get { return this.horasVuelo; }
            set { this.horasVuelo = value; }
        }
        [XmlElement("precio")]
        public double PrecioVuelo
        {
            get { return this.precioVuelo; }
            set { this.precioVuelo = value; }
        }
    }
}
