using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Usuarios
    {
        private string nombre;
        private string apellido;
        private int? legajo;
        private string correo;
        private string clave;
        private string perfil;

        public Usuarios()
        {
            this.nombre = "";
            this.apellido = "";
            this.legajo = 0;
            this.correo = "";
            this.clave = "";
            this.perfil = "";
        }

        public Usuarios(string apellido, string nombre, int legajo, string correo, string clave, string perfil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        #region Propiedades
        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        [JsonPropertyName("apellido")]
        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        [JsonPropertyName("legajo")]
        public int? Legajo
        {
            get { return legajo; }
            set { this.legajo = value; }
        }

        [JsonPropertyName("correo")]
        public string Correo
        {
            get { return correo; }
            set { this.correo = value; }
        }

        [JsonPropertyName("clave")]
        public string Clave
        {
            get { return clave; }
            set { this.clave = value; }
        }

        [JsonPropertyName("perfil")]
        public string Perfil
        {
            get { return perfil; }
            set { this.perfil = value; }
        }
        #endregion
    }
}
