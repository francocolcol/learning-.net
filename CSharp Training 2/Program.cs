using System;
using System.Collections;
using System.Dynamic;

namespace CSharp_Training_2
{
    class Program
    {
        private static int capacidadStack = 30;
        private static StackGenerico<Employee> stack = new StackGenerico<Employee>(capacidadStack);
        private static Circulo circulo = new Circulo(25.2);
        private static Employee empleado = new Employee("roberto", "gonzales", "rbgz@gmail.com");
        private static Employee empleado2 = new Employee("Ezequiel", "perez", "rbgz@gmail.com");
        static void Main(string[] args)
        {
            Console.WriteLine(circulo.GetDiametro());
            GenerarStack();
            /*while (!stack.EstaVacio())
            {
                Employee emp = stack.Pop();
                Console.WriteLine($"Nombre: {emp.nombre} \n Apellido: {emp.apellido} \n Email:{emp.email}");

            }*/
            /*foreach (Employee e in stack.TopToBottom)
            {
                Console.Write("{0} ", e.nombre);
            }
            Console.WriteLine();
            // Output: 9 8 7 6 5 4 3 2 1 0

            foreach (Employee e in stack.BottomToTop)
            {
                Console.Write("{0} ", e.nombre);
            }
            Console.WriteLine();
            // Output: 0 1 2 3 4 5 6 7 8 9

            foreach (Employee e in stack.TopN(7))
            {
                Console.Write("{0} ", e.nombre);
            }
            Console.WriteLine();*/
            MenuPrincipal();
        }

        private static void GenerarStack()
        {
            stack.Push(empleado);
            stack.Push(empleado2);
        }

        private static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine($"Capacidad de stack: {capacidadStack} \n" +
                $"Cantidad en stack: {stack.cantidadEnStack}\n" +
                $"Eliga una opcion:\n" +
                $"1. Operaciones Push o Pop \n" +
                $"2. Mostrar items\n" +
                $"3. Salir");
            string imput = Console.ReadLine();
            switch (imput)
            {
                case "1":
                    MenuPushPop();
                    break;
                case "2":
                    MenuMostrarItems();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void MenuPushPop()
        {
            Console.Clear();
            Console.WriteLine("Eliga una opcion: \n" +
                "1. Push\n" +
                "2. Pop\n" +
                "3. Menu anterior\n" +
                "4. Salir");
            string imput = Console.ReadLine();
            switch (imput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Ingrese Nombre:");
                    string personaNombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Apellido:");
                    string personaApellido = Console.ReadLine();
                    Console.WriteLine("Ingrese Email:");
                    string personaEmail = Console.ReadLine();
                    Employee empleado = new Employee(personaNombre, personaApellido, personaEmail);
                    MenuPushPop();
                    break;
                case "2":
                    Employee emp = stack.Pop();
                    Console.WriteLine($"Nombre: {emp.nombre} \n Apellido: {emp.apellido} \n Email:{emp.email}");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuPushPop();
                    break;
                case "3":
                    MenuPrincipal();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void MenuMostrarItems()
        {
            Console.Clear();
            Console.WriteLine("Eliga una opcion: \n" +
                "1. Mostrar los elementos desde arriba del stack hacia abajo\n" +
                "2. Mostrar los elementos desde abajo del stack hacia arriba\n" +
                "3. Mostrar una cantidad de elementos de arriba del stack\n" +
                "4. Volver al menu principal\n" +
                "5. Salir");
            string imput = Console.ReadLine();
            switch (imput)
            {
                case "1":
                    foreach (Employee e in stack.TopToBottom)
                    {
                        Console.WriteLine($"Nombre: {e.nombre} \n Apellido: {e.apellido} \n Email:{e.email}");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuMostrarItems();
                    break;
                case "2":
                    foreach (Employee e in stack.BottomToTop)
                    {
                        Console.WriteLine($"Nombre: {e.nombre} \n Apellido: {e.apellido} \n Email:{e.email}");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuMostrarItems();
                    break;
                case "3":
                    Console.WriteLine("Cuantos elementos desea ver?");
                    int cantidadTopN;
                    int.TryParse(Console.ReadLine(), out cantidadTopN);
                    foreach (Employee e in stack.TopN(cantidadTopN))
                    {
                        Console.WriteLine($"Nombre: {e.nombre} \n Apellido: {e.apellido} \n Email:{e.email}");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuMostrarItems();
                    break;
                case "4":
                    MenuPrincipal();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
