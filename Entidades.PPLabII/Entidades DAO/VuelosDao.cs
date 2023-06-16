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
                            listaPasajerosVuelos
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

        public static void GuardarVuelos(Vuelos vuelo)
        {
            string origen, destino;
            origen = vuelo.Origen.ToString();
            destino = vuelo.Destino.ToString();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "INSERT INTO vuelos (fecha, codigo, origen, destino, horas, precio, matricula_avion) VALUES (@fecha, @codigo, @origen, @destino, @horas, @precio, @matricula_avion)";
                comando.Parameters.AddWithValue("@fecha", vuelo.FechaVuelo);
                comando.Parameters.AddWithValue("@codigo", vuelo.CodigoVuelo);
                comando.Parameters.AddWithValue("@origen", origen);
                comando.Parameters.AddWithValue("@destino", destino);
                comando.Parameters.AddWithValue("@horas", vuelo.HorasVuelo);
                comando.Parameters.AddWithValue("@precio", vuelo.PrecioVuelo);
                comando.Parameters.AddWithValue("@matricula_avion", vuelo.AvionVuelo.Matricula);

                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        public static bool ActualizarVuelo(Vuelos vueloActualizado)
        {
            string origen, destino;
            origen = vueloActualizado.Origen.ToString();
            destino = vueloActualizado.Destino.ToString();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = "UPDATE vuelos SET fecha = @fecha, codigo = @codigo, origen = @origen, destino = @destino, horas = @horas, precio = @precio, matricula_avion =  @matricula_avion)";
                comando.Parameters.AddWithValue("@fecha", vueloActualizado.FechaVuelo);
                comando.Parameters.AddWithValue("@codigo", vueloActualizado.CodigoVuelo);
                comando.Parameters.AddWithValue("@origen", origen);
                comando.Parameters.AddWithValue("@destino", destino);
                comando.Parameters.AddWithValue("@horas", vueloActualizado.HorasVuelo);
                comando.Parameters.AddWithValue("@precio", vueloActualizado.PrecioVuelo);
                comando.Parameters.AddWithValue("@matricula_avion", vueloActualizado.AvionVuelo.Matricula);

                int filasAfeactadas = comando.ExecuteNonQuery();

                if(filasAfeactadas > 0)
                {
                    return true;
                }
            }
            finally
            {
                conexion.Close();
            }
            return false;
        }

    }
}
