using System;
namespace TercerLaboratorio
{
    public class Producto
    {
        protected string name;
        protected int price;
        protected string brand;
        protected int stock;
        public Producto(string name, int price, string brand, int stock)
        {
            this.name = name;
            this.price = price;
            this.brand = brand;
            this.stock = stock;
        }
        public string GetName()
        {
            return name;
        }
        public int GetPrice()
        {
            return price;
        }
        public void StockNow(int numberstock)
        {
            stock = stock - numberstock;
        }
        public int GetStock()
        {
            return stock;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Nombre del producto: {name}, Precio: {price}, Marca: {brand}, Stock: {stock}");
        }
    }
}
