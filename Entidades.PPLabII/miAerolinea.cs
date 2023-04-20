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
        private static string archivoJsonUsuarios = File.ReadAllText(@"D:\Programacion\C#\UTN\Parciales\Costanza.Lucas.PPLabII\Costanza.Lucas.PPLabII\MOCK_DATA.json");

        public static List<Usuarios> CargarUsuariosJson()
        {
            List<Usuarios>? listaUsuariosDeserializados = JsonSerializer.Deserialize<List<Usuarios>>(archivoJsonUsuarios);

            listaUsuarios.AddRange(listaUsuariosDeserializados);

            return listaUsuarios;
        }
    }
}
