using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Restaurante
    {
        int codSucursal;
        string direccion;
        int telefono;

        List<Restaurante> listaRestaurante;

        public Restaurante()
        {
            ListaRestaurante = new List<Restaurante>();


        }


        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public List<Restaurante> ListaRestaurante { get => listaRestaurante; set => listaRestaurante = value; }
        public int CodSucursal { get => codSucursal; set => codSucursal = value; }

        public void Ingresar()
        {
            Console.WriteLine("Ingresar codigo de sucursal:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la direccion");
            string dir = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de telefono del restaurante:");
            int tel = Convert.ToInt32(Console.ReadLine());

            Restaurante r = new Restaurante()
            {
                CodSucursal = codigo,
                Telefono = tel,
                Direccion= dir
                
            };
            ListaRestaurante.Add(r);
            Console.WriteLine("Se registro el restaurante exitosamente");
        }

    }
}
