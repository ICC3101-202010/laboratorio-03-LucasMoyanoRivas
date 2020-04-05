using System;
namespace TercerLaboratorio
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string rut;
        protected string fecha_de_nacimiento;
        protected string nacionalidad;
        public Persona(string nombre, string apellido, string rut, string fecha_de_nacimiento, string nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.rut = rut;
            this.fecha_de_nacimiento = fecha_de_nacimiento;
            this.nacionalidad = nacionalidad;
        }

    }
}
