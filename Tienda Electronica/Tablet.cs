using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronica
{
    public class Tablet : Producto
    {
        protected string resolucion;
        protected string bateria;
        public Tablet(string marca, string nombre, int ram, double precio, string resolucion, string bateria) : base(marca, nombre, ram, precio)
        {
            this.marca = marca;
            this.nombre = nombre;
            this.ram = ram;
            this.precio = precio;
            this.resolucion = resolucion;
            this.bateria = bateria;
        }
        public string ToString()
        {
            return "Marca: " + this.marca + " Nombre: " + this.nombre + " RAM: " + this.ram.ToString() + " Precio: " + this.precio.ToString() + " Resolucion: " + this.resolucion + " Bateria: " + this.bateria;
        }
    }
}
