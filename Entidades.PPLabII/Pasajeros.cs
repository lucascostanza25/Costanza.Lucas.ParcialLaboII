using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Pasajeros
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;

        public Pasajeros(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
