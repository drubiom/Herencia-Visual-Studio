using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronica
{
    class Producto
    {
        //MARCA
        private string marca;
        //NOMBRE
        private string nombre;
        //RAM
        private int ram;
        //PRECIO
        private double precio;

        public Producto()
        {
            marca = "";
            nombre = "";
            ram = 0;
            precio = 0.0;
        }
        public Producto(string marca, string nombre, int ram, double precio)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.ram = ram;
            this.precio = precio;
        }
        public string Escribe ()
        {
            return "Marca:"
        }

    }
}
