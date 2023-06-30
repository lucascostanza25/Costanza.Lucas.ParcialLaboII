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

        /// <summary>
        /// Metodo que lee y trae todos los datos de un objeto
        /// </summary>
        /// <param name="query">Query del select</param>
        /// <param name="datosObjeto">Delegado action que recibe un SqlDataReader y devuelve T</param>
        /// <returns></returns>
        public List<T> Leer(string query, Func<SqlDataReader, T> datosObjeto)
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

        /// <summary>
        /// Metodo que guarda un objeto en sql
        /// </summary>
        /// <param name="query">Query del insert</param>
        /// <param name="objeto">Objeto a agregar</param>
        /// <param name="datosObjeto">Delegado action con los datos del objeto</param>
        public void Guardar(string query, T objeto, Action<SqlCommand> datosObjeto)
        {
            try
            {
                conexion.Open();
                comando.CommandText = query;
                datosObjeto(comando);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Metodo que elimina un objeto de sql
        /// </summary>
        /// <param name="query">Query del delete</param>
        /// <param name="datosObjeto">Delegado action con los datos del objeto</param>
        public void Eliminar(string query, Action<SqlCommand> datosObjeto)
        {
            try
            {
                conexion.Open();
                comando.CommandText = query;
                datosObjeto(comando);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Metodo que actualiza un objeto de sql
        /// </summary>
        /// <param name="query">Query del update</param>
        /// <param name="datosObjeto">Delegado action con los datos del objeto</param>
        public void Actualizar(string query, Action<SqlCommand> datosObjeto)
        {
            try
            {
                conexion.Open();
                comando.CommandText = query;
                datosObjeto(comando);
                comando.ExecuteNonQuery();  
            }
            finally
            {
                conexion.Close();
            }
        }
    } 
}
