using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int poäng = 0;



            Console.WriteLine("vad heter jag?");

            string svar1 = Console.ReadLine();


            while (svar1 != "a" && svar1 != "b" && svar1 != "c")


            {
                Console.WriteLine("vad heter jag");

                svar1 = Console.ReadLine();

            }

            if (svar1 == "b")
            {
                poäng++;
                Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng");
            }

            else if (svar1 != "b")
            {
                Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng");
            }






            Console.ReadLine();




        }
    }
}
