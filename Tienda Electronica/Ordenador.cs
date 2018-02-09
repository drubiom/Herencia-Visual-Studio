using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Electronica
{
    class Ordenador : Producto
    {
        private float velocidad;
        private int puertos;
        public Ordenador() : base()
        {
            this.velocidad = 0;
            this.puertos = 0;
        }
        public Ordenador(string marca, string nombre, int ram, double precio, float velocidad, int puertos) : base(marca, nombre, ram, precio)
        {
            this.velocidad = velocidad;
            this.puertos = puertos;
        }

        public string Escribe()
        {
            return "Marca: " + this.marca + " Nombre: " + this.nombre + " RAM: " + this.ram.ToString() + " Precio: " + this.precio.ToString() + " Velocidad: " + this.velocidad.ToString() + " Puertos: " + this.puertos.ToString();
        }

        public string getnombre()
        {
            return this.nombre;
        }
    }
}
