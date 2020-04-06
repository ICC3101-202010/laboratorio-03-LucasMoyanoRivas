using System;
using System.Collections.Generic;

namespace TercerLaboratorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Empleados> listaempleados = new List<Empleados>();
            List<Jefes> listajefes = new List<Jefes>();
            List<Supervisores> listasupervisores = new List<Supervisores>();
            List<Auxiliares> listaauxiliares = new List<Auxiliares>();
            List<Producto> listaproductos = new List<Producto>();
            List<Clientes> listaclientes = new List<Clientes>();
            Console.WriteLine("Bienvenido al supermercado");
            for (int i = 2; 2 > 1; ++i)
            {
                Console.WriteLine("Presione 1 si desea agregar trabajadores, Presione 2 si desea cambiar algo a un trabajador, Presione 3 si desea agregar clientes, Presione 4 si desea agregar productos, presione 5 si desea ver la lista de productos, presione 6 si desea comprar, presione 7 si desea salir");
                string respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    Console.WriteLine("Cuantos trabajadores desea crear?");
                    int numberofworkers = Convert.ToInt32(Console.ReadLine());
                    for (int u = 0; u < numberofworkers; u++)
                    {
                        Console.WriteLine("Que tipo de trabajador desea crear?(Empleado/Jefe/Supervisor/Auxiliar)");
                        string job = Console.ReadLine();
                        Console.WriteLine("Que sueldo desea asignarles?(En pesos chilenos)");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cuantas horas debe trabajar?");
                        int workingHours = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cual es el nombre del empleado?");
                        string nombreEmpleado = Console.ReadLine();
                        Console.WriteLine("Cual es su apellido?");
                        string apellidoEmpleado = Console.ReadLine();
                        Console.WriteLine("Cual es su rut?");
                        string rutEmpleado = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de nacimiento?");
                        string fdnEmpleado = Console.ReadLine();
                        Console.WriteLine("Cual es su nacionalidad?");
                        string nacionalidadEmpleado = Console.ReadLine();
                        if (job == "Empleado")
                        {
                            Empleados empleado = new Empleados(salary, job, workingHours, nombreEmpleado, apellidoEmpleado, rutEmpleado, fdnEmpleado, nacionalidadEmpleado);
                            listaempleados.Add(empleado);
                            Console.WriteLine("Trabajador creado con exito");
                        }

                        if (job == "Jefe")
                        {
                            Jefes jefe = new Jefes(salary, job, workingHours, nombreEmpleado, apellidoEmpleado, rutEmpleado, fdnEmpleado, nacionalidadEmpleado);
                            listajefes.Add(jefe);
                            Console.WriteLine("Trabajador creado con exito");
                        }
                        if (job == "Supervisor")
                        {
                            Supervisores supervisor = new Supervisores(salary, job, workingHours, nombreEmpleado, apellidoEmpleado, rutEmpleado, fdnEmpleado, nacionalidadEmpleado);
                            listasupervisores.Add(supervisor);
                            Console.WriteLine("Trabajador creado con exito");

                        }
                        if (job == "Auxiliar")
                        {
                            Auxiliares auxiliar = new Auxiliares(salary, job, workingHours, nombreEmpleado, apellidoEmpleado, rutEmpleado, fdnEmpleado, nacionalidadEmpleado);
                            listaauxiliares.Add(auxiliar);
                            Console.WriteLine("Trabajador creado con exito");
                        }
                    }
                }
                if (respuesta == "2")
                {
                    Console.WriteLine("A cuantos trabajadores desea cambiarle algo?");
                    int numerodecambios = Convert.ToInt32(Console.ReadLine());
                    for (int z = 0; z < numerodecambios; ++z)
                    {
                        Console.WriteLine("A que tipo de trabajador se le desea cambiar?(Empleado/Jefe/Supervisor/Auxiliar)");
                        string resultadotipodetrabajador = Console.ReadLine();
                        if (resultadotipodetrabajador == "Empleado")
                        {
                            Console.WriteLine("Quiere cambiarle el sueldo?(si/no)");
                            string resultadoCambiosueldo = Console.ReadLine();
                            if (resultadoCambiosueldo == "si")
                            {
                                Console.WriteLine("A cual Empleado?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Empleados b in listaempleados)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuanto seria su nuevo sueldo?");
                                        int nuevoSueldo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Sueldo anterior era {b.GetSalary()} pesos");
                                        b.ChangeSalary(nuevoSueldo);
                                        Console.WriteLine($"Sueldo Cambiado, su sueldo cambio a {b.GetSalary()} pesos");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle el trabajo?(si/no)");
                            string resultadoCambiotrabajo = Console.ReadLine();
                            if (resultadoCambiotrabajo == "si")
                            {
                                Console.WriteLine("A cual Empleado?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Empleados b in listaempleados)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cual seria su nuevo trabajo?");
                                        string nuevoTrabajo = Console.ReadLine();
                                        Console.WriteLine($"Trabajo anterior era {b.GetJob()}");
                                        b.ChangeJob(nuevoTrabajo);
                                        Console.WriteLine($"Trabajo Cambiado, su trabajo cambio a {b.GetJob()}");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle las horas de trabajo?(si/no)");
                            string resultadoCambiohoras = Console.ReadLine();
                            if (resultadoCambiohoras == "si")
                            {
                                Console.WriteLine("A cual Empleado?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Empleados b in listaempleados)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuantas serian sus nuevas horas de trabajo?");
                                        int nuevasHoras = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Horas de trabajo anteriores eran {b.GetHours()} horas");
                                        b.ChangeWorkingHours(nuevasHoras);
                                        Console.WriteLine($"Horas de trabajo cambiadas, sus horas de trabajo cambiaron a {b.GetHours()} horas");
                                    }
                                }
                            }
                        }
                        if (resultadotipodetrabajador == "Jefe")
                        {
                            Console.WriteLine("Quiere cambiarle el sueldo?(si/no)");
                            string resultadoCambiosueldo1 = Console.ReadLine();
                            if (resultadoCambiosueldo1 == "si")
                            {
                                Console.WriteLine("A cual Jefe?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Jefes b in listajefes)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuanto seria su nuevo sueldo?");
                                        int nuevoSueldo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Sueldo anterior era {b.GetSalary()} pesos");
                                        b.ChangeSalary(nuevoSueldo);
                                        Console.WriteLine($"Sueldo Cambiado, su sueldo cambio a {b.GetSalary()} pesos");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle el trabajo?(si/no)");
                            string resultadoCambiotrabajo2 = Console.ReadLine();
                            if (resultadoCambiotrabajo2 == "si")
                            {
                                Console.WriteLine("A cual Jefe?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Jefes b in listajefes)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cual seria su nuevo trabajo?");
                                        string nuevoTrabajo = Console.ReadLine();
                                        Console.WriteLine($"Trabajo anterior era {b.GetJob()}");
                                        b.ChangeJob(nuevoTrabajo);
                                        Console.WriteLine($"Trabajo Cambiado, su trabajo cambio a {b.GetJob()}");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle las horas de trabajo?(si/no)");
                            string resultadoCambiohoras3 = Console.ReadLine();
                            if (resultadoCambiohoras3 == "si")
                            {
                                Console.WriteLine("A cual Jefe?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Jefes b in listajefes)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuantas serian sus nuevas horas de trabajo?");
                                        int nuevasHoras = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Horas de trabajo anteriores eran {b.GetHours()} horas");
                                        b.ChangeWorkingHours(nuevasHoras);
                                        Console.WriteLine($"Horas de trabajo cambiadas, sus horas de trabajo cambiaron a {b.GetHours()} horas");
                                    }
                                }
                            }
                        }
                        if (resultadotipodetrabajador == "Supervisor")
                        {
                            Console.WriteLine("Quiere cambiarle el sueldo?(si/no)");
                            string resultadoCambiosueldo4 = Console.ReadLine();
                            if (resultadoCambiosueldo4 == "si")
                            {
                                Console.WriteLine("A cual Supervisor?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Supervisores b in listasupervisores)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuanto seria su nuevo sueldo?");
                                        int nuevoSueldo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Sueldo anterior era {b.GetSalary()} pesos");
                                        b.ChangeSalary(nuevoSueldo);
                                        Console.WriteLine($"Sueldo Cambiado, su sueldo cambio a {b.GetSalary()} pesos");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle el trabajo?(si/no)");
                            string resultadoCambiotrabajo4 = Console.ReadLine();
                            if (resultadoCambiotrabajo4 == "si")
                            {
                                Console.WriteLine("A cual Supervisor?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Supervisores b in listasupervisores)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cual seria su nuevo trabajo?");
                                        string nuevoTrabajo = Console.ReadLine();
                                        Console.WriteLine($"Trabajo anterior era {b.GetJob()}");
                                        b.ChangeJob(nuevoTrabajo);
                                        Console.WriteLine($"Trabajo Cambiado, su trabajo cambio a {b.GetJob()}");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle las horas de trabajo?(si/no)");
                            string resultadoCambiohoras4 = Console.ReadLine();
                            if (resultadoCambiohoras4 == "si")
                            {
                                Console.WriteLine("A cual Supervisor?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Supervisores b in listasupervisores)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuantas serian sus nuevas horas de trabajo?");
                                        int nuevasHoras = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Horas de trabajo anteriores eran {b.GetHours()} horas");
                                        b.ChangeWorkingHours(nuevasHoras);
                                        Console.WriteLine($"Horas de trabajo cambiadas, sus horas de trabajo cambiaron a {b.GetHours()} horas");
                                    }
                                }
                            }
                        }
                        if (resultadotipodetrabajador == "Auxiliar")
                        {
                            Console.WriteLine("Quiere cambiarle el sueldo?(si/no)");
                            string resultadoCambiosueldo4 = Console.ReadLine();
                            if (resultadoCambiosueldo4 == "si")
                            {
                                Console.WriteLine("A cual Auxiliar?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Auxiliares b in listaauxiliares)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuanto seria su nuevo sueldo?");
                                        int nuevoSueldo = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Sueldo anterior era {b.GetSalary()} pesos");
                                        b.ChangeSalary(nuevoSueldo);
                                        Console.WriteLine($"Sueldo Cambiado, su sueldo cambio a {b.GetSalary()} pesos");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle el trabajo?(si/no)");
                            string resultadoCambiotrabajo4 = Console.ReadLine();
                            if (resultadoCambiotrabajo4 == "si")
                            {
                                Console.WriteLine("A cual Auxiliar?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Auxiliares b in listaauxiliares)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cual seria su nuevo trabajo?");
                                        string nuevoTrabajo = Console.ReadLine();
                                        Console.WriteLine($"Trabajo anterior era {b.GetJob()}");
                                        b.ChangeJob(nuevoTrabajo);
                                        Console.WriteLine($"Trabajo Cambiado, su trabajo cambio a {b.GetJob()}");
                                    }
                                }
                            }
                            Console.WriteLine("Quiere cambiarle las horas de trabajo?(si/no)");
                            string resultadoCambiohoras4 = Console.ReadLine();
                            if (resultadoCambiohoras4 == "si")
                            {
                                Console.WriteLine("A cual Auxiliar?(Responda con el nombre del trabajador)");
                                string resultadonombredeltrabajador = Console.ReadLine();
                                foreach (Auxiliares b in listaauxiliares)
                                {
                                    if (resultadonombredeltrabajador == b.GetName())
                                    {
                                        Console.WriteLine("Cuantas serian sus nuevas horas de trabajo?");
                                        int nuevasHoras = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Horas de trabajo anteriores eran {b.GetHours()} horas");
                                        b.ChangeWorkingHours(nuevasHoras);
                                        Console.WriteLine($"Horas de trabajo cambiadas, sus horas de trabajo cambiaron a {b.GetHours()} horas");
                                    }
                                }
                            }
                        }
                    }
                }
                if (respuesta == "3")
                {
                    Console.WriteLine("Cuantos clientes desea crear?");
                    int numberofworkers = Convert.ToInt32(Console.ReadLine());
                    for (int u = 0; u < numberofworkers; u++)
                    {
                        Console.WriteLine("Cuanto dinero debe tener?(Pesos chilenos)");
                        int money = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cual es el nombre del cliente?");
                        string nombreCliente = Console.ReadLine();
                        Console.WriteLine("Cual es su apellido?");
                        string apellidoCliente = Console.ReadLine();
                        Console.WriteLine("Cual es su rut?");
                        string rutCliente = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de nacimiento?");
                        string fdnCliente = Console.ReadLine();
                        Console.WriteLine("Cual es su nacionalidad?");
                        string nacionalidadCliente = Console.ReadLine();
                        Clientes cliente = new Clientes(money, nombreCliente, apellidoCliente, rutCliente, fdnCliente, nacionalidadCliente);
                        listaclientes.Add(cliente);
                    }
                }
                if (respuesta == "4")
                {
                    Console.WriteLine("Cuantos Productos desea crear?");
                    int numberofworkers = Convert.ToInt32(Console.ReadLine());
                    for (int u = 0; u < numberofworkers; u++)
                    {
                        Console.WriteLine("Cual es su precio?(Pesos Chilenos)");
                        int price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cual es el nombre del producto?");
                        string nombreProducto = Console.ReadLine();
                        Console.WriteLine("Cual es su marca?");
                        string marcaProducto = Console.ReadLine();
                        Console.WriteLine("Cuanto stock tiene?");
                        int stockProducto = Convert.ToInt32(Console.ReadLine());
                        Producto producto = new Producto(nombreProducto, price, marcaProducto, stockProducto);
                        listaproductos.Add(producto);
                    }
                }
                if (respuesta == "5")
                {

                }
                if (respuesta == "6")
                {

                }
                if (respuesta == "7")
                {
                    Console.WriteLine("Adios vuelva pronto!");
                    break;
                }
            }            
        }
    }
}
