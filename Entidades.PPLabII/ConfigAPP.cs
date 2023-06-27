using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class ConfigAPP
    {
        string tema;

        [JsonConstructor]
        public ConfigAPP(string tema)
        {
            this.tema = tema;
        }

        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }

    }
}
