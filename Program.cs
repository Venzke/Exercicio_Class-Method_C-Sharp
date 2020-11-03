using System;

namespace Exercicio_Class_Metod
{
    class Program
    {
        static void Main()
        {
            Retangulo x;

            x = new Retangulo();

            Console.Write("Insira o 1° atributo: ");
            x.A = double.Parse(Console.ReadLine());

            Console.Write("Insira o 2° atributo: ");
            x.B = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double Area = x.Calc_Area(); //Area recebendo o resultado do processamento do método Calc_Area da classe Retangulo.
            Console.WriteLine("Area = {0:F2}", Area);

            double Perimetro = x.Calc_Perimetro();
            Console.WriteLine("Perimetro = {0:F2}", Perimetro);

            double Diagonal = x.Calc_Diagonal();
            Console.WriteLine("Diagonal = {0:F2}", Diagonal);

            Console.Read();
        }
    }
}
