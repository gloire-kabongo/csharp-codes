namespace ComplexExemple
{
    public class Complex
    {
        public Complex(float real, int imaginaire)
        {
            Real = real;
            Imaginaire = imaginaire;
        }

        public float Real { get; private set; }
        public int Imaginaire { get; private set; }

        public static Complex operator +(Complex a, Complex b) =>
            new Complex(a.Real + b.Real,
                a.Imaginaire + b.Imaginaire);

        public static Complex operator +(Complex a, float b) =>
            new Complex(a.Real + b, a.Imaginaire);

        public static Complex operator +(float a, Complex b) =>
            new Complex(b.Real + a, b.Imaginaire);
    }
}