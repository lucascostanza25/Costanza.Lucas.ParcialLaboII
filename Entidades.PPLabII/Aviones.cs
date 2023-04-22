using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Aviones
    {
        private string matricula;
        private double cantidadAsientos;
        private double cantidadAsientosPremium;
        private bool servicioInternet;
        private bool servicioComida;
        private double capacidadBodega;
        private string modeloAvion;

        public Aviones(string matricula, double cantidadAsientos, bool servicioInternet, bool servicioComida, double capacidadBodega, string modeloAvion)
        {
            this.matricula = matricula;
            this.cantidadAsientos = cantidadAsientos;
            this.servicioInternet = servicioInternet;
            this.servicioComida = servicioComida;
            this.capacidadBodega = capacidadBodega;
            this.cantidadAsientosPremium = cantidadAsientos * 0.2;
            this.modeloAvion = modeloAvion;
        }

        #region Propiedades

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public double CantidadAsientos
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }

        public bool ServicioInternet
        {
            get { return servicioInternet; }
            set { servicioInternet = value; }
        }

        public bool ServicioComida
        {
            get { return servicioComida; }
            set { servicioComida = value; }
        }
        
        public double CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }

        public string ModeloAvion
        {
            get { return modeloAvion; }
        }

        #endregion
    }
}
