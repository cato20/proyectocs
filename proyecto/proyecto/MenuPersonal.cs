using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class MenuPersonal
    {
        public MenuPersonal()
        {
            Console.WriteLine("Ingrese la opcion que elegira: ");
            Console.WriteLine("1. Ingresar un nuevo Personal");
            Console.WriteLine("2. Mostrar el listado del personal actual");
            Console.WriteLine("3. Editar un personal");

            int simbolo = Convert.ToInt32(Console.ReadLine());
            Personal p = new Personal();
            switch (simbolo)
            {
                case 1:
                   
                    p.Insertar();
                    MenuPersonal menup = new MenuPersonal();
                    break;
                case 2:
                    p.Mostrar();
                    break;

                case 3:
                    p.Actualizar();
                    break;
            }
        }
    }
}
