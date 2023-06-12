using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Interfaces
{
    public interface IBaseDeDatos<T>
    {
        Task<bool> Agregar(T item, string coleccion);

        Task<List<T>> Traer();

        Task<bool> Actualizar();

        Task<bool> Eliminar();
    }
}
