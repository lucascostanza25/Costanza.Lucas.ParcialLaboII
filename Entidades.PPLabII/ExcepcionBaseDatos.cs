using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class ExcepcionBaseDatos : Exception
    {
        public ExcepcionBaseDatos()
        {

        }

        public ExcepcionBaseDatos(string mensaje) : base(mensaje)
        {
            mensaje = "No se pudo conectar a la base de datos";
        }

        public ExcepcionBaseDatos(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}
