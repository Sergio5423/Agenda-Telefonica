using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Menu
    {                       
        public void  MenuPrincipal()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(25,5); Console.Write("MENU PRINCIPAL");
                Console.SetCursorPosition(25, 7); Console.Write("1. Familiar");
                Console.SetCursorPosition(25, 9); Console.Write("2. Emprersarial");
                Console.SetCursorPosition(25, 11); Console.Write("3. Salir");
                Console.SetCursorPosition(25, 13); Console.Write("Que quieres hacer : ");
                Console.SetCursorPosition(45, 13); op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        MenuFamiliar();
                        break;
                        
                    case 2:
                        MenuEmpresarial();
                        break;

                    //default:
                    //    break;
                }

            } while (op!=3);
        }
        public void MenuFamiliar()
        {
            ContactoFamiliarGUI contactoFamiliarGUI= new ContactoFamiliarGUI();

            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(25, 5); Console.Write("MENU FAMILIAR");
                Console.SetCursorPosition(25, 7); Console.Write("1. Agregar");
                Console.SetCursorPosition(25, 9); Console.Write("2. Consultar");
                //Console.SetCursorPosition(25, 11); Console.Write("3. Consultar por nombre o teléfono");
                Console.SetCursorPosition(25, 11); Console.Write("3. Borrar");
                Console.SetCursorPosition(25, 13); Console.Write("4. Actualizar");
                Console.SetCursorPosition(25, 15); Console.Write("5. Volver...");
                Console.SetCursorPosition(25, 17); Console.Write("Que quieres hacer : ");
                Console.SetCursorPosition(45, 17); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                case 1:
                    contactoFamiliarGUI.CapturarDatos();
                    break;

                case 2:
                    contactoFamiliarGUI.Consultar();                    
                    break;

                    //case 3:
                    //    contactoFamiliarGUI.ConsultarPorNombreOTelefono();
                    //    break;

                case 3:
                    contactoFamiliarGUI.Borrar();
                    break;

                case 4:
                    contactoFamiliarGUI.Actualizar();
                    break;
                    //default:
                    //    break;
                }

            } while (op != 5);

        }
        public void MenuEmpresarial()
        {
            ContactoEmpresarialGUI contactoEmpresarialGUI = new ContactoEmpresarialGUI();
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(25, 5); Console.Write("MENU EMPRESARIAL");
                Console.SetCursorPosition(25, 7); Console.Write("1. Agregar");
                Console.SetCursorPosition(25, 9); Console.Write("2. Consultar");
                //Console.SetCursorPosition(25, 11); Console.Write("3. Consultar por nombre o teléfono");
                Console.SetCursorPosition(25, 13); Console.Write("4. Borrar");
                Console.SetCursorPosition(25, 15); Console.Write("5. Actualizar");
                Console.SetCursorPosition(25, 17); Console.Write("6. Volver...");
                Console.SetCursorPosition(25, 19); Console.Write("Que quieres hacer : ");
                Console.SetCursorPosition(45, 19); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        contactoEmpresarialGUI.CapturarDatos();
                        break;

                    case 2:
                        contactoEmpresarialGUI.Consultar();
                        break;

                    //case 3:
                    //    contactoFamiliarGUI.ConsultarPorNombreOTelefono();
                    //    break;

                    case 4:
                        contactoEmpresarialGUI.Borrar();
                        break;

                    case 5:
                        contactoEmpresarialGUI.Actualizar();
                        break;
                        //default:
                        //    break;
                }

            } while (op != 6);

        }
    }
}



























