using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using System.Diagnostics.Contracts;

namespace Datos
{
    public class RepositorioFamiliar : IRepositorio<ContactoFamiliar>
    {
        string ruta = "contactoFamiliar.txt";
        string rutaTemp = "contactoFamiliarTemp.txt";

        public string GuardarContacto(ContactoFamiliar contacto)
        {
            //1
            StreamWriter sw = new StreamWriter(ruta, true);

            //2
            sw.WriteLine(contacto.ToString());

            //3
            sw.Close();

            return "Datos Almacenados";
        }

        public void Reemplazar(List<ContactoFamiliar> lista)
        {
            //1
            StreamWriter sw = new StreamWriter(rutaTemp,true);

            //2
            foreach (var item in lista)
            {
                sw.WriteLine(item.ToString());
            }

            //3
            sw.Close();

            File.Delete(ruta);
            File.Move(rutaTemp, ruta);
        }


        public List<ContactoFamiliar> ConsultarTodos()
        {
            //List<ContactoFamiliar> lista = new List<ContactoFamiliar>();
            var lista = new List<ContactoFamiliar>();   

            var sr = new StreamReader(ruta);

            while (!sr.EndOfStream) 
            {
                lista.Add(Mapeador(sr.ReadLine()));
            }
            sr.Close();
            return lista;
        }
        public List<ContactoFamiliarDto> ConsultarTodosDto()
        {
            //List<ContactoFamiliar> lista = new List<ContactoFamiliar>();
            var lista = new List<ContactoFamiliarDto>();

            var sr = new StreamReader(ruta);

            while (!sr.EndOfStream)
            {
                lista.Add(MapeadorDto(sr.ReadLine()));
            }
            sr.Close();
            return lista;
        }

        public ContactoFamiliar Mapeador(string linea)
        {
            var contacto = new ContactoFamiliar
            {
                Id = int.Parse(linea.Split(';')[0]),
                Nombre = linea.Split(';')[1],
                Telefono = linea.Split(';')[2],
                FechaCumpleaños = DateTime.Parse(linea.Split(';')[3])
            };

            return contacto;
        }
        public ContactoFamiliarDto MapeadorDto(string linea)
        {
            var contacto = new ContactoFamiliarDto
            {
                Id = linea.Split(';')[0],
                Nombre = linea.Split(';')[1],
                Telefono = linea.Split(';')[2],
                Fecha = linea.Split(';')[3]
            };

            return contacto;
        }

    }
}
