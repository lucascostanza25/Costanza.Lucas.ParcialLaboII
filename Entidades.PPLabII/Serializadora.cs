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
        /// <summary>
        /// Metodo que serializa un objeto en json
        /// </summary>
        /// <param name="objeto">Objeto</param>
        /// <param name="path">Path del archivo</param>
        /// <returns>Retorna true o false</returns>
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

        /// <summary>
        /// Metodo que deserializa un archivo json
        /// </summary>
        /// <typeparam name="T">Objeto</typeparam>
        /// <param name="path">Path del archivo</param>
        /// <returns>Retorna el objeto</returns>
        public T Deserializar<T>(string path)
        {
            T objeto = default(T);
            string json = File.ReadAllText(path);
            objeto = JsonSerializer.Deserialize<T>(json);
            return objeto;
        }
    }
}
