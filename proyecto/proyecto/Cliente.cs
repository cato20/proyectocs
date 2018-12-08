using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Cliente
    {
        int ci;
        string nombre;

        List<Cliente> listaCliente;
        public Cliente()
        {
         /*   listaCliente = new List<Cliente>();
            Cliente cliente1 = new Cliente()
            {
                Ci = 1,
                Nombre = "Carlos",
            };
            listaCliente.Add(cliente1);
            */
        }

        public int Ci { get => ci; set => ci = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Cliente> ListaCliente { get => listaCliente; set => listaCliente = value; }

        public void ingresarCliente()
        {
            Console.WriteLine("Ingrese el NIT:");
            int ci = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();

            Cliente c = new Cliente()
            {
                Ci = ci,
                Nombre = nombre
            };
            ListaCliente.Add(c);
            Console.WriteLine("Se Registro un cliente");
        }

    }
}
