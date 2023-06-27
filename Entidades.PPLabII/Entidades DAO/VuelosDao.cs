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
            List<Pasajeros> listaPasajerosVuelos = new List<Pasajeros>();
            List<Vuelos> listaVuelos = new List<Vuelos>();
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM vuelos JOIN pasajeros ON vuelos.codigo = pasajeros.codigo_vuelo JOIN aviones ON vuelos.matricula_avion = aviones.matricula\r\n\r\nSELECT * FROM pasajeros WHERE nombre = 'Lilah'\r\n\r\nSELECT * FROM vuelos\r\n\r\nSELECT * FROM vuelos LEFT JOIN pasajeros ON vuelos.codigo = pasajeros.codigo_vuelo JOIN aviones ON vuelos.matricula_avion = aviones.matricula\r\n";

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Aviones avion = new Aviones{
                            Matricula = reader["matricula"].ToString(),
                            CantidadAsientos = Convert.ToInt32(reader["cantidad_asientos"]),
                            ServicioInternet = Convert.ToBoolean(reader["servicio_internet"]),
                            ServicioComida = Convert.ToBoolean(reader["servicio_comida"]),
                            CapacidadBodega = Convert.ToDouble(reader["capacidad_bodega"]),
                            ModeloAvion = reader["modelo"].ToString(),
                            CantidadAsientosNormales = Convert.ToInt32(reader["cantidad_asientos_normales"]),
                            CantidadAsientosPremium = Convert.ToInt32(reader["cantidad_asientos_premium"])
                        };

                        Pasajeros pasajero = new Pasajeros{

                            Apellido = reader["apellido"].ToString(),
                            Nombre = reader["nombre"].ToString(),
                            Dni = Convert.ToInt32(reader["dni"]),
                            Edad = Convert.ToInt32(reader["edad"]),
                            Genero = reader["genero"].ToString(),
                            AsientoPremium = Convert.ToBoolean(reader["asiento_premium"]),
                            CodigoVuelo = reader["codigo_vuelo"].ToString(),
                            CantidadEquipaje = Convert.ToInt32(reader["cantidad_equipaje"]),
                            PesoEquipajeUno = Convert.ToDouble(reader["peso_uno"]),
                            PesoEquipajeDos = Convert.ToDouble(reader["peso_dos"])
                        };

                        Vuelos vuelo = listaVuelos.FirstOrDefault(v => v.CodigoVuelo == reader["codigo"].ToString());
                        if (vuelo is null)
                        {
                            vuelo = new Vuelos
                            {

                                FechaVuelo = Convert.ToDateTime(reader["fecha"]),
                                CodigoVuelo = reader["codigo"].ToString(),
                                Origen = (DestinosVuelos)Enum.Parse(typeof(DestinosVuelos), reader["origen"].ToString()),
                                Destino = (DestinosVuelos)Enum.Parse(typeof(DestinosVuelos), reader["destino"].ToString()),
                                HorasVuelo = Convert.ToInt32(reader["horas"]),
                                PrecioVuelo = Convert.ToDouble(reader["precio"]),
                                MatriculaAvionVuelo = reader["matricula_avion"].ToString(),
                                ListaPasajeros = new List<Pasajeros>(),
                                AvionVuelo = avion
                            };
                            listaVuelos.Add(vuelo);
                        }
                        vuelo.ListaPasajeros.Add(pasajero);
                    }
                }
                if (listaVuelos.Count == 0)
                {
                    throw new ExcepcionBaseDatos();
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
