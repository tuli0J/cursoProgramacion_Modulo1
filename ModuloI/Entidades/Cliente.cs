
using Entidades;

namespace Entidades
{
    public class Cliente : Persona 
    {
        public string Identidad { get; set; }

        public Cliente()
        {
        }

        public Cliente(string identidad)
        {
            Identidad = identidad;
        }
    }
}
