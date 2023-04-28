using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    [XmlRoot("Vuelos")]
    public class ListaViajesXml
    {
        [XmlElement("MiVuelo")]
        public List<VuelosNacionales> Vuelos { get; set; }
    }
}
