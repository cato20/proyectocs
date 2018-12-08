using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class MenuRestaurante
    {
        public MenuRestaurante()
        {
            Console.WriteLine("****************MENU RESTAURANTE****************");
            Console.WriteLine("Elija una opcion!!");
            Console.WriteLine("1. ADMINISTRACION DE RESTAURANTE");
            Console.WriteLine("2. MENU MESAS");
            Console.WriteLine("3. MENU DEL PERSONAL");

            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //admi del restaurante
                    break;
                case 2:
                    //menu Mesas
                    break;
                case 3:
                    MenuPersonal mp = new MenuPersonal();
                   
                    break;
                default:
                    break;
            }
        }
    }
}
