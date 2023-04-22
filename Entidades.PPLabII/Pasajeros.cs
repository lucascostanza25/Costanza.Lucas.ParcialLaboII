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

        public Pasajeros()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            this.edad = 0;
        }

        public Pasajeros(string nombre, string apellido, int dni, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }

        public static bool operator ==(Pasajeros p1, Pasajeros p2)
        {
            if (p1.Dni == p2.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Pasajeros p1, Pasajeros p2)
        {
            return !(false);
        }

        #region Propiedades
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
        #endregion
    }
}
