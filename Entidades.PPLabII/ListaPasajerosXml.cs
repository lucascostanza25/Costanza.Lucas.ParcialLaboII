using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.PPLabII
{
    [XmlRoot("Pasajeros")]
    public class ListaPasajerosXml
    {
        [XmlElement("MiPasajero")]
        public List<Pasajeros>? Pasajeros { get; set; }
    }
}
