using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpresarial : IRepositorio<ContactoEmpresarial>
    {
        string ruta = "contactoEmpresarial.txt";
        string rutaTemp = "contactoEmpresarialTemp.txt";

        public string GuardarContacto(ContactoEmpresarial contacto)
        {
            //1
            StreamWriter sw = new StreamWriter(ruta, true);

            //2
            sw.WriteLine(contacto.ToString());

            //3
            sw.Close();

            return "Datos Guardados";
        }

        public void Reemplazar(List<ContactoEmpresarial> lista)
        {
            //1
            StreamWriter sw = new StreamWriter(rutaTemp, true);

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

        public List<ContactoEmpresarial> ConsultarTodos()
        {
            var lista = new List<ContactoEmpresarial>();

            var sr = new StreamReader(ruta);

            while (!sr.EndOfStream)
            {
                lista.Add(Mapeador(sr.ReadLine()));
            }
            sr.Close();
            return lista;
        }

        public List<ContactoEmpresarialDto> ConsultarTodosDto()
        {
            var lista = new List<ContactoEmpresarialDto>();

            var sr = new StreamReader(ruta);

            while (!sr.EndOfStream)
            {
                lista.Add(MapeadorDto(sr.ReadLine()));
            }
            sr.Close();
            return lista;
        }

        public ContactoEmpresarial Mapeador(string linea)
        {
            var contacto = new ContactoEmpresarial
            {
                Id = int.Parse(linea.Split(';')[0]),
                Nombre = linea.Split(';')[1],
                Telefono = linea.Split(';')[2],
                NombreEmpresa = linea.Split(';')[3],
                Correo = linea.Split(';')[4]
            };

            return contacto;
        }

        public ContactoEmpresarialDto MapeadorDto(string linea)
        {
            var contacto = new ContactoEmpresarialDto
            {
                Id = linea.Split(';')[0],
                Nombre = linea.Split(';')[1],
                Telefono = linea.Split(';')[2],
                NombreEmpresa = linea.Split(';')[3],
                Correo = linea.Split(';')[4]
            };
    
            return contacto;
        }
    }
}
