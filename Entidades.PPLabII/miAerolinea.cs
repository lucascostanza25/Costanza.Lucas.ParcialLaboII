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
        public static List<Usuarios>? listaUsuarios = new List<Usuarios>();
        public static List<Vuelos>? listaVuelos = new List<Vuelos>();
        public static List<Pasajeros>? listaPasajeros = new List<Pasajeros>();
        public static List<Cliente>? listaClientes = new List<Cliente>();
        public static List<Aviones>? listaAviones = new List<Aviones>();

        public static Dictionary<int, DestinosVuelos[]> destinoPorVuelo = new Dictionary<int, DestinosVuelos[]>
        {
            {1, new DestinosVuelos[] {DestinosVuelos.Salta, DestinosVuelos.Santa_Rosa, DestinosVuelos.Bariloche, DestinosVuelos.Corrientes, DestinosVuelos.Cordoba, DestinosVuelos.Jujuy,
            DestinosVuelos.Mendoza, DestinosVuelos.Neuquen, DestinosVuelos.Posadas, DestinosVuelos.Iguazu, DestinosVuelos.Santiado_Del_Estero, DestinosVuelos.Trelew, DestinosVuelos.Tucuman,
            DestinosVuelos.Puerto_Madryn, DestinosVuelos.Ushuaia}},
            {2, new DestinosVuelos[] {DestinosVuelos.Buenos_aires, DestinosVuelos.Recife, DestinosVuelos.Roma, DestinosVuelos.Acapulco, DestinosVuelos.Miami} }
        };
        /// <summary>
        /// Metodo que deserializa la el archivo json  de usuarios
        /// </summary>
        /// <param name="archivo">nombre del archivo</param>
        public static void DeserializarUsuarios(string archivo)
        {
            string jsonString = File.ReadAllText(archivo);
            listaUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(jsonString);
        }
        /// <summary>
        /// Metodo que deserializa pasajeros de un archivo xml
        /// No utilizdo, ya que los pasajeros se encuentran dentro de vuelos.xml
        /// </summary>
        /// <param name="path">archivo</param>
        /// <returns>retorna la lista de pasajeros</returns>
        public static List<Pasajeros> CargarPasajerosXml(string path)
        {
            List<Pasajeros>? listaPasajerosXml = new List<Pasajeros>();
            XmlSerializer? xmlSerializer = new XmlSerializer(typeof(ListaPasajerosXml));

            using (StreamReader streamReader = new StreamReader(path))
            {
                ListaPasajerosXml lista = (ListaPasajerosXml)xmlSerializer.Deserialize(streamReader);
                listaPasajerosXml = lista.Pasajeros;
            }
            listaPasajeros.AddRange(listaPasajerosXml);
            return listaPasajerosXml;
        }
        /// <summary>
        /// Metodo que filtra a los pasajeros de un vuelo buscado
        /// </summary>
        /// <param name="codigoVuelo">codigo del vuelo</param>
        /// <returns>retorna la lista de pasajeros</returns>
        public static List<Pasajeros> RetornarPasajerosPorVuelo(string? codigoVuelo)
        {
            List<Pasajeros>? listaPasajerosBuscados;

            foreach (Vuelos vueloBuscado in listaVuelos)
            {
                if (vueloBuscado.CodigoVuelo == codigoVuelo)
                {
                    listaPasajerosBuscados = vueloBuscado.ListaPasajeros;
                }
            }

            return listaPasajeros;
        }
        /// <summary>
        /// Metodo que retorna a un pasajero
        /// </summary>
        /// <param name="dni">dni del pasajero</param>
        /// <returns>retorna a el pasajero buscado</returns>
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
        /// <summary>
        /// Metodo que serializa la lista de los aviones
        /// </summary>
        /// <param name="listaAvionesSerializar">lista de aviones a serializar</param>
        public static void SerializarAvionesJson(List<Aviones> listaAvionesSerializar)
        {
            string jsonSting = JsonSerializer.Serialize(listaAvionesSerializar);
            File.WriteAllText("aviones.json", jsonSting);
        }
        /// <summary>
        /// Metodo que deserializa la lista de aviones
        /// </summary>
        /// <param name="archivo"></param>
        public static void DeserializarAvionesJson(string archivo)
        {
            List<Aviones>? listaAviones = new List<Aviones>();

            string jsonString = File.ReadAllText(archivo);
            listaAviones = JsonSerializer.Deserialize<List<Aviones>>(jsonString);
            MiAerolinea.listaAviones = listaAviones;
        }
        /// <summary>
        /// Metodo que retorna los datos de un vuelo
        /// </summary>
        /// <param name="miVuelo">vuelo a retornar los datos</param>
        /// <returns>retorna un stringbuilder con todos los datos</returns>
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
        /// <summary>
        /// Metodo que retorna los datos de un avion
        /// </summary>
        /// <param name="avion">avion a sacar los datos</param>
        /// <returns>retorna un stringbuilder con los datos</returns>
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
        /// <summary>
        /// Metodo que serializa los vuelos en archivo xml
        /// </summary>
        /// <param name="listaVuelos">lista de los vuelos</param>
        public static void SerializarVuelosXml(List<Vuelos> listaVuelos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));

            using (StreamWriter streamWriter = new StreamWriter("vuelos.xml"))
            {
                serializer.Serialize(streamWriter, listaVuelos);
            }
        }
        /// <summary>
        /// Metodo que deserializa los vuelos en archivo xml
        /// </summary>
        public static void DeserializarVuelosXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vuelos>));

            using (FileStream fileStream = new FileStream("vuelos.xml", FileMode.Open))
            {
                listaVuelos = (List<Vuelos>)serializer.Deserialize(fileStream);
            }
        }
        /// <summary>
        /// Metodo que serializa los pasajeros xml,
        /// no utilizado ya que los pasajeros se encuentran en la lista de vuelos
        /// </summary>
        public static void SerializarPasajerosXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pasajeros>));
            using (FileStream fileStream = new FileStream("pasajeros.xml", FileMode.Open))
            {
                listaPasajeros = (List<Pasajeros>)serializer.Deserialize(fileStream);
            }
        }
        /// <summary>
        /// Metodo que busca un vuelo
        /// </summary>
        /// <param name="codigoVuelo"></param>
        /// <returns>retorna una lista del vuelo buscado</returns>
        public static List<Vuelos> BuscarVuelo(string codigoVuelo)
        {
            List<Vuelos> vueloBuscado = new List<Vuelos>();

            foreach (Vuelos miVuelo in listaVuelos)
            {
                if (miVuelo.CodigoVuelo == codigoVuelo)
                    vueloBuscado.Add(miVuelo);
            }

            return vueloBuscado;
        }
        /// <summary>
        /// Metodo que busca a un pasajero
        /// </summary>
        /// <param name="dni">dni de pasajero</param>
        /// <returns>retorna un stringbuilder con los datos del pasajero y de su vuelo</returns>
        public static string BuscarUnPasajero(int dni)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vuelos miVuelo in listaVuelos)
            {
                foreach (Pasajeros miPasajero in miVuelo.ListaPasajeros)
                {
                    if (miPasajero.Dni == dni)
                    {
                        sb.Append(miPasajero.ToString());
                        sb.AppendLine("----------------------");
                        sb.AppendLine(miVuelo.ToString());
                    }
                }
            }

            return sb.ToString();
        }
        /// <summary>
        /// Metodo que busca un vuelo
        /// </summary>
        /// <param name="codigoVuelo">codigo del vuelo buscado</param>
        /// <returns>retorna un vuelo</returns>
        public static Vuelos BuscarUnVuelo(string? codigoVuelo)
        {
            Vuelos vueloBuscado = new Vuelos();

            foreach (Vuelos miVuelo in listaVuelos)
            {
                if (miVuelo.CodigoVuelo == codigoVuelo)
                    vueloBuscado = miVuelo;
            }

            return vueloBuscado;
        }
        /// <summary>
        /// Metodoque filtra vuelos
        /// </summary>
        /// <param name="origen">origen del vuelo</param>
        /// <param name="destino">destino del vuelo</param>
        /// <param name="fecha">fecha del vuelo</param>
        /// <param name="servicio">servicios del vuelo</param>
        /// <returns>retorna una lista de los vuelos filtrado</returns>
        /// <exception cref="Exception">lanza una excepcion si no se encontraron vuelo para filtrar</exception>
        public static List<Vuelos> FiltrarVuelos(DestinosVuelos origen, DestinosVuelos destino, DateTime fecha, int servicio)
        {
            List<Vuelos> listaFiltrada = new List<Vuelos>();

            foreach (Vuelos vuelo in listaVuelos)
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
                            if (vuelo.AvionVuelo.ServicioInternet)
                                listaFiltrada.Add(vuelo);
                            break;
                    }
                }
            }

            if (listaFiltrada.Count == 0)
                throw new Exception("No se encontraron vuelos con las caracteristicas buscadas");
            return listaFiltrada;
        }
        /// <summary>
        /// Metodo que vende un vuelo y lo agrega a la lista de los pasajeros del vuelo
        /// </summary>
        /// <param name="vuelo">vuelo a vender</param>
        /// <param name="miCliente">cliente a vender el vuelo</param>
        /// <returns>retorna true si lo pudo vender, false si no</returns>
        /// <exception cref="Exception">lanza una excepcion si el cliente no tiene dinero suficiente</exception>
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
                    //vuelo.ListaPasajeros.Add(new Pasajeros(miCliente.Apellido, miCliente.Nombre, miCliente.Dni, miCliente.Edad, miCliente.Genero, miCliente.AsientoPremium, miCliente.CantidadEquipaje, miCliente.PesoEquipajeUno, miCliente.PesoEquipajeDos));
                    listaClientes.Remove(miCliente);
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
        /// <summary>
        /// Metodo que despacha el equipaje de todos los pasajeros
        /// </summary>
        public static void DespacharEquipajeDePasajerosHechos(List<Pasajeros> lista)
        {
            Random equipaje = new Random();
            double pesoTotal = 0;
            foreach (Pasajeros miPasajero in lista)
            {
                if (miPasajero.AsientoPremium)
                {
                    miPasajero.PesoEquipajeUno = equipaje.Next(0, 21);
                    miPasajero.PesoEquipajeDos = equipaje.Next(0, 21);
                    miPasajero.CantidadEquipaje = 2;
                    pesoTotal += miPasajero.PesoEquipajeUno + miPasajero.PesoEquipajeDos;
                    //miVuelo.CapacidadDisponibleBodega = miVuelo.AvionVuelo.CapacidadBodega - pesoTotal;
                }
                else
                {
                    miPasajero.PesoEquipajeUno = equipaje.Next(0, 25);
                    miPasajero.CantidadEquipaje = 1;
                    pesoTotal += miPasajero.PesoEquipajeUno;
                    //miVuelo.CapacidadDisponibleBodega = miVuelo.AvionVuelo.CapacidadBodega - pesoTotal;
                }
            }

        }
        /// <summary>
        /// Metodo que genera las estadisticas del vuelo con mas pasajeros
        /// </summary>
        /// <returns>retorna un string con los datos del vuelo</returns>
        public static string EstadisticaVueloMasPasajeros()
        {
            Vuelos vueloMasPasajeros = new Vuelos();
            StringBuilder sb = new StringBuilder();
            int maxPasajeros = 0;
            int cantidadPasajeros = 0;
            foreach (Vuelos vuelo in listaVuelos)
            {
                cantidadPasajeros = vuelo.ListaPasajeros.Count;
                if (cantidadPasajeros > maxPasajeros)
                {
                    maxPasajeros = cantidadPasajeros;
                    vueloMasPasajeros = vuelo;
                }
            }

            sb.AppendLine($"Vuelo con mas pasajeros es: {vueloMasPasajeros.CodigoVuelo} - con {vueloMasPasajeros.ListaPasajeros.Count()} pasajeros");
            sb.AppendLine($"Destino: {vueloMasPasajeros.Destino} - Origen {vueloMasPasajeros.Origen}");

            return sb.ToString();
        }
        /// <summary>
        /// Metodo que genera las estadisticas de la recaudacion total de todos los vuelos
        /// </summary>
        /// <returns>retorna un string con los datos</returns>
        public static string EstadisticaRecaudacionTotalVuelos()
        {
            StringBuilder sb = new StringBuilder();
            double recaudacionTotal = 0;

            foreach (Vuelos vuelo in listaVuelos)
            {
                recaudacionTotal += vuelo.CantidadDineroRecuadado;
            }

            sb.AppendLine($"La recaudación total fue de {recaudacionTotal.ToString()}USD");

            return sb.ToString();
        }
        /// <summary>
        /// Meotodo que genera las estadisticas del vuelo que mas recaudo
        /// </summary>
        /// <returns>retorna un string con los datos</returns>
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
        /// <summary>
        /// Metodo que genera las estadisticas de la recaudación total de todos los vuelo
        /// </summary>
        /// <returns>retorna un string con todos los datos</returns>
        public static string EstadisticaRecaudacionTodosLosVuelo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vuelos vuelo in listaVuelos)
            {
                sb.AppendLine($"Vuelo: {vuelo.CodigoVuelo} - Recaudación: {vuelo.CantidadDineroRecuadado}");
            }

            return sb.ToString();
        }
        /// <summary>
        /// Metodo que elimina un pasajero
        /// </summary>
        /// <param name="dni">sni del pasajero</param>
        /// <returns>retorna true si lo pudo eliminar, false si no</returns>
        public static bool EliminarPasajero(int dni)
        {
            foreach (Vuelos vuelo in listaVuelos)
            {
                foreach (Pasajeros pasajero in vuelo.ListaPasajeros)
                {
                    if (pasajero.Dni == dni)
                    {
                        vuelo.ListaPasajeros.Remove(pasajero);
                        vuelo.ActualizarDatosVuelo(vuelo.ListaPasajeros);
                        return true;
                    }
                }
            }

            return false;
        }
        /// <summary>
        /// Metodo que busca un avion en el sistema
        /// </summary>
        /// <param name="matricula">matricula del avion</param>
        /// <returns>retorna el avion buscado</returns>
        public static Aviones BuscarUnAvion(string? matricula)
        {
            Aviones avionBuscado = new Aviones();

            foreach (Aviones avion in listaAviones)
            {
                if (avion.Matricula == matricula)
                {
                    avionBuscado = avion;
                    break;
                }
            }

            return avionBuscado;
        }


    }
}
