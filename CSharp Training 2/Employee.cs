namespace CSharp_Training_2
{
    public class Employee
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public string email { get; private set; }

        public Employee(string nombre, string apellido, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }
    }

}
