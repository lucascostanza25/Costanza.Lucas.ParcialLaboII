using Entidades.PPLabII.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Serializadora<T>  : JSON<T>
    {
        public bool Serializar(T objeto, string path)
        {
            bool estado = false;  

            using(StreamWriter writer = new StreamWriter(path))
            {
                string json = JsonSerializer.Serialize(objeto);
                writer.WriteLine(json);
                estado = true;
            }

            return estado;
        }

        public T Deserializar<T>(string path)
        {
            T objeto = default(T);

            JsonSerializerOptions opciones = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };
            string json = File.ReadAllText(path);
            objeto = JsonSerializer.Deserialize<T>(json);
            return objeto;
        }
    }
}
