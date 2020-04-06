using System;
namespace TercerLaboratorio
{
    public class Producto
    {
        protected string nombre;
        protected int precio;
        protected string marca;
        protected int stock;
        public Producto(string nombre, int precio, string marca, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
            this.stock = stock;
        }
        public int GetPrecio()
        {
            return precio;
        }
    }
}
