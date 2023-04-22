using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class ContactoEmpresarialGUI
    {
        ServicioContactoEmpresarial ServicioContactoEmpresarial = new ServicioContactoEmpresarial();
        string busqueda;

        public void CapturarDatos()
        {
            var contacto = new ContactoEmpresarial();

            Console.Clear();
            Console.SetCursorPosition(25, 5); Console.Write("Datos de contacto empresarial");
            contacto.Id = new Random().Next(1, 40);
            Console.SetCursorPosition(25, 7); Console.Write("Nombre: ");
            contacto.Nombre = Console.ReadLine();
            Console.SetCursorPosition(25, 9); Console.Write("Telefono: ");
            contacto.Telefono = Console.ReadLine();
            Console.SetCursorPosition(25, 11); Console.Write("Nombre de la empresa: ");
            contacto.NombreEmpresa = Console.ReadLine();
            Console.SetCursorPosition(25, 13); Console.Write("Correo: ");
            contacto.Correo = Console.ReadLine();
            var msg = ServicioContactoEmpresarial.Add(contacto);
            Console.SetCursorPosition(25, 15); Console.Write(msg);
            Console.ReadKey();
        }
        public void Consultar()
        {        
            Titulos();
            MostrarDatosTabla();
            Console.SetCursorPosition(20, 7); Console.Write("Ingrese el nombre o teléfono del contacto que desea buscar: ");
            Console.SetCursorPosition(80, 7); busqueda = Console.ReadLine();
            var contacto = ServicioContactoEmpresarial.Buscar(busqueda);
            Titulos();
            Console.SetCursorPosition(20, 11); Console.Write(contacto.Id);
            Console.SetCursorPosition(25, 11); Console.Write(contacto.Nombre);
            Console.SetCursorPosition(40, 11); Console.Write(contacto.Telefono);
            Console.SetCursorPosition(55, 11); Console.Write(contacto.Correo);
            Console.SetCursorPosition(75, 11); Console.Write(contacto.NombreEmpresa);
            Console.ReadKey();
        }

        //public void ConsultarPorNombreOTelefono()
        //{
        //    Console.Clear();
        //    string busqueda;
        //    Console.SetCursorPosition(20, 9); Console.Write("ID");
        //    Console.SetCursorPosition(25, 9); Console.Write("NOMBRE");
        //    Console.SetCursorPosition(40, 9); Console.Write("TELEFONO");
        //    Console.SetCursorPosition(55, 9); Console.Write("CORREO");
        //    Console.SetCursorPosition(65, 9); Console.Write("NOMBRE-DE-LA-EMPRESA");            
        //    Console.SetCursorPosition(25, 5); Console.Write("Consulta contacto familiar por nombre o teléfono");
        //    Console.SetCursorPosition(20, 7); Console.Write("Ingrese el nombre o teléfono del contacto que desea buscar: ");
        //    busqueda = Console.ReadLine();
        //    foreach (var item in ServicioContactoEmpresarial.GetAll())
        //    {
        //        if ((busqueda.Equals(item.Nombre)) | (busqueda.Equals(item.Telefono)))
        //        {
        //            Console.SetCursorPosition(20, 11); Console.Write(item.Id);
        //            Console.SetCursorPosition(25, 11); Console.Write(item.Nombre);
        //            Console.SetCursorPosition(40, 11); Console.Write(item.Telefono);
        //            Console.SetCursorPosition(55, 11); Console.Write(item.Correo);
        //            Console.SetCursorPosition(65, 11); Console.Write(item.NombreEmpresa);
        //        }
        //        Console.ReadKey();
        //    }
        //}        

        public void Borrar()
        {
            Titulos();
            int i = MostrarDatosTabla();
            Console.SetCursorPosition(20, 7); Console.Write("Ingrese el nombre o teléfono del contacto que desea borrar: ");
            busqueda = Console.ReadLine();
            //var contacto = ServicioContactoEmpresarial.Buscar(busqueda);
            var msg = ServicioContactoEmpresarial.Eliminar(busqueda);
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
            var contacto = ServicioContactoEmpresarial.Buscar(busqueda);
            contacto.Id = new Random().Next(1, 40);
            Console.SetCursorPosition(25, 7); Console.Write("Nombre: ");
            contacto.Nombre = Console.ReadLine();
            Console.SetCursorPosition(25, 9); Console.Write("Telefono: ");
            contacto.Telefono = Console.ReadLine();
            Console.SetCursorPosition(25, 11); Console.Write("Correo: ");
            contacto.Correo = Console.ReadLine();
            Console.SetCursorPosition(25, 13); Console.Write("Nombre de la empresa: ");
            contacto.NombreEmpresa = Console.ReadLine();            
            Titulos();
            MostrarDatosTabla();
            Console.ReadKey();
        }
        public void Titulos()
        {
            Console.Clear();
            Console.SetCursorPosition(35, 5); Console.WriteLine("Listado de contactos Empresarial");
            Console.SetCursorPosition(20, 9); Console.Write("ID");
            Console.SetCursorPosition(25, 9); Console.Write("NOMBRE");
            Console.SetCursorPosition(40, 9); Console.Write("TELEFONO");
            Console.SetCursorPosition(55, 9); Console.Write("CORREO");
            Console.SetCursorPosition(75, 9); Console.Write("NOMBRE-DE-LA-EMPRESA");
        }
        public int MostrarDatosTabla()
        {
            int i = 2;
            foreach (var item in ServicioContactoEmpresarial.GetAll())
            {
                Console.SetCursorPosition(20, 9 + i); Console.Write(item.Id);
                Console.SetCursorPosition(25, 9 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(40, 9 + i); Console.Write(item.Telefono);
                Console.SetCursorPosition(55, 9 + i); Console.Write(item.Correo);
                Console.SetCursorPosition(75, 9 + i); Console.Write(item.NombreEmpresa);
                i++;
            }
            return i;
        }
    }
}

