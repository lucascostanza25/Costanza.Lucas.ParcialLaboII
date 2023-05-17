﻿using System;
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
        /// <summary>
        /// Metodo override que devuelve los datos de un pasajero
        /// </summary>
        /// <returns>Retorna los datos de un pasajero en formato string</returns>
        protected override string Datos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {Nombre}");
            sb.AppendLine($"APELLIDO: {Apellido}");
            sb.AppendLine($"EDAD: {Edad}");
            sb.AppendLine($"DNI: {Dni.ToString()}");
            sb.AppendLine($"GENERO: {Genero}");
            sb.AppendLine($"CANTIDAD DE EQUIPAJE: {CantidadEquipaje}");
            sb.AppendLine($"- Peso primer equipaje: {PesoEquipajeUno}");
            if (AsientoPremium)
            {
                sb.AppendLine($"- Peso segundo equipaje: {PesoEquipajeDos}");
            }


            return sb.ToString();
        }
        /// <summary>
        /// Override del metodo .toString()
        /// </summary>
        /// <returns>Retorna los datos del metodo Datos()</returns>
        public override string ToString()
        {
            return Datos();
        }
        /// <summary>
        /// Sobrecarga del operador == que compara 2 pasajeros
        /// </summary>
        /// <param name="p1">Pasajero 1</param>
        /// <param name="p2">Pasajero 2</param>
        /// <returns>Retorna true si tienen los dni iguales o false sino</returns>
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
