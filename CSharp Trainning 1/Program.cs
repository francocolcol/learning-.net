using System;
using System.Dynamic;
using System.Text;

namespace CSharp_Trainning_1
{
    class Program
    {
        private static int[] array = { 1, 5, 7, 8, 4, 2, 3, 6, 9, 54 };
        static void Main(string[] args)
        {
            //HolaMundo();
        }

        private static void HolaMundo()
        {
            Console.WriteLine("Hola Mundo!");
            OrdenarArray();
            MostrarArray();
            BuscarEnArray(9);
            string texto = "El otro dia fui de paseo con mi pepe";
            CambiarString(texto);

        }

        private static void OrdenarArray()
        {
            Array.Sort(array);
        }

        private static void MostrarArray()
        {
            foreach(var numero in array)
            {
                Console.WriteLine(numero);
            }
        }

        private static void BuscarEnArray(int numeroBuscado)
        {
            bool bandera = true;
            for(int i = 0; i<array.Length; i++)
            {
                if(array[i] == numeroBuscado)
                {
                    Console.WriteLine($"El numero buscado se encuentra en la posicion {i}");
                    bandera = false;
                }
            }
            if (bandera)
            {
                Console.WriteLine("El numero buscado no se encuentra en el array");
            }
        }

        private static void CambiarString(string txt)
        {
            StringBuilder sb = new StringBuilder(txt);
            sb.Replace("pepe", "papa");
            Console.WriteLine(sb.ToString());
        }
    }
}
