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
    public abstract class MiAerolinea
    {
        public static List<Usuarios> listaUsuarios;
        public static List<Vuelos> listaVuelos;
        public static List<Pasajeros> listaPasajeros = new List<Pasajeros>();
        public static List<Cliente> listaClientes;
        public static List<Aviones> listaAviones = new List<Aviones>();
        private static string archivoJsonUsuarios = File.ReadAllText(@"D:\Programacion\C#\UTN\Parciales\Costanza.Lucas.PPLabII\MOCK_DATA.json");

        static MiAerolinea()
        {
            listaUsuarios = new List<Usuarios>();
            listaVuelos = new List<Vuelos>();
            listaPasajeros = new List<Pasajeros>();
            listaClientes = new List<Cliente>();
        }

        public static Dictionary<int, DestinosVuelos[]> destinoPorVuelo = new Dictionary<int, DestinosVuelos[]>
        {
            {1, new DestinosVuelos[] {DestinosVuelos.Salta, DestinosVuelos.Santa_Rosa, DestinosVuelos.Bariloche, DestinosVuelos.Corrientes, DestinosVuelos.Cordoba, DestinosVuelos.Jujuy,
            DestinosVuelos.Mendoza, DestinosVuelos.Neuquen, DestinosVuelos.Posadas, DestinosVuelos.Iguazu, DestinosVuelos.Santiado_Del_Estero, DestinosVuelos.Trelew, DestinosVuelos.Tucuman,
            DestinosVuelos.Puerto_Madryn, DestinosVuelos.Ushuaia}},
            {2, new DestinosVuelos[] {DestinosVuelos.Buenos_aires, DestinosVuelos.Recife, DestinosVuelos.Roma, DestinosVuelos.Acapulco, DestinosVuelos.Miami} }
        };


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
                    //break;
                }
            }

            return listaPasajeros;
        }

        public static Pasajeros RetornarUnPasajero(int dni)
        {
            Pasajeros pasajeroBuscado = new Pasajeros();

            foreach (Vuelos miVuelo in listaVuelos)
            {
                foreach (Pasajeros miPasajero in miVuelo.ListaPasajeros)
                {
                    if (miPasajero.Dni == dni)
                    {
                        pasajeroBuscado = miPasajero;
                        break;
                    }
                }
            }

            return pasajeroBuscado;
        }

        public static void SerializarAvionesJson(List<Aviones> listaAvionesSerializar)
        {
            string jsonSting = JsonSerializer.Serialize(listaAvionesSerializar);
            File.WriteAllText("aviones.json", jsonSting);
        }

        public static void DeserializarAvionesJson(string archivo)
        {
            List<Aviones> listaAviones = new List<Aviones>();

            string jsonString = File.ReadAllText(archivo);
            listaAviones = JsonSerializer.Deserialize<List<Aviones>>(jsonString);
            MiAerolinea.listaAviones = listaAviones;
        }

        public static string RetornarDatosVuelo(Vuelos miVuelo)
        {
            int contadorAsientosPremium = 0;

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
            sb.AppendLine($"CAPACIDAD DISPONIBLE BODEGA: {miVuelo.CapacidadDisponibleBodega}Kg");
            sb.AppendLine($"CANTIDAD DE ASIENTOS PREMIUM USADOS: {contadorAsientosPremium.ToString()}");

            return sb.ToString();
        }

        public static string RetornarDatosAvion(Aviones avion)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"MATRICULA: {avion.Matricula}");
            sb.AppendLine($"MARCA Y MODELO: {avion.ModeloAvion}");
            sb.AppendLine($"CANTIDAD ASIENTOS: {avion.CantidadAsientos}");
            sb.AppendLine($"CANTIDAD ASIENTOS PREMIUM: {avion.CantidadAsientosPremium}");
            sb.AppendLine($"CAPACIDAD BODEGA: {avion.CapacidadBodega}");
            sb.AppendLine($"SERVICIO INTERNET: {avion.ServicioInternet}");
            sb.AppendLine($"SERVICIO COMIDA: {avion.ServicioComida}");

            return sb.ToString();
        }

        public static void CrearVuelo(List<Pasajeros> listaPasajeros, List<Aviones> flotaAviones, DateTime fecha, string codigo, int horas, DestinosVuelos origen, DestinosVuelos destino, double precioVuelo, string matricula)
        {
            foreach(Aviones miAvion in flotaAviones)
            {
                if (miAvion.Matricula == matricula)
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
                        sb.AppendLine($"CANTIDAD DE EQUIPAJE: {miPasajero.CantidadEquipaje}");
                        sb.AppendLine($"- Peso primer equipaje: {miPasajero.PesoEquipajeUno}");
                        if (miPasajero.AsientoPremium)
                        {
                            sb.AppendLine($"- Peso segundo equipaje: {miPasajero.PesoEquipajeDos}");
                        }
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
        
        public static List<Vuelos> FiltrarVuelos(DestinosVuelos origen, DestinosVuelos destino, DateTime fecha, int servicio)
        {
            List<Vuelos> listaFiltrada = new List<Vuelos>();

            foreach(Vuelos vuelo in listaVuelos)
            {
                if (vuelo.Origen == origen && vuelo.Destino == destino && vuelo.FechaVuelo.Date == fecha.Date)
                {
                    switch (servicio)
                    {
                        case 0:
                            if (!vuelo.AvionVuelo.ServicioComida && !vuelo.AvionVuelo.ServicioInternet)
                                listaFiltrada.Add(vuelo);
                            break;
                        case 1:
                            if (vuelo.AvionVuelo.ServicioComida && vuelo.AvionVuelo.ServicioInternet)
                                listaFiltrada.Add(vuelo);
                            break;
                        case 2:
                            if (vuelo.AvionVuelo.ServicioComida)
                                listaFiltrada.Add(vuelo);
                            break;
                        case 3:
                            if(vuelo.AvionVuelo.ServicioInternet)
                                listaFiltrada.Add(vuelo);
                            break;
                    }
                }
            }

            if (listaFiltrada.Count == 0)
                throw new Exception("No se encontraron vuelos con las caracteristicas buscadas");
            return listaFiltrada;
        }

        public static bool VenderVuelo(Vuelos vuelo, Cliente miCliente)
        {
            bool estadoVenta = false;
            double precioDelPasaje;
            if (miCliente.AsientoPremium)
            {
                precioDelPasaje = vuelo.CalcularPrecioVuelo(true);
            }
            else
            {
                precioDelPasaje = vuelo.CalcularPrecioVuelo(false);
            }
            if (vuelo.CapacidadDisponibleBodega > miCliente.PesoEquipajeUno + miCliente.PesoEquipajeDos)
            {
                if (miCliente.DineroDisponible >= precioDelPasaje)
                {
                    miCliente.DineroDisponible = miCliente.DineroDisponible - precioDelPasaje;
                    vuelo.CantidadDineroRecuadado += precioDelPasaje;
                    vuelo.ListaPasajeros.Add(new Pasajeros(miCliente.Apellido, miCliente.Nombre, miCliente.Dni, miCliente.Edad, miCliente.Genero, miCliente.AsientoPremium, miCliente.CantidadEquipaje, miCliente.PesoEquipajeUno, miCliente.PesoEquipajeDos));
                    MiAerolinea.listaClientes.Remove(miCliente);
                    vuelo.AsientosOcupados++;
                    vuelo.AsientosDisponibles--;
                    vuelo.CapacidadDisponibleBodega = vuelo.AvionVuelo.CapacidadBodega - (miCliente.PesoEquipajeUno + miCliente.PesoEquipajeDos);
                    estadoVenta = true;
                }
                else
                {
                    throw new Exception("El cliente no tiene dinero suficiente");
                }
            }

            return estadoVenta;
        }

        public static void DespacharEquipajeDePasajerosHechos()
        {
            Random equipaje = new Random();
            double pesoTotal = 0;
            foreach(Vuelos miVuelo in listaVuelos)
            {
                foreach(Pasajeros miPasajero in miVuelo.ListaPasajeros)
                {
                    if(miPasajero.AsientoPremium)
                    {
                        miPasajero.CantidadEquipaje = 2;
                        miPasajero.PesoEquipajeUno = equipaje.Next(1, 21);
                        miPasajero.PesoEquipajeDos = equipaje.Next(1, 21);
                        pesoTotal += miPasajero.PesoEquipajeUno + miPasajero.PesoEquipajeDos;
                        miVuelo.CapacidadDisponibleBodega = miVuelo.AvionVuelo.CapacidadBodega - pesoTotal;
                    }
                    else
                    {
                        miPasajero.CantidadEquipaje = 1;
                        miPasajero.PesoEquipajeUno = equipaje.Next(1, 25);
                        pesoTotal += miPasajero.PesoEquipajeUno;
                        miVuelo.CapacidadDisponibleBodega = miVuelo.AvionVuelo.CapacidadBodega - pesoTotal;
                    }
                }
            }
        }

        public static string EstadisticaVueloMasPasajeros()
        {
            Vuelos vueloMasPasajeros = new Vuelos();
            StringBuilder sb = new StringBuilder();
            int maxPasajeros = 0;
            int cantidadPasajeros = 0;
            foreach(Vuelos vuelo in listaVuelos)
            {
                cantidadPasajeros = vuelo.ListaPasajeros.Count;
                if(cantidadPasajeros > maxPasajeros)
                {
                    maxPasajeros = cantidadPasajeros;
                    vueloMasPasajeros = vuelo;
                }
            }

            sb.AppendLine($"Vuelo con mas pasajeros es: {vueloMasPasajeros.CodigoVuelo} - con {vueloMasPasajeros.ListaPasajeros.Count()} pasajeros");
            sb.AppendLine($"Destino: {vueloMasPasajeros.Destino} - Origen {vueloMasPasajeros.Origen}");

            return sb.ToString();
        }

        public static string EstadisticaRecaudacionTotalVuelos()
        {
            StringBuilder sb = new StringBuilder();
            double recaudacionTotal = 0;

            foreach(Vuelos vuelo in listaVuelos)
            {
                recaudacionTotal += vuelo.CantidadDineroRecuadado;
            }

            sb.AppendLine($"La recaudación total fue de {recaudacionTotal.ToString()}USD");

            return sb.ToString();
        }

        public static string EstadisticaVueloMasRecaudo()
        {
            Vuelos vueloMasRecaudado = new Vuelos();
            StringBuilder sb = new StringBuilder();
            double maxRecaudacion = 0;
            double recaudacion = 0;
            foreach (Vuelos vuelo in listaVuelos)
            {
                recaudacion = vuelo.CantidadDineroRecuadado;
                if (recaudacion > maxRecaudacion)
                {
                    maxRecaudacion = recaudacion;
                    vueloMasRecaudado = vuelo;
                }
            }

            sb.AppendLine($"El vuelo que mas recaudó fue {vueloMasRecaudado.CodigoVuelo}, con una recaudación de {vueloMasRecaudado.CantidadDineroRecuadado.ToString()}");

            return sb.ToString();
        }

        public static string EstadisticaRecaudacionTodosLosVuelo()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Vuelos vuelo in listaVuelos)
            {
                sb.AppendLine($"Vuelo: {vuelo.CodigoVuelo} - Recaudación: {vuelo.CantidadDineroRecuadado}");
            }

            return sb.ToString();
        }

        public static bool EliminarPasajero(int dni)
        {
            foreach(Vuelos vuelo in listaVuelos)
            {
                foreach(Pasajeros pasajero in vuelo.ListaPasajeros)
                {
                    if(pasajero.Dni == dni)
                    {
                        vuelo.ListaPasajeros.Remove(pasajero);
                        vuelo.ActualizarDatosVuelo(vuelo.ListaPasajeros);
                        return true;
                    }
                }
            }

            return false;
        }

        public static Aviones BuscarUnAvion(string? matricula)
        {
            Aviones avionBuscado = new Aviones();

            foreach(Aviones avion in listaAviones)
            {
                if(avion.Matricula == matricula)
                {
                    avionBuscado = avion;
                    break;
                }
            }

            return avionBuscado;
        }
    }
}
