using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IContactoEmpresarial
    {
        string Add(ContactoEmpresarial contacto);
        string Delete(ContactoEmpresarial contacto);
        List<ContactoEmpresarial> GetAll();
        ContactoEmpresarial GetByPhone(string phone);
        List<ContactoEmpresarial> GetByName(string name);
        string Update(ContactoEmpresarial contacto);
        bool exists(ContactoEmpresarial contacto);
    }
}
