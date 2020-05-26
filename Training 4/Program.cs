using System;
using System.Collections.Generic;
using System.Linq;

namespace Training_4
{
    class Program
    {
        public static List<Persona> listaPersonas = new List<Persona>();
        static void Main(string[] args)
        {
            GenerarPersonas();
            /*Console.WriteLine("buscando a felix");
            var personaBuscada = listaPersonas.Find(persona => persona.nombre == "felix");
            Console.WriteLine($"{personaBuscada.nombre} con telefono {personaBuscada.telefono} y email{personaBuscada.email} se encuentra en la posicion {listaPersonas.IndexOf(personaBuscada)+1}");
            Console.WriteLine("borrando a pepe");
            listaPersonas.Remove(listaPersonas.Find(persona => persona.nombre == "pepe"));
            if(listaPersonas.Find(persona => persona.nombre == "pepe") == null)
            {
                Console.WriteLine("pepe fue borrado");
            }
            foreach(Persona persona in listaPersonas)
            {
                Console.WriteLine($"{persona.nombre} con telefono {persona.telefono} y email{persona.email} se encuentra en la posicion {listaPersonas.IndexOf(persona) + 1}");
            }*/
            MenuPrincipal();
        }

        public static void GenerarPersonas()
        {
            listaPersonas.Add(new Persona("jorge", "123", "jorge@training.con"));
            listaPersonas.Add(new Persona("pedro", "124", "pedro@training.con"));
            listaPersonas.Add(new Persona("maria", "125", "maria@training.con"));
            listaPersonas.Add(new Persona("felix", "126", "felix@training.con"));
            listaPersonas.Add(new Persona("pepe", "127", "pepe@training.con"));
            listaPersonas.Add(new Persona("camila", "128", "camila@training.con"));
            listaPersonas.Add(new Persona("pablo", "129", "pablo@training.con"));
            listaPersonas.Add(new Persona("silvia", "130", "silvia@training.con"));
        }

        private static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine($"Eliga una opcion:\n" +
                "1. Agregar contacto \n" +
                "2. Borrar contacto\n" +
                "3. Buscar contacto\n" +
                "4. Mostrar contactos\n" +
                "5. Salir");
            string imput = Console.ReadLine();
            switch (imput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Ingrese Nombre:");
                    string personaNombre = Console.ReadLine();
                    Console.WriteLine("Ingrese Numero de Telefono:");
                    string personaTelefono = Console.ReadLine();
                    Console.WriteLine("Ingrese Email:");
                    string personaEmail = Console.ReadLine();
                    Persona contacto = new Persona(personaNombre, personaTelefono, personaEmail);
                    listaPersonas.Add(contacto);
                    break;
                case "2":
                    Console.WriteLine("Ingrese el nombre del contacto que desa borrar");
                    string personaABorrar = Console.ReadLine();
                    listaPersonas.Remove(listaPersonas.Find(persona => persona.nombre == personaABorrar));
                    break;
                case "3":
                    Console.WriteLine("Ingrese el nombre del contacto que desa buscar");
                    string personaBuscada = Console.ReadLine();
                    var personaEncontrada = listaPersonas.Find(persona => persona.nombre == personaBuscada);
                    Console.WriteLine($"{personaEncontrada.nombre} con telefono {personaEncontrada.telefono} y email{personaEncontrada.email} se encuentra en la posicion {listaPersonas.IndexOf(personaEncontrada) + 1}");
                    break;
                case "4":
                    foreach (Persona persona in listaPersonas)
                    {
                        Console.WriteLine($"{persona.nombre} con telefono {persona.telefono} y email{persona.email} se encuentra en la posicion {listaPersonas.IndexOf(persona) + 1}");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuPrincipal();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
