using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoFamiliar : Persona
    {
        public ContactoFamiliar()
        {
        }

        public ContactoFamiliar(int id, string nombre, string telefono, DateTime fechaCumpleaños, string ruta) : base(id, nombre, telefono, ruta)
        {
            FechaCumpleaños = fechaCumpleaños;
            Ruta = ruta;
        }
        public DateTime FechaCumpleaños { get; set; }

        public int Edad()
        {
            return DateTime.Now.Year - FechaCumpleaños.Year;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{Telefono};{FechaCumpleaños.ToShortDateString()};{Ruta}";
        }
    }
}
