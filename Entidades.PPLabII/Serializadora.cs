using Entidades.PPLabII.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Serializadora<T>  : JSON<T>
    {
        public bool Serializar(T objeto, string path)
        {
            return true;
        }

        public T Deserializar(string path)
        {
            T objeto = default(T);
            return objeto;
        }
    }
}
