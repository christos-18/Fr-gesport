using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            string fråga1 = "";

            while (fråga1 != "a" && fråga1 != "b" && fråga1 != "c")


            {
                Console.WriteLine("vad heter jag");
                fråga1 = Console.ReadLine();
            }

            if (fråga1 = "b")
            {
                Console.WriteLine("Det var rätt! Du har just nu "x" poäng");
            }

            Console.ReadLine();

             else if (fråga1 != "b")

            {
                Console.WriteLine("Det var fel! Du har just nu poäng);
            }

            Console.ReadLine();




        }
    }
}
