using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public Persona()
        {
                
        }
        public Persona(int id, string nombre, string telefono, string ruta)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Ruta = ruta;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Ruta { get; set; }
    }
}
