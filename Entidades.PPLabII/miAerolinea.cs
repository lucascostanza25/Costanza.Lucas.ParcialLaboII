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
        public static List<VuelosNacionales> listaVuelosNacionales = new List<VuelosNacionales>();
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

            foreach(VuelosNacionales vueloBuscado in listaVuelosNacionales) 
            {
                if(vueloBuscado.CodigoVuelo == codigoVuelo)
                {
                    listaPasajerosBuscados = vueloBuscado.ListaPasajeros;
                    break;
                }
            }

            return listaPasajeros;
        }

        public static Pasajeros RetornarUnPasajero(int dni)
        {
            Pasajeros pasajeroBuscado = new Pasajeros();

            foreach(Pasajeros miPasajero in listaPasajeros)
            {
                if(miPasajero.Dni == dni)
                {
                    pasajeroBuscado = miPasajero;
                    break;
                }
            }

            return pasajeroBuscado;
        }

        public static void SerializarAvionesJson(List<Aviones> listaAvionesSerializar)
        {
            string jsonSting = JsonSerializer.Serialize(listaAvionesSerializar);
            File.WriteAllText("Aviones.json", jsonSting);
        }

        public static string RetornarDatosVuelo(VuelosNacionales miVuelo)
        {
            int contadorAsientosPremium = 0;

            foreach(Pasajeros pasajero in listaPasajeros)
            {
                if (pasajero.AsientoPremium == true)
                    contadorAsientosPremium++;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CODIGO VUELO: {miVuelo.CodigoVuelo}");
            sb.AppendLine($"ORIGEN: {miVuelo.OrigenVuelo.ToString()}");
            sb.AppendLine($"DESTINO: {miVuelo.DestinoVuelo.ToString()}");
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

        public static void CrearVueloNacional(List<Pasajeros> listaPasajeros, List<Aviones> aviones, DateTime fecha, string codigo, int horas, DestinosNacionalesVuelos origen, DestinosNacionalesVuelos destino)
        {
            foreach(Aviones miAvion in aviones)
            {
                if (miAvion.CodigoVuelo == codigo)
                    listaVuelosNacionales.Add(new VuelosNacionales(listaPasajeros, miAvion, fecha, codigo, horas, origen, destino));

                SerializarVuelosXml(listaVuelosNacionales);
            }
        }

        public static void SerializarVuelosXml(List<VuelosNacionales> listaVuelos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<VuelosNacionales>));

            using(StreamWriter streamWriter = new StreamWriter("vuelos.xml"))
            {
                serializer.Serialize(streamWriter, listaVuelos);
            }
        }
    }
}
