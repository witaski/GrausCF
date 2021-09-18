using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperaturaC, temperaturaF;

            Console.Write("Qual a temperatura °C:");
            temperaturaC = Convert.ToDouble(Console.ReadLine());

            temperaturaF = temperaturaC * 1.8 + 32;

            Console.WriteLine($"{temperaturaC}°C = {temperaturaF}F°");
        }
    }
}
