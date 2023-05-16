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
        bool asientoPremium;
        string genero;
        int cantidadEquipaje;
        double pesoEquipajeUno;
        double pesoEquipajeDos;

        public Cliente(string apellido, string nombre, double dineroDisponible, int dni, int edad, bool asientoPremium, string genero, int cantidadEquipaje, double pesoEquipajeUno, double pesoEquipajeDos) : base(apellido, nombre)
        {
            this.dineroDisponible = dineroDisponible;
            this.dni = dni;
            this.asientoPremium = asientoPremium;
            this.edad = edad;
            this.genero = genero;
            this.cantidadEquipaje = cantidadEquipaje;
            this.pesoEquipajeUno = pesoEquipajeUno;
            this.pesoEquipajeDos = pesoEquipajeDos;
        }

        protected override string Datos()
        {
            throw new NotImplementedException();
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

        public bool AsientoPremium
        {
            get { return asientoPremium; }
            set { asientoPremium = value; }
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

        public int CantidadEquipaje
        {
            get { return cantidadEquipaje; }
            set { cantidadEquipaje = value; }
        }

        public double PesoEquipajeUno
        {
            get { return pesoEquipajeUno; }
            set { pesoEquipajeUno = value; }
        }

        public double PesoEquipajeDos
        {
            get { return pesoEquipajeDos; }
            set { pesoEquipajeDos = value; }
        }
    }
}
