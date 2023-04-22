using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoEmpresarial : IContacto<ContactoEmpresarial>
    {
        RepositorioEmpresarial repositorio = new RepositorioEmpresarial();
        List<ContactoEmpresarial> lista = null;
        List<ContactoEmpresarialDto> listaDto = null;

        public ServicioContactoEmpresarial()
        {
            lista = new List<ContactoEmpresarial>();
        }        

        public string Add(ContactoEmpresarial contacto)
        {
            try
            {
                if (contacto == null)
                {
                    return "Error al guardar contacto";
                }

                repositorio.GuardarContacto(contacto);
                return $"Se guardo el contacto ----> {contacto.Nombre}";
            }
            catch (Exception) 
            {
                return "Error al guardar el contacto";
            }
        }
        public string Eliminar(string dato)
        {
            lista = GetAll();
            var contacto = Buscar(dato);
            lista.Remove(contacto);
            repositorio.Reemplazar(lista);
            return "Contacto Eliminado";
        }
        
        public List<ContactoEmpresarial> GetAll()
        {
            lista = repositorio.ConsultarTodos();
            return lista;
        }
        public List<ContactoEmpresarialDto> GetAllDto()
        {
            listaDto = repositorio.ConsultarTodosDto();
            return listaDto;
        }

        public ContactoEmpresarial Buscar(string busqueda)
        {
            foreach (var item in GetAll())
            {
                if ((busqueda.Equals(item.Nombre)) | (busqueda.Equals(item.Telefono)))
                {
                    return item;
                }
            }
            return null;
        }

        public int UltimoId()
        {
            int Id;
            Id = GetAll().Count;
            Id++;
            return Id;
        }
    }
}
