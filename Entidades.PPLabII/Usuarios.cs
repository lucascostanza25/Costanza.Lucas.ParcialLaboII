using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class Usuarios : Persona
    {
        private int? legajo;
        private string? correo;
        private string? clave;
        private string? perfil;

        public Usuarios() : base()
        {
            this.legajo = 0;
            this.correo = "";
            this.clave = "";
            this.perfil = "";
        }
        [JsonConstructor]
        public Usuarios(string? apellido, string? nombre, int? legajo, string? correo, string? clave, string? perfil) : base(apellido, nombre)
        {
            this.legajo = legajo;
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
        }

        protected override string Datos()
        {
            throw new NotImplementedException();
        }

        #region Propiedades
        [JsonPropertyName("legajo")]
        public int? Legajo
        {
            get { return legajo; }
            set { this.legajo = value; }
        }

        [JsonPropertyName("correo")]
        public string? Correo
        {
            get { return correo; }
            set { this.correo = value; }
        }

        [JsonPropertyName("clave")]
        public string? Clave
        {
            get { return clave; }
            set { this.clave = value; }
        }

        [JsonPropertyName("perfil")]
        public string? Perfil
        {
            get { return perfil; }
            set { this.perfil = value; }
        }
        #endregion

    }
}
