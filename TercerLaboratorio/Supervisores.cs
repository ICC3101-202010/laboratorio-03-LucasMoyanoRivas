using System;
namespace TercerLaboratorio
{
    public class Supervisores : Persona,IChangeJob, IChangeSalary, IChangeWorkingHours
    {
        private int salary;
        private string job;
        private int hours;
        public Supervisores(int salary, string job, int hours, string name, string sirname, string rut, string date_of_birthday, string nationality) : base(name, sirname, rut, date_of_birthday, nationality)
        {
            this.salary = salary;
            this.job = job;
            this.hours = hours;
        }
        public string GetName()
        {
            return name;
        }
        public int GetSalary()
        {
            return salary;
        }
        public string GetJob()
        {
            return job;
        }
        public int GetHours()
        {
            return hours;
        }
        public void ChangeJob(string newJob)
        {
            job = newJob;
        }
        public void ChangeSalary(int newSalary)
        {
            salary = newSalary;
        }
        public void ChangeWorkingHours(int newHour)
        {
            hours = newHour;
        }
    }
}
