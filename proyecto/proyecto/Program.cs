﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("****************MENU PRINCIPAL****************");
            Console.WriteLine("Elija una opcion!!");
            Console.WriteLine("1. MENU RESTAURANTE");
            Console.WriteLine("2. MENU PLATOS");
            Console.WriteLine("3. MENU CLIENTES");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MenuRestaurante mr = new MenuRestaurante();

                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            // MenuPersonal m = new MenuPersonal();
            Mesa m1 = new Mesa();
            m1.IngresarMesa();
            Console.ReadKey();

        }
    }
}
