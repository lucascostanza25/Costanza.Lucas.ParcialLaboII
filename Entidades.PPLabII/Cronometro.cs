using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Cronometro
    {
        private TimeSpan tiempoRestante;
        private Thread hilo;
        private bool corriendo;

        public delegate void CronometroActualizadoEvent(TimeSpan tiempo);

        public event CronometroActualizadoEvent CronometroActualizado;

        public Cronometro(TimeSpan tiempoInicial)
        {
            tiempoRestante = tiempoInicial;
            corriendo = false;
        }

        public void Iniciar()
        {
            if(!corriendo)
            {
                corriendo = true;
                hilo = new Thread(ActualizarCronometro);
                hilo.Start();
            }
        }

        private void ActualizarCronometro()
        {
            while(tiempoRestante > TimeSpan.Zero)
            {
                tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromSeconds(1));
                CronometroActualizado.Invoke(tiempoRestante);
                Thread.Sleep(1000);
            }
        }

        public TimeSpan TiempoRestante
        {
            get { return tiempoRestante; }
            set
            {
                tiempoRestante = value;
                OnCronometroActualizado(); // Llama al método que dispara el evento
            }
        }

        protected virtual void OnCronometroActualizado()
        {
            CronometroActualizado?.Invoke(tiempoRestante);
        }
    }
}
