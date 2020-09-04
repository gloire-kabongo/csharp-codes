using System;

namespace ComplexExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Complex(12F, 1);
            var b = new Complex(1F, 1);

            var c = a + b;
            var d = a + 5;
            d = 6 + a;
        }
    }
}
