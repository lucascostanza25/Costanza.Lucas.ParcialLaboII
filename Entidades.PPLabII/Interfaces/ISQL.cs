using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Interfaces
{
    public interface ISQL<T>
    {
        List<T> Leer(string query, Func<IDataRecord, T> datosObjeto);

        void Guardar(string query, T objeto, Action<SqlCommand> datosObjeto);

        void Eliminar(string query, Action<SqlCommand> datosObjeto);

        void Editar(string query, Action<SqlCommand> datosObjeto);
    }
}
