using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    public abstract class miAerolinea
    {
        public static List<Usuarios> listaUsuarios = new List<Usuarios>();
        public static List<Vuelos> listaVuelos = new List<Vuelos>();
        public static List<Pasajeros> listaPasajeros = new List<Pasajeros>();
        private static string archivoJsonUsuarios = File.ReadAllText(@"D:\Programacion\C#\UTN\Parciales\Costanza.Lucas.PPLabII\MOCK_DATA.json");
        

        public static List<Usuarios> CargarUsuariosJson()
        {
            List<Usuarios>? listaUsuariosDeserializados = JsonSerializer.Deserialize<List<Usuarios>>(archivoJsonUsuarios);

            if(listaUsuariosDeserializados != null) 
            listaUsuarios.AddRange(listaUsuariosDeserializados);

            return listaUsuarios;
        }

        public static List<Pasajeros> CargarPasajerosXml(string path)
        {
            List<Pasajeros>? listaPasajerosXml = new List<Pasajeros>();
            XmlSerializer? xmlSerializer = new XmlSerializer(typeof(ListaPasajerosXml));

            using (StreamReader streamReader = new StreamReader(path))
            {
                ListaPasajerosXml lista = (ListaPasajerosXml)xmlSerializer.Deserialize(streamReader);
                listaPasajerosXml = lista.Pasajeros;
            }

            return listaPasajerosXml;
        }

        public static List<Pasajeros> RetornarPasajerosPorVuelo(string? codigoVuelo)
        {
            List<Pasajeros> listaPasajerosBuscados;

            foreach(Vuelos vueloBuscado in listaVuelos) 
            {
                if(vueloBuscado.CodigoVuelo == codigoVuelo)
                {
                    listaPasajerosBuscados = vueloBuscado.ListaPasajeros;
                    break;
                }
            }

            return listaPasajeros;
        }

        public static void SerializarAvionesJson(List<Aviones> listaAvionesSerializar)
        {
            string jsonSting = JsonSerializer.Serialize(listaAvionesSerializar);
            File.WriteAllText("Aviones.json", jsonSting);
        }

        public static string RetornarDatosVuelo(Vuelos miVuelo)
        {
            int contadorAsientosPremium = 0;

            foreach (Pasajeros pasajero in listaPasajeros)
            {
                if (pasajero.AsientoPremium == true)
                    contadorAsientosPremium++;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CODIGO VUELO: {miVuelo.CodigoVuelo}");
            sb.AppendLine($"ORIGEN: {miVuelo.Origen.ToString()}");
            sb.AppendLine($"DESTINO: {miVuelo.Destino.ToString()}");
            sb.AppendLine($"FECHA: {miVuelo.FechaVuelo.ToString()}");
            sb.AppendLine($"ASIENTOS DISPONIBLES: {miVuelo.AsientosDisponibles.ToString()}");
            sb.AppendLine($"ASIENTOS PREMIUM DISPONIBLES: {miVuelo.AvionVuelo.CantidadAsientosPremium.ToString()}");
            sb.AppendLine($"ASIENTOS OCUPADO: {miVuelo.AsientosOcupados.ToString()}");
            sb.AppendLine($"MODELO AVION: {miVuelo.AvionVuelo.ModeloAvion}");
            sb.AppendLine($"MATRICULA AVION: {miVuelo.AvionVuelo.Matricula}");
            if (miVuelo.AvionVuelo.ServicioComida == false)
                sb.AppendLine($"SERVICIO COMIDA: NO");
            else
                sb.AppendLine($"SERVICIO COMIDA: SI");
            if (miVuelo.AvionVuelo.ServicioInternet == false)
                sb.AppendLine("SERVICIO INTERNET: NO");
            else
                sb.AppendLine("SERVICIO INTERNET: SI");
            sb.AppendLine($"CAPACIDAD BODEGA: {miVuelo.AvionVuelo.CapacidadBodega}Kg");
            sb.AppendLine($"CANTIDAD DE ASIENTOS PREMIUM USADOS: {contadorAsientosPremium.ToString()}");

            return sb.ToString();
        }

        public static void CrearVuelo(List<Pasajeros> listaPasajeros, List<Aviones> flotaAviones, DateTime fecha, string codigo, int horas, DestinosVuelos origen, DestinosVuelos destino, double precioVuelo)
        {
            foreach(Aviones miAvion in flotaAviones)
            {
                if (miAvion.CodigoVuelo == codigo)
                    listaVuelos.Add(new Vuelos(listaPasajeros, miAvion, fecha, codigo, origen, destino, horas, precioVuelo));
            }
        }

        public static void SerializarVuelosXml(List<Vuelos> listaVuelos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));

            using(StreamWriter streamWriter = new StreamWriter("vuelos.xml"))
            {
                serializer.Serialize(streamWriter, listaVuelos);
            }
        }

        public static void DeserializarVuelosXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));
            using(FileStream fileStream = new FileStream("vuelos.xml", FileMode.Open))
            {
                listaVuelos = (List<Vuelos>)serializer.Deserialize(fileStream);
            }
        }

        public static void SerializarPasajerosXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pasajeros>));
            using (FileStream fileStream = new FileStream("pasajeros.xml", FileMode.Open))
            {
                listaPasajeros = (List<Pasajeros>)serializer.Deserialize(fileStream);
            }
        }

        public static List<Vuelos> BuscarVuelo(string codigoVuelo)
        {
            List<Vuelos> vueloBuscado = new List<Vuelos>();

            foreach(Vuelos miVuelo in listaVuelos)
            {
                if(miVuelo.CodigoVuelo == codigoVuelo)
                    vueloBuscado.Add(miVuelo);
            }

            return vueloBuscado;
        }

        public static string BuscarUnPasajero(int dni)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Vuelos miVuelo in listaVuelos)
            {
                foreach(Pasajeros miPasajero in miVuelo.ListaPasajeros)
                {
                    if(miPasajero.Dni == dni)
                    {
                        sb.AppendLine($"NOMBRE: {miPasajero.Nombre}");
                        sb.AppendLine($"APELLIDO: {miPasajero.Apellido}");
                        sb.AppendLine($"EDAD: {miPasajero.Edad}");
                        sb.AppendLine($"DNI: {miPasajero.Dni.ToString()}");
                        sb.AppendLine($"GENERO: {miPasajero.Genero}");
                        sb.AppendLine($"PESO EQUIPAJE: {miPasajero.PesoEquipaje.ToString()}");
                        sb.AppendLine($"VUELO: {miVuelo.CodigoVuelo}");
                        sb.AppendLine($"ORIGEN: {miVuelo.Origen}");
                        sb.AppendLine($"DESTINO: {miVuelo.Destino}");
                        sb.AppendLine($"FECHA: {miVuelo.FechaVuelo.ToString()}");
                        sb.AppendLine($"AVION: {miVuelo.AvionVuelo.ModeloAvion}");
                    }
                }
            }

            return sb.ToString();
        }

        public static Vuelos BuscarUnVuelo(string codigoVuelo)
        {
            Vuelos vueloBuscado = new Vuelos();

            foreach(Vuelos miVuelo in listaVuelos)
            {
                if(miVuelo.CodigoVuelo == codigoVuelo)
                    vueloBuscado = miVuelo;
            }

            return vueloBuscado;
        }
    }
}
