using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Mesa
    {
        int numero;
        int capacidad;
        Cliente cliente;
        List<Mesa> listaMesas;
        public Mesa()
        {
            ListaMesas = new List<Mesa>();
        }

        public int Numero { get => numero; set => numero = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        internal List<Mesa> ListaMesas { get => listaMesas; set => listaMesas = value; }

        public void IngresarMesa()
        {
            cliente = new Cliente();
            Console.WriteLine("Ingrese el numero de la mesa:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la capacidad de la mesa:");
            int capa = Convert.ToInt32(Console.ReadLine());

            var cli = cliente.ListaCliente[0];

            Mesa mesa1 = new Mesa()
            {
                Numero = num,
                Capacidad = capa,
                Cliente = cli
            };
            ListaMesas.Add(mesa1);
            Console.WriteLine("Se registro la mesa!!");
            
            

        }
    }
}
