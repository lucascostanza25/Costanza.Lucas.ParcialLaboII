using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    [FirestoreData]
    public class Vuelos
    {
        private List<Pasajeros> listaPasajeros = new List<Pasajeros>();
        private Aviones? avionVuelo;
        private DateTime fechaVuelo;
        private int asientosDisponibles;
        private int asientosOcupados;
        private int asientosPremium;
        private int asientosPremiumOcupados;
        private string? codigoVuelo;
        private DestinosVuelos destino;
        private DestinosVuelos origen;
        private int horasVuelo;
        private double precioVuelo;
        private double capacidadDisponibleBodega;
        private double capacidadTotalBodega;
        private double cantidadDineroRecaudado;

        public Vuelos()
        {

        }

        public Vuelos(DateTime fecha, string codigo, DestinosVuelos origen, DestinosVuelos destino, int horas, double precio, string matriculaAvion)
        {
            this.fechaVuelo = DateTime.SpecifyKind(fecha, DateTimeKind.Utc);
            this.codigoVuelo = codigo;
            this.destino = destino;
            this.origen = origen;
            this.horasVuelo = horas;
            this.precioVuelo = precio;
            this.avionVuelo = BuscarAvion(matriculaAvion);
            if (avionVuelo is not null)
            {
                this.capacidadTotalBodega = avionVuelo.CapacidadBodega;
            }
        }

        public Vuelos(DateTime fecha, string codigo, DestinosVuelos origen, DestinosVuelos destino, int horas, double precio, string matriculaAvion, List<Pasajeros> listaPasajeros ) : this(fecha, codigo, origen, destino, horas, precio, matriculaAvion)
        {
            this.listaPasajeros = listaPasajeros;
            if (avionVuelo is not null)
            {
                this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaPasajeros.Count();
                this.asientosPremium = (int)avionVuelo.CantidadAsientosPremium;
                this.asientosOcupados = listaPasajeros.Count();

                this.cantidadDineroRecaudado = precioVuelo * listaPasajeros.Count();
            }
        }

        public static Aviones BuscarAvion(string matricula)
        {
            Aviones avionBuscado = new Aviones();
            foreach (Aviones avion in MiAerolinea.listaAviones)
            {
                if (avion.Matricula == matricula)
                {
                    avionBuscado = avion;
                }
            }
            return avionBuscado;
        }

        public double CalcularPrecioVuelo(bool estado)
        {
            double precioFinal = this.precioVuelo;

            if (estado)
            {
                precioFinal *= 1.35;
                precioFinal *= 1.21; //Se suma el iva
            }
            else
            {
                precioFinal *= 1.21; //Se suma el iva
            }

            return precioFinal;
        }

        public void ActualizarDatosVuelo(List<Pasajeros> listaNuevaPasajeros)
        {
            this.asientosDisponibles = 0;
            this.asientosDisponibles = (int)avionVuelo.CantidadAsientos - listaNuevaPasajeros.Count();
            this.asientosOcupados = listaNuevaPasajeros.Count();
            this.asientosPremiumOcupados = 0;
            this.capacidadDisponibleBodega = 0;
            double pesoTotal = 0;
            foreach (Pasajeros pasajero in listaNuevaPasajeros)
            {
                if (pasajero.AsientoPremium)
                {
                    this.asientosPremiumOcupados++;
                }
                pesoTotal += pasajero.PesoEquipajeUno + pasajero.PesoEquipajeDos;
            }
            this.capacidadDisponibleBodega = this.capacidadTotalBodega - pesoTotal;
        }

        public static bool operator ==(Vuelos v1, Vuelos v2)
        {
            if (v1.CodigoVuelo == v2.codigoVuelo)
                return true;
            return false;
        }

        public static bool operator !=(Vuelos v1, Vuelos v2)
        {
            return !(v1 == v2);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"VUELO: {CodigoVuelo}");
            sb.AppendLine($"ORIGEN: {Origen}");
            sb.AppendLine($"DESTINO: {Destino}");
            sb.AppendLine($"FECHA: {FechaVuelo.ToString()}");
            sb.AppendLine($"AVION: {AvionVuelo.ModeloAvion}");

            return sb.ToString();
        }

        [FirestoreProperty]
        public List<Pasajeros> ListaPasajeros
        {
            get { return this.listaPasajeros; }
            set { this.listaPasajeros = value; }
        }
        [FirestoreProperty]
        public Aviones AvionVuelo
        {
            get { return this.avionVuelo; }
            set { this.avionVuelo = value; }
        }
        [FirestoreProperty]
        public DateTime FechaVuelo
        {
            get { return this.fechaVuelo; }
            set { this.fechaVuelo = value; }
        }
        [FirestoreProperty]
        public int AsientosDisponibles
        {
            get { return this.asientosDisponibles; }
            set { this.asientosDisponibles = value; }
        }
        [FirestoreProperty]
        public int AsientosOcupados
        {
            get { return this.asientosOcupados; }
            set { this.asientosOcupados = value; }
        }
        [FirestoreProperty]
        public string CodigoVuelo
        {
            get { return this.codigoVuelo; }
            set { this.codigoVuelo = value; }
        }
        [FirestoreProperty(ConverterType = typeof(FirestoreEnumNameConverter<DestinosVuelos>))]
        public DestinosVuelos Origen
        {
            get { return this.origen; }
            set { this.origen = value; }
        }
        [FirestoreProperty(ConverterType = typeof(FirestoreEnumNameConverter<DestinosVuelos>))]
        public DestinosVuelos Destino
        {
            get { return this.destino; }
            set { this.destino = value; }
        }
        [FirestoreProperty]
        public int HorasVuelo
        {
            get { return this.horasVuelo; }
            set { this.horasVuelo = value; }
        }
        [FirestoreProperty]
        public double PrecioVuelo
        {
            get { return this.precioVuelo; }
            set { this.precioVuelo = value; }
        }
        [FirestoreProperty]
        public double CantidadDineroRecuadado
        {
            get { return cantidadDineroRecaudado; }
            set { cantidadDineroRecaudado = value; }
        }
        [FirestoreProperty]
        public double CapacidadDisponibleBodega
        {
            get { return capacidadDisponibleBodega; }
            set { capacidadDisponibleBodega = value; }
        }
    }
}
