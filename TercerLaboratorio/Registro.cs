using System;
using System.Collections.Generic;
namespace TercerLaboratorio
{
    public class Registro
    {
        private string dateandhour;
        private List<string> listofproducts = new List<string>();
        private string namebuyer;
        private string namecashier;
        public Registro(string dateandhour, List<string> listofproducts, string namebuyer, string namecashier)
        {
            this.dateandhour = dateandhour;
            this.listofproducts = listofproducts;
            this.namebuyer = namebuyer;
            this.namecashier = namecashier;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Hora: {dateandhour}, Nombre del comprador: {namebuyer}, Nombre del cajero: {namecashier}");
            Console.WriteLine("Productos comprados");
            foreach(string a in listofproducts)
            {
                Console.WriteLine(a);
            }
        }
    }
}
