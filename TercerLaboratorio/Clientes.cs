using System;
using System.Collections.Generic;
namespace TercerLaboratorio
    
{
    public class Clientes : Persona
    {
        private int money;
        private List<Producto> shoppingcart = new List<Producto>();
        public Clientes(int money, string name, string sirname, string rut, string date_of_birthday, string nationality) : base(name, sirname, rut, date_of_birthday, nationality)
        {
            this.money = money;
        }
        public void Cart(Producto product)
        {
            if (money == product.GetPrice() || money > product.GetPrice())
            {
                shoppingcart.Add(product);
            }
        }
        public int GetMoneyCart()
        {
            int totalprice = 0;
            for (int i = 0; i < shoppingcart.Count; ++i)
            {
                totalprice = totalprice + shoppingcart[i].GetPrice();
            }
            Console.WriteLine($"El precio total del carro es de {totalprice}");
            return totalprice;
        }
    }
}
