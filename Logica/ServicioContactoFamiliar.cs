using Datos;
using Entidades;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioContactoFamiliar : IContacto<ContactoFamiliar>
    {
        RepositorioFamiliar repositorio = new RepositorioFamiliar();
        List<ContactoFamiliarDto> listaDto = null;
        List<ContactoFamiliar> lista = null;    

        public ServicioContactoFamiliar()
        {
            listaDto = repositorio.ConsultarTodosDto();
            lista = repositorio.ConsultarTodos();
        }


        public string Add(ContactoFamiliar contacto)
        {
            try
            {
                //validar
                if (contacto == null)
                {
                    return "error al guardar el contacto ";
                }

                repositorio.GuardarContacto(contacto);
                return $"se guardo el contacto --> {contacto.Nombre}";
            }
            catch (Exception)
            {
                return "error al guardar el contacto ";
            }
        }

        public string Eliminar(string dato)
        {                   
            var contacto = Buscar(dato);
            lista.Remove(contacto);            
            repositorio.Reemplazar(lista);
            return "Contacto Eliminado";
        }

        public List<ContactoFamiliar> GetAll()
        {
            lista = repositorio.ConsultarTodos();
            if (repositorio.ConsultarTodos().Count == 0)
            {
                return null;
            }
            return lista;
        }

        public List<ContactoFamiliarDto> GetAllDto()
        {
            listaDto = repositorio.ConsultarTodosDto();
            if (repositorio.ConsultarTodosDto().Count == 0)
            {
                return null;
            }
            return listaDto;
        }
        public ContactoFamiliar Buscar(string busqueda)
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
        public BindingList<ContactoFamiliar> ListaEspecial()
        {
            var bl = new BindingList<ContactoFamiliar>(lista);
            return bl;
        }
    }
}
