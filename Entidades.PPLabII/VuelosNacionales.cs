using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    [XmlRoot("VuelosNacionales")]
    public class VuelosNacionales : Vuelos
    {
        private DestinosNacionalesVuelos origenVuelo;
        private DestinosNacionalesVuelos destinoVuelo;
        private int horasVuelosNacionales;
        private double precioVuelosNacionales;

        public VuelosNacionales()
        {
            
        }

        public VuelosNacionales(List<Pasajeros> listaPasajeros, Aviones avionVuelo, DateTime fechaVuelo, string codigo, int horasVuelosNacionales, DestinosNacionalesVuelos origen, DestinosNacionalesVuelos destino) : base(listaPasajeros, avionVuelo, fechaVuelo, codigo)
        {
            this.horasVuelosNacionales = horasVuelosNacionales;
            this.precioVuelosNacionales = horasVuelosNacionales * 50;
            this.origenVuelo = origen;
            this.destinoVuelo = destino;
        }

        [XmlElement("origen")]
        public DestinosNacionalesVuelos OrigenVuelo
        {
            get { return this.origenVuelo; }
            set { this.origenVuelo = value; }
        }
        [XmlElement("destino")]
        public DestinosNacionalesVuelos DestinoVuelo
        {
            get { return this.destinoVuelo; }
            set { this.destinoVuelo = value; }
        }
        [XmlElement("horas")]
        public int HorasVuelosNacionales
        {
            get { return this.horasVuelosNacionales; }
            set { this.horasVuelosNacionales = value; }
        }
        [XmlElement("precio")]
        public double PrecioVuelosNacionales
        {
            get { return this.precioVuelosNacionales; }
            set { this.precioVuelosNacionales = value; }
        }
    }
}
