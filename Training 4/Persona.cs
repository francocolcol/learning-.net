using System;
using System.Collections.Generic;
using System.Text;

namespace Training_4
{
    public class Persona
    {
        public string nombre { get; private set; }
        public string telefono { get; private set; }
        public string email { get; private set; }

        public Persona(string nombre, string telefono, string email)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
