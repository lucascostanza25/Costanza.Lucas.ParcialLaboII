using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class GeneradorClientes
    {
        private static readonly Random random = new Random();
        private static readonly List<string> nombres = new List<string>
        {
            "Lucas", "Eliana", "Federico", "Carla", "Juan", "Carmen", "Carlos", "Enrique"
        };
        private static readonly List<string> apellidos = new List<string>
        {
            "Costanza", "Gonzalez", "Gutierrez", "Tronador", "Clauss", "Di Lorenzo", "Galperin"
        };
        private static readonly List<string> generos = new List<string>
        {
            "Male", "Female"
        };

        public static async Task GenerarClientes()
        {
            List<Task> listaTask = new List<Task>();

            for(int i = 0; i<3; i++)
            {
                Task task = Task.Run(() => 
                {
                    Cliente clienteNuevo = GenerarClienteNuevo();
                    MiAerolinea.listaClientes.Add(clienteNuevo);
                });

                listaTask.Add(task);
            }

            await Task.WhenAll(listaTask);
        }

        private static Cliente GenerarClienteNuevo()
        {
            int esPremium = random.Next(0, 1);
            int edad = random.Next(10, 80);
            double dinero = random.Next(1000, 6000);
            int dni = random.Next(10000000, 50000000);
            int cantidadEquipaje = 0;
            double pesoUno = 0;
            double pesoDos = 0;
            string nombre = nombres[random.Next(nombres.Count)];
            string apellido = apellidos[random.Next(apellidos.Count)];
            string genero = generos[random.Next(generos.Count)];
            if(esPremium == 0)
            {
                cantidadEquipaje = 1;
                pesoUno = random.Next(1, 23);
            }
            else if(esPremium == 1)
            {
                cantidadEquipaje = random.Next(1, 2);
                pesoUno = random.Next(1, 21);
                if(cantidadEquipaje == 2)
                {
                    pesoDos = random.Next(1, 21);
                }
            }

            return new Cliente(apellido, nombre, dinero, dni, edad, Convert.ToBoolean(esPremium), genero, cantidadEquipaje, pesoUno, pesoDos);
        }
    }
}
