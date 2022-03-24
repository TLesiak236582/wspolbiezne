using System;

namespace Współbieżne
{
    public class Program
    {

        public static int multiplication(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
           Console.WriteLine("Program wykona mnożenie dwóch liczb wprowadzonych przez użytkownika")
            Console.WriteLine("Podaj pierwsza liczbe:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe:");
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("Wynik mnozenia: " + multiplication(x, y));
        }
    }
}
