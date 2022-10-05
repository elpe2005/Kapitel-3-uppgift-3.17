using System;
namespace Uppgift313
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej jag är en miniräknare som kan räkna två tal. Var snäll och skriv två tal.");
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett räknesätt.\n1.addition\n2.subtraktion\n3.multiplikation\n4.division");
            int välj = int.Parse(Console.ReadLine());   
            switch (välj)
            {
                case 1:
                    Console.WriteLine(n1 + n2);
                    break;
                case 2:
                    Console.WriteLine(n1 - n2);
                    break ;
                case 3:
                    Console.WriteLine(n1 * n2);
                    break;
                case 4:
                    Console.WriteLine(n1 / n2);
                    break;
                default:
                    break;
            }
        }
    }
}