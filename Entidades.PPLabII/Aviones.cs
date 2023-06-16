using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    [FirestoreData]
    public class Aviones
    {
        private string matricula;
        private int cantidadAsientos;
        private int cantidadAsientosPremium;
        private int cantidadAsientosNormales;
        private bool servicioInternet;
        private bool servicioComida;
        private double capacidadBodega;
        private string modeloAvion;

        public Aviones()
        {
            this.matricula = "";
            this.cantidadAsientos = 0;
            this.servicioInternet = false;
            this.servicioComida = false;
            this.capacidadBodega = 0;
            this.cantidadAsientosPremium = (int)Math.Round(cantidadAsientos * 0.2);
            this.modeloAvion = "";
        }
        [JsonConstructor]
        public Aviones(string matricula, int cantidadAsientos, bool servicioInternet, bool servicioComida, double capacidadBodega, string modeloAvion, int cantidadAsientosNormales, int cantidadAsientosPremium)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.servicioInternet = servicioInternet;
            this.servicioComida = servicioComida;
            this.capacidadBodega = capacidadBodega;
            this.cantidadAsientosPremium = cantidadAsientosPremium;
            this.cantidadAsientosNormales = cantidadAsientosNormales;
            this.modeloAvion = modeloAvion;
        }

        #region Propiedades
        [XmlElement("matricula")]
        [JsonPropertyName("matricula")]
        [FirestoreProperty]
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        [XmlElement("cantidad_asientos")]
        [JsonPropertyName("cantidad_asientos")]
        [FirestoreProperty]
        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }
        [XmlElement("cantidad_asientos_premium")]
        [JsonPropertyName("cantidad_asientos_premium")]
        [FirestoreProperty]
        public int CantidadAsientosPremium
        {
            get { return cantidadAsientosPremium; }
            set { cantidadAsientosPremium = value; }
        }
        [FirestoreProperty]
        public int CantidadAsientosNormales
        {
            get { return cantidadAsientosNormales; }
            set { cantidadAsientosNormales = value; }
        }
        [XmlElement("servicio_internet")]
        [JsonPropertyName("servicio_internet")]
        [FirestoreProperty]
        public bool ServicioInternet
        {
            get { return servicioInternet; }
            set { servicioInternet = value; }
        }
        [XmlElement("servicio_comida")]
        [JsonPropertyName("servicio_comida")]

        public bool ServicioComida
        {
            get { return servicioComida; }
            set { servicioComida = value; }
        }
        [XmlElement("capacidad_bodega")]
        [JsonPropertyName("capacidad_bodega")]
        [FirestoreProperty]
        public double CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }
        [XmlElement("modelo")]
        [JsonPropertyName("modelo")]
        [FirestoreProperty]
        public string ModeloAvion
        {
            get { return modeloAvion; }
            set { modeloAvion = value; }
        }
        #endregion

        public static bool operator ==(Aviones a1, Aviones a2)
        {
            if (a1.Matricula == a2.Matricula)
                return true;
            else return false;
        }

        public static bool operator !=(Aviones a1, Aviones a2)
        {
            return !(a1 == a2);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
