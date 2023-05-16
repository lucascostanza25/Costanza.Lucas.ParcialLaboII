using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;

        public Persona()
        {
            nombre = "";
            apellido = "";
        }

        public Persona(string apellido, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        abstract protected string Datos();

        [XmlElement("apellido")]
        [JsonPropertyName("apellido")]
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        [XmlElement("nombre")]
        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

    }
}
