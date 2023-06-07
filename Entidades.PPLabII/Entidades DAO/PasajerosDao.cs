using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public static class PasajerosDao
    {
        public static SqlCommand comando;
        public static SqlConnection conexion;

        static PasajerosDao()
        {
            conexion = new SqlConnection(@"Data Source = .;
                                Database = AEROLINEA;
                                Trusted_Connection = True;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Guardar(Pasajeros pasajero)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO pasajeros VALUES (@nombre, @apellido, @dni, @genero, @asiento_premium, @cantidad_equipaje, @peso_uno, @peso_dos, @codigo_vuelo, @edad)";
                comando.Parameters.AddWithValue("@nombre", pasajero.Nombre);
                comando.Parameters.AddWithValue("@apellido", pasajero.Apellido);
                comando.Parameters.AddWithValue("@dni", pasajero.Dni);
                comando.Parameters.AddWithValue("@genero", pasajero.Genero);
                if (pasajero.AsientoPremium)
                    comando.Parameters.AddWithValue("@asiento_premium", 1);
                else
                    comando.Parameters.AddWithValue("@asiento_premium", 0);
                comando.Parameters.AddWithValue("@cantidad_equipaje", (int)pasajero.CantidadEquipaje);
                comando.Parameters.AddWithValue("@peso_uno", (float)pasajero.PesoEquipajeUno);
                comando.Parameters.AddWithValue("@peso_dos", (float)pasajero.PesoEquipajeDos);
                comando.Parameters.AddWithValue("@codigo_vuelo", pasajero.CodigoVuelo);
                comando.Parameters.AddWithValue("@edad", pasajero.Edad);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Pasajeros> LeerPasajeros()
        {
            List<Pasajeros> listaPasajeros = new List<Pasajeros>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM pasajeros";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        listaPasajeros.Add(new Pasajeros(
                            reader["apellido"].ToString(),
                            reader["nombre"].ToString(),
                            Convert.ToInt32(reader["dni"]),
                            Convert.ToInt32(reader["edad"]),
                            reader["genero"].ToString(),
                            Convert.ToBoolean(reader["asiento_premium"]),
                            reader["codigo_vuelo"].ToString(),
                            Convert.ToInt32(reader["cantidad_equipaje"]),
                            Convert.ToDouble(reader["peso_uno"]),
                            Convert.ToDouble(reader["peso_dos"])
                            ));
                    }
                }
            }
            finally
            {
                conexion.Close();
            }

            return listaPasajeros;
        }
    }

}
