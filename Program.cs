using System;

namespace Exerc_cio_Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            Double AlcMax, AltMax, A, Vi, Rad, g;

            
            Console.WriteLine("Projetil");
        
            Console.WriteLine();
            
            Console.WriteLine("Vamos calcular o alcance e a altura maxima de um projetil");

            Console.WriteLine("Coloque a velocidade inicial, em m/s, do projetil:");

            Vi = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine();

            Console.WriteLine("Coloque a baixo o ângulo do projetil:");
            A = Convert.ToDouble(Console.ReadLine());

            g = 9.80665;
            Rad = A *(Math.PI /180);
            AlcMax = (Math.Pow(Vi, 2)) * Math.Sin(2 * Rad) /g;

            Console.WriteLine();

            Console.WriteLine($"O alcance maximo do projetil é: {AlcMax}");

            Console.WriteLine();

            AltMax = Math.Pow((Vi * Math.Sin(Rad)), 2) /(2 * g);
            Console.WriteLine($"A altura maxima do projetil é: {AltMax}");
        }
    }
}
