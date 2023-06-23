using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
   public class GuardadorExcepciones
   {
        private string logPath;

		public GuardadorExcepciones(string path)
		{
			this.logPath = path;
		}

		public void GuardarExcepcion(Exception ex)
		{
			using(StreamWriter writer = new StreamWriter(logPath, true))
			{
                writer.WriteLine("Mensaje de excepción: " + ex.Message);
                writer.WriteLine("Excepción interna: " + ex.InnerException?.Message);
                writer.WriteLine("Stack trace: " + ex.StackTrace);
                writer.WriteLine("----------------------------------------");
            }
		}
   }
}
