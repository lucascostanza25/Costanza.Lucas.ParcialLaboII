using Entidades.PPLabII.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII.Base_de_datos
{
    public class Sql<T> : ISQL<T>
    {
        public SqlCommand comando;
        public SqlConnection conexion;

        public Sql()
        {
            conexion = new SqlConnection(@"Data Source = .;
                                Database = AEROLINEA;
                                Trusted_Connection = True;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }


        public List<T> Leer(string query, Func<IDataRecord, T> datosObjeto)
        {
            List<T> listaObjeto = new List<T>();

            try
            {
                conexion.Open();
                comando.CommandText = query;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = datosObjeto(reader);
                        listaObjeto.Add(objeto);
                    }
                }
            }
            finally
            {
                conexion.Close();
            }

            return listaObjeto;
        }
        public void Guardar(string query, T objeto, Action<SqlCommand> datosObjeto)
        {
            try
            {
                conexion.Open();
                comando.CommandText = query;
                datosObjeto(comando);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Eliminar(string query, Action<SqlCommand> datosObjeto)
        {
            try
            {
                conexion.Open();
                comando.CommandText = query;
                datosObjeto(comando);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Editar(string query, Action<SqlCommand> datosObjeto)
        {
            try
            {
                conexion.Open();
                comando.CommandText = query;
                datosObjeto(comando);
            }
            finally
            {
                conexion.Close();
            }
        }
    } 
}
