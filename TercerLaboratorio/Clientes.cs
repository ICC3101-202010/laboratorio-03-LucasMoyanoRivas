using System;
using System.Collections.Generic;
namespace TercerLaboratorio
    
{
    public class Clientes : Persona
    {
        private int money;
        private List<Producto> shoppingcart = new List<Producto>();
        public Clientes(int money, string nombre, string apellido, string rut, string fecha_de_nacimiento, string nacionalidad) : base(nombre, apellido, rut, fecha_de_nacimiento, nacionalidad)
        {
            this.money = money;
        }
        public void Cart(Producto product)
        {
            if (money == product.GetPrecio() || money > product.GetPrecio())
            {
                shoppingcart.Add(product);
            }
        }
        public int GetMoneyCart()
        {
            int totalprecio = 0;
            for (int i = 0; i < shoppingcart.Count; ++i)
            {
                totalprecio = totalprecio + shoppingcart[i].GetPrecio();
            }
            Console.WriteLine($"El precio total del carro es de {totalprecio}");
            return totalprecio;
        }
    }
}
