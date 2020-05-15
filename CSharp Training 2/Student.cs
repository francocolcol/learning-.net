namespace CSharp_Training_2
{
    public class Student
    {
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public int legajo { get; private set; }

        public Student(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
    }
}
