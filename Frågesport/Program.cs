using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {


            RunGame();

            while (true)
            {
                Console.WriteLine("Vill du spela igen, ja eller nej?", Console.ForegroundColor = ConsoleColor.Black);


                string answer = Console.ReadLine();
                if (answer.ToLower() == "ja")
                {
                    RunGame();
                }
                else if (answer.ToLower() == "nej")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ogiltigt svar! \n");
                }


            }



            //Frågesport

            static void RunGame()
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
                    Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Green);
                }

                else if (svar1 != "a")
                {
                    Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Red);
                }

                Console.WriteLine("\n");



                Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ", Console.ForegroundColor = ConsoleColor.Black);
                string vidare = Console.ReadLine();

                while (vidare != "ja" && vidare != "nej")

                {
                    Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ", Console.ForegroundColor = ConsoleColor.Black);
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
                        Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Green);
                    }

                    else if (svar2 != "b")
                    {
                        Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Red);
                    }
                }

                else if (vidare == "nej")
                {
                    System.Environment.Exit(0);
                }



                Console.WriteLine("\n");


                Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ", Console.ForegroundColor = ConsoleColor.Black);
                string vidare2 = Console.ReadLine();

                while (vidare2 != "ja" && vidare2 != "nej")
                {
                    Console.WriteLine("Vill du fortsätta till nästa fråga? \n  \n ja eller nej ", Console.ForegroundColor = ConsoleColor.Black);
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
                        Console.WriteLine("Det var rätt, du har just nu " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Green);
                    }

                    else if (svar3 != "a")
                    {
                        Console.WriteLine("Det var fel, du har just nu " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Red);
                    }
                }

                else if (vidare2 == "nej")
                {
                    System.Environment.Exit(0);
                }

                Console.WriteLine("\n");

                Console.WriteLine("Du är nu färdig med frågesporten och fick " + poäng + " poäng", Console.ForegroundColor = ConsoleColor.Blue);



                Console.WriteLine("\n");
            }





        }
    }
}
