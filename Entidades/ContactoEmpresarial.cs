using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoEmpresarial : Persona
    {
        public ContactoEmpresarial()
        { }
        public ContactoEmpresarial(int id, string nombre, string telefono, string nombreEmpresa, string correo) : base(id, nombre, telefono)
        {
            NombreEmpresa = nombreEmpresa;
            Correo = correo;
        }

        public string NombreEmpresa { get; set; }

        public string Correo { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{NombreEmpresa};{Correo}";
        }

    }
}
