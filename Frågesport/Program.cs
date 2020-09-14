using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            string fråga1 = "";

            while (fråga1 != "a" && fråga1 != "b" && fråga1 != "c")


            {
                Console.WriteLine("vad heter jag");
                fråga1 = Console.ReadLine();
            }

            string fråga2 = Console.ReadLine();

            if (fråga2 = "B")
            {
                Console.WriteLine("Det var rätt! Du har just nu x poäng");
            }


            else if (fråga2 != "B")
            {
                Console.WriteLine("Det var fel! Du har just nu x poäng");
            }







        }
    }
}
