using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    public class Pasajeros : Persona
    {
        private int dni;
        private int edad;
        private string genero;
        private bool asientoPremium;
        private int cantidadEquipajes;
        private double pesoEquipajeUno;
        private double pesoEquipajeDos;

        public Pasajeros()
        {
            this.dni = 0;
            this.edad = 0;
            this.genero = "";
            this.asientoPremium = false;
        }

        public Pasajeros(string apellido, string nombre, int dni, int edad, string genero, bool asientoPremium) : base(apellido, nombre)
        {
            this.dni = dni;
            this.edad = edad;
            this.genero = genero;
            this.asientoPremium = asientoPremium;
        } 

        public Pasajeros(string apellido, string nombre, int dni, int edad, string genero, bool asientoPremium, int cantidadEquipaje, double pesoUno, double pesoDos) : this(apellido, nombre, dni, edad, genero, asientoPremium)
        {
            this.cantidadEquipajes = cantidadEquipaje;
            this.pesoEquipajeUno = pesoUno;
            this.pesoEquipajeDos = pesoDos;
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

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region Propiedades
        [XmlElement("dni")]
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        [XmlElement("edad")]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        [XmlElement("genero")]
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        [XmlElement("premium")]
        public bool AsientoPremium
        {
            get { return asientoPremium; }
            set { asientoPremium = value; }
        }
        [XmlElement("cantiad_equipajes")]
        public int CantidadEquipaje
        {
            get { return cantidadEquipajes; }
            set { cantidadEquipajes = value; }
        }
        [XmlElement("peso_quipaje_uno")]
        public double PesoEquipajeUno
        {
            get { return pesoEquipajeUno; }
            set { pesoEquipajeUno = value; }
        }
        [XmlElement("peso_equipaje_dos")]
        public double PesoEquipajeDos
        {
            get { return pesoEquipajeDos; }
            set { pesoEquipajeDos = value; }
        }
        #endregion
    }
}
