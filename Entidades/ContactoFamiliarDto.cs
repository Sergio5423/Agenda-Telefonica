using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoFamiliarDto //: PersonaDto
    {
        //¿Crear una clase PersonaDto y heredar de esa?
        public ContactoFamiliarDto(string id, string nombre, string telefono, string fecha) //: base(id, nombre, telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Fecha = fecha;
        }
        public ContactoFamiliarDto()
        {
            
        }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Fecha { get; set; }

    }
}
