using System;
using System.Collections;

namespace CSharp_Training_2
{
    class Program
    {
        private static StackGenerico<Employee> stack = new StackGenerico<Employee>(30);
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
            foreach (Employee e in stack.TopToBottom)
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
            Console.WriteLine();
        }

        private static void GenerarStack()
        {
            stack.Push(empleado);
            stack.Push(empleado2);
        }
    }
}
