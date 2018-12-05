using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
   public class Cliente
    {
        int _nit;
        string _nombre;
         string _apellido;

        public int Nit
        {
            get
            {
                return _nit;
            }

            set
            {
                _nit = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }

            set
            {
                _apellido = value;
            }
        }

        public List<Cliente> ListaClientes
        {
            get
            {
                return _listaClientes;
            }

            set
            {
                _listaClientes = value;
            }
        }

        List<Cliente> _listaClientes;

        public Cliente()
        {
            ListaClientes = new List<Cliente>();

        }
      
    }
}
