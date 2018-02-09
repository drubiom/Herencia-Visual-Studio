using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronica
{
    public class Movil:Producto
    {
        protected string so;
        protected string bateria;
        protected int almacenamiento;

        public Movil(string marca, string nombre, int ram, double precio, string so, string bateria, int almacenamiento) : base(marca, nombre, ram, precio)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.ram = ram;
            this.precio = precio;
            this.so = so;
            this.bateria = bateria;
            this.almacenamiento = almacenamiento;
        }

        public string ToString()
        {
            return "Marca: " + this.marca + " Nombre: " + this.nombre + " RAM: " + this.ram.ToString() + " Precio: " + this.precio.ToString() + " SO: " + this.so + " Bateria: " + this.bateria.ToString()+ " Almacenamiento: " + this.almacenamiento.ToString();
        }
    }
}
