using System;
using System.Collections.Generic;
namespace TercerLaboratorio
{
    public class Registro
    {
        private string dateandhour;
        private string nameofproduct;
        private string namebuyer;
        private string namecashier;
        public Registro(string dateandhour, string nameofproduct, string namebuyer, string namecashier)
        {
            this.dateandhour = dateandhour;
            this.nameofproduct = nameofproduct;
            this.namebuyer = namebuyer;
            this.namecashier = namecashier;
        }
    }
}
