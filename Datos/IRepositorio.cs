using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IRepositorio<T>
    {
        string GuardarContacto(T contacto);
        void Reemplazar(List<T> lista);
        List<T> ConsultarTodos();
//¿Como agregar los DTO a la interfaz?
        T Mapeador(string linea);
    }
}
