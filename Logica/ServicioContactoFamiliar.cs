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
        BaseDatosFamiliar baseDatosFamiliar = new BaseDatosFamiliar();
        List<ContactoFamiliarDto> listaDto = null;
        List<ContactoFamiliar> lista = null;    

        public ServicioContactoFamiliar()
        {

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

                baseDatosFamiliar.Agregar(contacto);
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

        public void EliminarBD(int id)
        {
            baseDatosFamiliar.Borrar(id);
        }

        public void Actualizar(dynamic contacto)
        {
            baseDatosFamiliar.Actualizar(contacto);
        }

        public List<ContactoFamiliar> GetAll()
        {
            return lista = baseDatosFamiliar.Consultar();
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
