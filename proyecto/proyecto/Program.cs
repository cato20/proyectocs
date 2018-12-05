using System;
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
            Personal p1 = new Personal();
            p1.Insertar();
            p1.Mostrar();
            p1.Actualizar();
            Console.ReadKey();

        }
    }
}
