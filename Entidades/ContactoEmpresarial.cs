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
        public ContactoEmpresarial(int id, string nombre, string telefono, string nombreEmpresa, string correo, string ruta) : base(id, nombre, telefono, ruta)
        {
            NombreEmpresa = nombreEmpresa;
            Correo = correo;
            Ruta = ruta;
        }

        public string NombreEmpresa { get; set; }

        public string Correo { get; set; }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{NombreEmpresa};{Correo};{Ruta}";
        }

    }
}
