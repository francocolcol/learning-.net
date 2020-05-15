using System;
using System.Collections;

namespace CSharp_Training_2
{
    class Program
    {
        private static Stack stack = new Stack();
        private static Circulo circulo = new Circulo(25.2);
        private static Employee empleado = new Employee("roberto", "gonzales", "rbgz@gmail.com");
        private static Student estudiante = new Student("roberto", "gonzales", 258963);
        static void Main(string[] args)
        {
            Console.WriteLine(circulo.GetDiametro());
            GenerarStack();
            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
            Console.WriteLine(empleado.nombre);
            Console.WriteLine(estudiante.legajo);
        }

        private static void GenerarStack()
        {
            stack.Push("hola");
            stack.Push("adios");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(circulo);
        }
    }
}
