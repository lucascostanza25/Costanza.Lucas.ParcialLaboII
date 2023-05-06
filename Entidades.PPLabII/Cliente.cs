using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Cliente : Persona
    {
        double dineroDisponible;
        int dni;
        string mail;
        bool asientoPremium;

        public Cliente(string nombre, string apellido, double dineroDisponible, int dni, string mail) : base(nombre, apellido)
        {
            this.dineroDisponible = dineroDisponible;
            this.dni = dni;
            this.mail = mail;
        }

        public double DineroDisponible
        {
            get { return dineroDisponible; }
            set { dineroDisponible = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; } 
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public bool AsientoPremium
        {
            get { return asientoPremium; }
            set { asientoPremium = value; }
        }
    }
}
