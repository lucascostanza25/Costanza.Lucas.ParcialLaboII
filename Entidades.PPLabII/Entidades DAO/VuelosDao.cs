using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Entidades_DAO
{
    public class VuelosDao
    {
        public static SqlCommand comando;
        public static SqlConnection conexion;

        static VuelosDao()
        {
            conexion = new SqlConnection(@"Data Source = .;
                                Database = AEROLINEA;
                                Trusted_Connection = True;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Vuelos> LeerVuelos()
        {
            List<Vuelos> listaVuelos = new List<Vuelos>();
            List<Pasajeros> listaPasajerosVuelos = new List<Pasajeros>();
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM vuelos";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajerosVuelos = MiAerolinea.listaPasajeros.Where(Pasajeros => Pasajeros.CodigoVuelo == reader["codigo"].ToString()).ToList();
                        Aviones avion = BuscarAvion(reader["matricula_avion"].ToString());
                        string origen = reader["origen"].ToString();
                        string destino = reader["destino"].ToString();
                        DestinosVuelos enumOrigen = (DestinosVuelos)Enum.Parse(typeof(DestinosVuelos), origen);
                        DestinosVuelos enumDestino = (DestinosVuelos)Enum.Parse(typeof(DestinosVuelos), destino);

                        listaVuelos.Add(new Vuelos(
                            Convert.ToDateTime(reader["fecha"]),
                            reader["codigo"].ToString(),
                            enumOrigen,
                            enumDestino,
                            Convert.ToInt32(reader["horas"]),
                            Convert.ToDouble(reader["precio"]),
                            reader["matricula_avion"].ToString(),
                            listaPasajerosVuelos,
                            avion
                            ));
                    }
                }
            }
            finally
            {
                conexion.Close();
            }

            return listaVuelos;
        }

        public static Aviones BuscarAvion(string matricula)
        {
            Aviones avionBuscado = new Aviones();
            foreach (Aviones avion in MiAerolinea.listaAviones)
            {
                if (avion.Matricula == matricula)
                {
                    avionBuscado = avion;
                }
            }
            return avionBuscado;
        }
    }
}
