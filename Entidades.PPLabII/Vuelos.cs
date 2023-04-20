using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Vuelos
    {
        private string origenVuelo;
        private string destinoVuelo;
        private DateTime horaPartidavuelo;
        private double precio;
        private List<Pasajeros> listaPasajeros;

        public Vuelos(string origenVuelo, string destinoVuelo, DateTime horaPartidavuelo, double precio)
        {
            this.origenVuelo = origenVuelo;
            this.destinoVuelo = destinoVuelo;
            this.horaPartidavuelo = horaPartidavuelo;
            this.precio = precio;
            listaPasajeros = new List<Pasajeros>();
        }

        public void AgregarPasajero(string nombre, string apellido, int dni, int edad)
        {
            listaPasajeros.Add(new Pasajeros(nombre, apellido, dni, edad));
        }
    }
}
