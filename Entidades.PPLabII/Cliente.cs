using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    [FirestoreData]
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

        public Cliente()
        {

        }

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

        [FirestoreProperty]
        public double DineroDisponible
        {
            get { return dineroDisponible; }
            set { dineroDisponible = value; }
        }

        [FirestoreProperty]
        public int Dni
        {
            get { return dni; }
            set { dni = value; } 
        }

        [FirestoreProperty]
        public bool AsientoPremium
        {
            get { return asientoPremium; }
            set { asientoPremium = value; }
        }

        [FirestoreProperty]
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        [FirestoreProperty]
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        [FirestoreProperty]
        public int CantidadEquipaje
        {
            get { return cantidadEquipaje; }
            set { cantidadEquipaje = value; }
        }

        [FirestoreProperty]
        public double PesoEquipajeUno
        {
            get { return pesoEquipajeUno; }
            set { pesoEquipajeUno = value; }
        }

        [FirestoreProperty]
        public double PesoEquipajeDos
        {
            get { return pesoEquipajeDos; }
            set { pesoEquipajeDos = value; }
        }
    }
}
