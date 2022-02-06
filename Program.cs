using System;

namespace numberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {//game info
            gameinfo();
            playerinfo();
            

            int correctNumber;
            var guess=0;

            while (true)
            {
                Random randomNumber = new Random();
                correctNumber = randomNumber.Next(1, 10);

                Console.WriteLine("Hey guess a number between 1 and 10");


                while (guess != correctNumber)
                {

                    if (!int.TryParse(Console.ReadLine(), out guess))
                    {
                        colorchange(ConsoleColor.Red, "Please enter only numbers, try again");

                    
                        continue;

                    }



                    if (guess != correctNumber)
                    {
                        colorchange(ConsoleColor.Red, "Wrong guess. try again");
                       

                    }


                }
                colorchange(ConsoleColor.Green, "Sucess");
              
                Console.WriteLine("Would you like to continue:Yes/No");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "YES")
                {
                    continue;
                }
                else { return; }



            }

        }

        static void gameinfo() {
            string game = "Number Guesser";
            string version = "1.0.0";
            string author = "Ashiya Viswanath";

          Console.ForegroundColor = ConsoleColor.Yellow ;


            Console.WriteLine("Game : {0} Version :{1} by {2}", game, version, author);

            Console.ResetColor();

        }

        static void colorchange(ConsoleColor color,string message) {
            Console.ForegroundColor = color;


            Console.WriteLine(message);

            Console.ResetColor();
        }

        static void playerinfo()
        {
            string userName;
            Console.WriteLine("Enter the player name ");
            userName = Console.ReadLine();
            Console.WriteLine("Hello {0} lets play a game !!", userName);
        }
    }
}