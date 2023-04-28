﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    public class Pasajeros
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private double pesoEquipaje;
        private string genero;
        private bool asientoPremium;

        public Pasajeros()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            this.edad = 0;
            this.pesoEquipaje = 0;
            this.genero = "";
            this.asientoPremium = false;
        }

        public Pasajeros(string nombre, string apellido, int dni, int edad, double pesoEquipaje, string genero, bool asientoPremium)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.pesoEquipaje = pesoEquipaje;
            this.genero = genero;
            this.asientoPremium = asientoPremium;
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
        [XmlElement("nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [XmlElement("apellido")]
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
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
        [XmlElement("peso_equipaje")]
        public double PesoEquipaje
        {
            get { return pesoEquipaje; }
            set { pesoEquipaje = value; }
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
        #endregion
    }
}
