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
        private int asientosPremiumOcupados;
        private string codigoVuelo;
        private DestinosVuelos destino;
        private DestinosVuelos origen;
        private int horasVuelo;
        private double precioVuelo;
        private double capacidadDisponibleBodega;
        private double capacidadTotalBodega;
        private double cantidadDineroRecaudado;

        public Vuelos()
        {
           
        }

        public Vuelos(Aviones avionVuelo, DateTime fechaVuelo, string codigo, DestinosVuelos origen, DestinosVuelos destino, int horasVuelo, double precioVuelo)
        {
            this.avionVuelo = avionVuelo;
            this.fechaVuelo = fechaVuelo;
            this.codigoVuelo = codigo;
            this.horasVuelo = horasVuelo;
            this.precioVuelo = horasVuelo * precioVuelo;
            this.destino = destino;
            this.origen = origen;
            this.capacidadTotalBodega = avionVuelo.CapacidadBodega;
        }

        public Vuelos(List<Pasajeros> listaPasajeros, Aviones avionVuelo, DateTime fechaVuelo, string codigo, DestinosVuelos origen, DestinosVuelos destino, int horasVuelo, double precioVuelo) : this(avionVuelo, fechaVuelo, codigo, origen, destino, horasVuelo, precioVuelo)
        {
            this.listaPasajeros = listaPasajeros;
     
            this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaPasajeros.Count();
            this.asientosPremium = (int)avionVuelo.CantidadAsientosPremium;
            this.asientosOcupados = listaPasajeros.Count();
            
            this.cantidadDineroRecaudado = precioVuelo * listaPasajeros.Count();
        }

        public double CalcularPrecioVuelo(bool estado)
        {
            double precioFinal = this.precioVuelo;

            if (estado)
            {
                precioFinal *= 1.35;
                precioFinal *= 1.21; //Se suma el iva
            }
            else
            {
                precioFinal *= 1.21; //Se suma el iva
            }

            return precioFinal;
        }

        public void ActualizarDatosVuelo(List<Pasajeros> listaNuevaPasajeros)
        {
            this.asientosDisponibles = 0;
            this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaNuevaPasajeros.Count();
            this.asientosOcupados = listaNuevaPasajeros.Count();
            this.asientosPremiumOcupados = 0;
            this.capacidadDisponibleBodega = 0;
            double pesoTotal = 0; 
            foreach(Pasajeros pasajero in listaNuevaPasajeros)
            {
                if(pasajero.AsientoPremium)
                {
                    this.asientosPremiumOcupados++;
                }
                pesoTotal += pasajero.PesoEquipajeUno + pasajero.PesoEquipajeDos;
            }
            this.capacidadDisponibleBodega = this.capacidadTotalBodega - pesoTotal;
        }

        public static bool operator ==(Vuelos v1, Vuelos v2)
        {
            if (v1.CodigoVuelo == v2.codigoVuelo)
                return true; 
            return false;
        }

        public static bool operator !=(Vuelos v1, Vuelos v2)
        {
            return !(v1 == v2);
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
        
        public double CantidadDineroRecuadado
        {
            get { return cantidadDineroRecaudado; }
            set { cantidadDineroRecaudado = value; }
        }

        public double CapacidadDisponibleBodega
        {
            get { return capacidadDisponibleBodega; }
            set { capacidadDisponibleBodega = value; }
        }
    }
}
