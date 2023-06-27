using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Interfaces
{
    public interface IFirebase<T>
    {
        Task<bool> Agregar(T objeto, string coleccion, string documento);

        Task<List<T>> Traer(string dato);

        Task<bool> Actualizar(T objeto, string coleccion, string documento);

        Task<bool> Eliminar(string coleccion, string documento);
    }
}
