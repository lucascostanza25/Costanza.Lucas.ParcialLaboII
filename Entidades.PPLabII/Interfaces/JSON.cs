using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Interfaces
{
    public interface JSON<T>
    {
        bool Serializar(T objeto, string path);

        T Deserializar(string path);
    }
}
