using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Vuelos
    {
        private DestinosNacionalesVuelos origenVuelo;
        private DestinosNacionalesVuelos destinoVuelo;
        private DateTime fechaVuelo;
        private double precio;
        private List<Pasajeros> listaPasajeros = new List<Pasajeros>();
        private int asientosDisponibles;
        private int asientosOcupados;
        private Aviones avionVuelo;
        private string codigoVuelo;
        private string marcaAvion;

        public Vuelos(DestinosNacionalesVuelos origenVuelo, DestinosNacionalesVuelos destinoVuelo, DateTime fechaVuelo, double precio, List<Pasajeros> lista, Aviones avionVuelo, string codigoVuelo)
        {
            this.origenVuelo = origenVuelo;
            this.destinoVuelo = destinoVuelo;
            this.fechaVuelo = fechaVuelo;
            this.precio = precio;
            this.listaPasajeros = lista;
            this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaPasajeros.Count();
            this.asientosOcupados = listaPasajeros.Count();
            this.avionVuelo = avionVuelo;
            this.marcaAvion = avionVuelo.ModeloAvion;
            this.codigoVuelo = codigoVuelo;
        }

        public void AgregarPasajero(string nombre, string apellido, int dni, int edad)
        {
            listaPasajeros.Add(new Pasajeros(nombre, apellido, dni, edad));
        }

        public Pasajeros BuscarPasajeros(int dni)
        {
            Pasajeros pasajeroABuscar = new Pasajeros();
            foreach(Pasajeros pasajeroBuscado in listaPasajeros)
            {
                if(pasajeroBuscado.Dni == dni)
                {
                    pasajeroABuscar = pasajeroBuscado;
                }
            }
            return pasajeroABuscar;
        }

        public static bool operator +(Vuelos v1, Vuelos v2)
        {
            if(v1.codigoVuelo == v2.codigoVuelo)
            {
                return true;
            }
            return false;
        }

        #region Propiedades

        public DestinosNacionalesVuelos OrigenVuelo
        {
            get { return origenVuelo; }
            set { destinoVuelo = value; }
        }

        public DestinosNacionalesVuelos DestinoVuelo
        {
            get { return destinoVuelo;}
            set { destinoVuelo = value; }
        }

        public DateTime FechaVuelo
        {
            get { return fechaVuelo;}
            set { fechaVuelo = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        
        public int AsientosDisponibles
        {
            get { return asientosDisponibles; }
            set { asientosDisponibles = value; }
        }

        public int AsientosOcupados
        {
            get { return asientosOcupados; }
            set { asientosOcupados = value; }
        }

        public Aviones AvionVuelo
        {
            get { return avionVuelo; }
            set { avionVuelo = value;}
        }

        public string CodigoVuelo
        {
            get { return codigoVuelo; }
            set { codigoVuelo = value; }      
        }
        #endregion
    }
}
