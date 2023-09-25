using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Perro
    {
        public string Nombre { get; set; } = string.Empty;

        public string Ladrar()
        {
            return "El perro esta ladrando";
        }

    }
}
