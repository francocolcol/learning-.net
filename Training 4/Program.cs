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
            Console.WriteLine("buscando a felix");
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
            }
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
    }
}
