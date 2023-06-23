using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.PPLabII
{
    public class ConfigAPP
    {
        Color colorPrimario;
        Color colorSecundario;

        public ConfigAPP(Color primario, Color secundario)
        {
            this.colorPrimario = primario;
            this.colorSecundario = secundario;
        }

        public Color ColorSecundario { get => colorSecundario; set => colorSecundario = value; }
        public Color ColorPrimario { get => colorPrimario; set => colorPrimario = value; }
    }
}
