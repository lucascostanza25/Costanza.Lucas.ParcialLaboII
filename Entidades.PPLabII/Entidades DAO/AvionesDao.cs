using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Entidades_DAO
{
    public class AvionesDao
    {
        public static SqlCommand comando;
        public static SqlConnection conexion;

        static AvionesDao()
        {
            conexion = new SqlConnection(@"Data Source = .;
                                Database = AEROLINEA;
                                Trusted_Connection = True;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Aviones> LeerAviones()
        {
            List<Aviones> listaAviones = new List<Aviones>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM aviones";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaAviones.Add(new Aviones(
                           reader["matricula"].ToString(),
                           Convert.ToDouble(reader["cantidad_asientos"]),
                           Convert.ToBoolean(reader["servicio_internet"]),
                           Convert.ToBoolean(reader["servicio_comida"]),
                           Convert.ToDouble(reader["capacidad_bodega"]),
                           reader["modelo"].ToString(),
                           Convert.ToDouble(reader["cantidad_asientos_normales"]),
                           Convert.ToDouble(reader["cantidad_asientos_premium"])
                        ));
                    }
                }
            }
            finally
            {
                conexion.Close();
            }

            return listaAviones;
        }
    }
}
