using Entidades;

namespace Entidades
{
    public class TipoMovimiento
    {
        public string  Nombre { get; set; }

        public TipoMovimiento()
        {
        }

        public TipoMovimiento(string nombre)
        {
            Nombre = nombre;
        }
    }
}
