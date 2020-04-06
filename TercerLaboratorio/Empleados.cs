using System;
namespace TercerLaboratorio
{
    public class Empleados : Persona, IChangeJob, IChangeSalary, IChangeWorkingHours
    {
        private int sueldo;
        private string job;
        private int hours;
        public Empleados(int sueldo, string job, int hours, string nombre, string apellido, string rut, string fecha_de_nacimiento, string nacionalidad) : base(nombre, apellido, rut, fecha_de_nacimiento, nacionalidad)
        {
            this.sueldo = sueldo;
            this.job = job;
            this.hours = hours;
        }
        public string GetName()
        {
            return nombre;
        }
        public int GetSueldo()
        {
            return sueldo;
        }
        public string GetJob()
        {
            return job;
        }
        public int GetHours()
        {
            return hours;
        }
        public void ChangeJob(string nuevotrabajo)
        {
            job = nuevotrabajo;
        }
        public void ChangeSalary(int nuevoSueldo)
        {
            sueldo = nuevoSueldo;
        }
        public void ChangeWorkingHours(int nuevaHora)
        {
            hours = nuevaHora;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{nombre},{apellido},{rut},{fecha_de_nacimiento},{nacionalidad},{sueldo},{job},{hours}");
        }
        public void Cajero()
        {
            
        }
    }
}
