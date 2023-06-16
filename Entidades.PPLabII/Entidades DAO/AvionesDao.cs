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
                           Convert.ToInt32(reader["cantidad_asientos"]),
                           Convert.ToBoolean(reader["servicio_internet"]),
                           Convert.ToBoolean(reader["servicio_comida"]),
                           Convert.ToDouble(reader["capacidad_bodega"]),
                           reader["modelo"].ToString(),
                           Convert.ToInt32(reader["cantidad_asientos_normales"]),
                           Convert.ToInt32(reader["cantidad_asientos_premium"])
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

        public static void GuardarAviones(Aviones avion)
        {
            
            try
            {
                conexion.Open();
                comando.CommandText = "INSERT INTO aviones VALUES (@matricula, @servicio_comida, @servicio_internet, @capacidad_bodega, @modelo, @cantidad_asientos, @cantidad_asientos_premium, @cantidad_asientos_normales)";
                comando.Parameters.AddWithValue("@matricula", avion.Matricula);
                comando.Parameters.AddWithValue("@servicio_comida", Convert.ToByte(avion.ServicioComida));
                comando.Parameters.AddWithValue("@servicio_internet", Convert.ToByte(avion.ServicioInternet));
                comando.Parameters.AddWithValue("@capacidad_bodega", avion.CapacidadBodega);
                comando.Parameters.AddWithValue("@modelo", avion.ModeloAvion);
                comando.Parameters.AddWithValue("@cantidad_asientos", avion.CantidadAsientos);
                comando.Parameters.AddWithValue("@cantidad_asientos_premium", avion.CantidadAsientosPremium);
                comando.Parameters.AddWithValue("@cantidad_asientos_normales", avion.CantidadAsientosNormales);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void EliminarAvion(Aviones avionEliminar)
        {
            try
            {
                conexion.Open();
                comando.CommandText = "DELETE FROM aviones WHERE matricula = @matricula";
                comando.Parameters.AddWithValue("@matricula", avionEliminar.Matricula);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
