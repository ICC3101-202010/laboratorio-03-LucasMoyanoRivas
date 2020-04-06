using System;
namespace TercerLaboratorio
{
    public class Persona
    {
        protected string name;
        protected string sirname;
        protected string rut;
        protected string date_of_birthday;
        protected string nationality;
        public Persona(string name, string sirname, string rut, string date_of_birthday, string nationality)
        {
            this.name = name;
            this.sirname = sirname;
            this.rut = rut;
            this.date_of_birthday = date_of_birthday;
            this.nationality = nationality;
        }

    }
}
