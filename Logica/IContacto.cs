using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IContacto<T>
    {
        string Add(T contacto);
        string Eliminar(string dato);
        List<T> GetAll();
        T Buscar(string busqueda);        
    }
}
