using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public abstract class miAerolinea
    {
        public static List<Usuarios> listaUsuarios = new List<Usuarios>();
        private static string archivoJsonUsuarios = File.ReadAllText(@"D:\Programacion\C#\UTN\Parciales\Costanza.Lucas.PPLabII\MOCK_DATA.json");
        public static List<Vuelos> listaVuelos = new List<Vuelos>();

        public static List<Usuarios> CargarUsuariosJson()
        {
            List<Usuarios>? listaUsuariosDeserializados = JsonSerializer.Deserialize<List<Usuarios>>(archivoJsonUsuarios);

            if(listaUsuariosDeserializados != null) 
            listaUsuarios.AddRange(listaUsuariosDeserializados);

            return listaUsuarios;
        }

        public static void CrearVueloNacional(DestinosNacionalesVuelos origen,  DestinosNacionalesVuelos destino,
            DateTime fecha, double precio, List<Pasajeros> listaPasajeros, Aviones avionVuelo, string codigo)
        {
            listaVuelos.Add(new Vuelos(origen, destino, fecha, precio, listaPasajeros, avionVuelo, codigo));
        }

        public static List<Vuelos> RetornarListaVuelos()
        {
            return listaVuelos;
        }


    }
}
