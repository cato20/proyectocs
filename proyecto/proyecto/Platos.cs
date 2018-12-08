using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Platos
    {
        string nombre;
        double precio;
        string tamaño;
        string descripcion;

        List<Platos> listaPlatos;
        public Platos()
        {
            ListaPlatos = new List<Platos>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<Platos> ListaPlatos { get => listaPlatos; set => listaPlatos = value; }
    }
}
