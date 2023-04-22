using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaDto
    {
        public PersonaDto()
        {
            
        }
        public PersonaDto(string id, string nombre, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }
        public string Id { get; set; }
        public string Nombre { get; set;}
        public string Telefono { get; set;}
    }
}
