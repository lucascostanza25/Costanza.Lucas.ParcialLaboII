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
        int edad;
        string mail;
        bool asientoPremium;
        double pesoEquipaje;
        string genero;
        //Agregar el origen y el destino
        //Agregar fecha

        public Cliente(string apellido, string nombre, double dineroDisponible, int dni, int edad, string mail, bool asientoPremium, double pesoEquipaje, string genero) : base(apellido, nombre)
        {
            this.dineroDisponible = dineroDisponible;
            this.dni = dni;
            this.mail = mail;
            this.asientoPremium = asientoPremium;
            this.pesoEquipaje = pesoEquipaje;
            this.edad = edad;
            this.genero = genero;
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

        public double PesoEquipaje
        {
            get { return pesoEquipaje; }
            set { pesoEquipaje = value; }
        }
        
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
    }
}
