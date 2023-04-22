using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoEmpresarialDto //: PersonaDto
    {
        public ContactoEmpresarialDto()
        {
            
        }
        public ContactoEmpresarialDto(string id, string nombre, string telefono, string nombreEmpresa, string correo) //: base(id, nombre, telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            NombreEmpresa = nombreEmpresa;
            Correo = correo;
        }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string NombreEmpresa { get; set; }
        public string Correo { get; set; }
    }
}
