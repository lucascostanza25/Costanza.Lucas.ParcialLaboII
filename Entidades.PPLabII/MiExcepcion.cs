using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
        {
               
        }

        public MiExcepcion(string mensaje) : base(mensaje)
        {

        }

        public MiExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }

        public void GuardarMiExcepcion()
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine($"{DateTime.Now} - Mensaje de excepción: " + this.Message);
                writer.WriteLine($"{DateTime.Now} - Excepción interna: " + this.InnerException?.Message);
                writer.WriteLine($"{DateTime.Now} - Stack trace: " + this.StackTrace);
            }
        }
    }
}
