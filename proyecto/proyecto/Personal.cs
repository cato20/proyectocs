 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
   public class Personal
    {
        int nit;
        string nombre;
        string apellido;
        int telefono;
        string direccion;
        List<Personal> listaPersonal;

        

        public Personal()
        {
            Nit = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Telefono = 0;
            Direccion = string.Empty;
           ListaPersonal= new List<Personal>();
        }
        public void Insertar()
        {
            Console.WriteLine("Ingrese nit:");
            int nit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese telefono:");
            int telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese direccion:");
            string direccion = Console.ReadLine();

            Personal p = new Personal() {
                Nit = nit,
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono,
                Direccion = direccion,
            };
           

            ListaPersonal.Add(p);
            Console.WriteLine("Se añadio exitosamente");
        }    

        public void Mostrar()
        {
            foreach (Personal personal in ListaPersonal)
            {
                Console.WriteLine(personal.Nit);
                Console.WriteLine(personal.Nombre);
                Console.WriteLine(personal.Apellido);
                Console.WriteLine(personal.Telefono);
                Console.WriteLine(personal.Direccion);
            }

        }
        public void Actualizar()
        {
            Console.WriteLine("Nit de la persona a buscar");
            int nitBuscar = Convert.ToInt32(Console.ReadLine());
            foreach (Personal personal in ListaPersonal)
            {
                if (personal.Nit == nitBuscar)
                {
                    Console.WriteLine("El nit del persona es: " +personal.Nit);
                    Console.WriteLine("El nombre del personal es: "+personal.Nombre);
                    Console.WriteLine("El apellido del personal es: "+personal.Apellido);
                    Console.WriteLine("El telefono del personale es: "+personal.Telefono);
                    Console.WriteLine("La direccion del personal es: "+personal.Direccion);


                }
            }
        }
        public int Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public List<Personal> ListaPersonal
        {
            get
            {
                return listaPersonal;
            }

            set
            {
                listaPersonal = value;
            }
        }
    }

}
