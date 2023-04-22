using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using Entidades;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Diagnostics.Contracts;

namespace Presentacion
{
    public class ContactoFamiliarGUI
    {
        ServicioContactoFamiliar ServicioContactoFamiliar = new ServicioContactoFamiliar();
        string busqueda;
        int d, m, a;

        public void CapturarDatos()
        {            
            var contacto = new ContactoFamiliar();

            Console.Clear();
            Console.SetCursorPosition(25, 5);  Console.Write("Datos de contactos familiares");
            contacto.Id= new Random().Next(1,40);
            Console.SetCursorPosition(25, 7); Console.Write("Nombre: "); 
            contacto.Nombre= Console.ReadLine();
            Console.SetCursorPosition(25, 9); Console.Write("Telefono: "); 
            contacto.Telefono = Console.ReadLine();            
            Console.SetCursorPosition(25,11); Console.Write("Fecha de nacimiento");
            Console.SetCursorPosition(25,13); Console.Write("Dia: "); 
            d = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(25,15); Console.Write("Mes: "); 
            m = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(25,17); Console.Write("Año: "); 
            a = int.Parse(Console.ReadLine());
                contacto.FechaNacimiento = new DateTime(a, m, d);
            var msg=ServicioContactoFamiliar.Add(contacto);
            Console.SetCursorPosition(25,19); Console.Write(msg);
            Console.ReadKey();
        }
        
        public void Consultar()
        {
            Titulos();
            MostrarDatosTabla();
            Console.SetCursorPosition(20, 7); Console.Write("Ingrese el nombre o teléfono del contacto que desea buscar: ");
            Console.SetCursorPosition(80,7); busqueda = Console.ReadLine();           
            var contacto = ServicioContactoFamiliar.Buscar(busqueda);                  
            Titulos();
            Console.SetCursorPosition(20, 11); Console.Write(contacto.Id);
            Console.SetCursorPosition(25, 11); Console.Write(contacto.Nombre);
            Console.SetCursorPosition(40, 11); Console.Write(contacto.Telefono);
            Console.SetCursorPosition(55, 11); Console.Write(contacto.Edad().ToString());
            Console.SetCursorPosition(65, 11); Console.Write(contacto.FechaNacimiento.ToShortDateString());            
            Console.ReadKey();                                              
        }

        public void Borrar()
        {
            Titulos();
            int i = MostrarDatosTabla();
            Console.SetCursorPosition(20, 7); Console.Write("Ingrese el nombre o teléfono del contacto que desea borrar: ");
            busqueda = Console.ReadLine();            
            //var contacto = ServicioContactoFamiliar.Buscar(busqueda);  
            var msg = ServicioContactoFamiliar.Eliminar(busqueda);
            Console.SetCursorPosition(20, 9 + i); Console.Write(msg);            
            Titulos();
            MostrarDatosTabla();
            Console.ReadKey();
        }

        public void Actualizar()
        {
            Titulos();
            MostrarDatosTabla();
            Console.SetCursorPosition(20, 7); Console.Write("Ingrese el nombre o teléfono del contacto que desea actualizar: ");
            busqueda = Console.ReadLine();
            Console.Clear();
            var contacto = ServicioContactoFamiliar.Buscar(busqueda);
            contacto.Id = new Random().Next(1, 40);
            Console.SetCursorPosition(25, 7); Console.Write("Nombre: ");
            contacto.Nombre = Console.ReadLine();
            Console.SetCursorPosition(25, 9); Console.Write("Telefono: ");
            contacto.Telefono = Console.ReadLine();
            Console.SetCursorPosition(25, 11); Console.Write("Dia: ");
            d = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(25, 13); Console.Write("Mes: ");
            m = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(25, 15); Console.Write("Año: ");
            a = int.Parse(Console.ReadLine());
            contacto.FechaNacimiento = new DateTime(a, m, d);                        
            Titulos();
            MostrarDatosTabla();
            Console.ReadKey();
        }

        public void Titulos()
        {
            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.WriteLine("Listado de contactos familiares");
            Console.SetCursorPosition(20, 9); Console.Write("ID");
            Console.SetCursorPosition(25, 9); Console.Write("NOMBRE");
            Console.SetCursorPosition(40, 9); Console.Write("TELEFONO");
            Console.SetCursorPosition(55, 9); Console.Write("EDAD");
            Console.SetCursorPosition(65, 9); Console.Write("FECHA-DE-NACIMIENTO");            
        }

        public int MostrarDatosTabla()
        {
            int i = 2;                        
            foreach (var item in ServicioContactoFamiliar.GetAll())
            {
                Console.SetCursorPosition(20, 9 + i); Console.Write(item.Id);
                Console.SetCursorPosition(25, 9 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(40, 9 + i); Console.Write(item.Telefono);
                Console.SetCursorPosition(55, 9 + i); Console.Write(item.Edad());
                Console.SetCursorPosition(65, 9 + i); Console.Write(item.FechaNacimiento.ToShortDateString());
                i++;
            }
        return i;
        }
    }
}
