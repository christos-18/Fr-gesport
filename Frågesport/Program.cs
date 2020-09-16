using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int poäng = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //FRÅGA1



            Console.WriteLine("vad heter jag?: \n \n a) Christos \n b) Alexander \n c) Axel ");

            string svar1 = Console.ReadLine();


            while (svar1 != "a" && svar1 != "b" && svar1 != "c")

            {
                Console.WriteLine("vad heter jag?: \n \n a) Christos \n b) Alexander \n c) Axel ");

                svar1 = Console.ReadLine();

            }

            Console.WriteLine("\n");

            if (svar1 == "a")
            {
                poäng++;
                Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng");
            }

            else if (svar1 != "a")
            {
                Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng");
            }

            Console.WriteLine("\n");



            Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ");
            string vidare = Console.ReadLine();

            while (vidare != "ja" && vidare != "nej")

            {
                Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ");
                vidare = Console.ReadLine();
            }

            Console.WriteLine("\n");

            if (vidare == "ja")
            {
                //FRÅGA 2

                Console.WriteLine("Hur gammal är jag?: \n \n a) 16 \n b) 17 \n c) 18 ");

                string svar2 = Console.ReadLine();


                while (svar2 != "a" && svar2 != "b" && svar2 != "c")

                {
                    Console.WriteLine("Hur gammal är jag?: \n \n a) 16 \n b) 17 \n c) 18 ");

                    svar2 = Console.ReadLine();

                }

                Console.WriteLine("\n");

                if (svar2 == "b")
                {
                    poäng++;
                    Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng");
                }

                else if (svar2 != "b")
                {
                    Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng");
                }
            }

            else if (vidare == "nej")
            {
                //exit
            }



            Console.WriteLine("\n");


            Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ");
            string vidare2 = Console.ReadLine();

            while (vidare2 != "ja" && vidare2 != "nej")
            {
                Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ");
                vidare2 = Console.ReadLine();
            }

            Console.WriteLine("\n");

            if (vidare2 == "ja")
            {
                //FRÅGA 3

                Console.WriteLine("Vilken är min favoritfärg?: \n \n a) Blå \n b) Grön \n c) Gul ");

                string svar3 = Console.ReadLine();


                while (svar3 != "a" && svar3 != "b" && svar3 != "c")

                {
                    Console.WriteLine("Vilken är min favoritfärg?: \n \n a) Blå \n b) Grön \n c) Gul ");

                    svar3 = Console.ReadLine();

                }

                Console.WriteLine("\n");

                if (svar3 == "a")
                {
                    poäng++;
                    Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng");
                }

                else if (svar3 != "a")
                {
                    Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng");
                }
            }

            else if (vidare2 == "nej")
            {
                //exit
            }

            Console.WriteLine("\n");

            Console.WriteLine("Du är nu färdig med frågesporten och fick " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Green);

            Console.ReadLine();

















        }
    }
}
