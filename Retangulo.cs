using System;

namespace Exercicio_Class_Metod
{
    class Retangulo
    {
        public double A, B;

        public double Calc_Area()
        {
            return A * B;
        }

        public double Calc_Perimetro()
        {
            return 2 * ( A + B );
        }

        public double Calc_Diagonal()
        {
            return Math.Sqrt(A * A + B * B);
        }
    }
}
