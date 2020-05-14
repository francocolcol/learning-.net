namespace CSharp_Training_2
{
    public class Circulo
    {
        private double radio, diametro, perimetro;
        private static double pi;

        static Circulo()
        {
            pi = 3.14;
        }

        public Circulo (double radio)
        {
            this.radio = radio;
            diametro = Calculadora.Multiplicar(radio,2);
            perimetro = Calculadora.Multiplicar(diametro, pi);
        }

        public double GetRadio()
        {
            return radio;
        }

        public void SetRadio(int radio)
        {
            this.radio = radio;
        }
        public double GetDiametro()
        {
            return diametro;
        }
        public double GetPerimetro()
        {
            return perimetro;
        }
    }
}
