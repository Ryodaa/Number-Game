using System;

namespace Number_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int programmLoop = 1;
            while (programmLoop > 0)

            {

                Random random = new System.Random();

                int userGuess = 0;
                int numberToGuess = random.Next(1, 101);

                Console.WriteLine("Guess a number between 1 and 100: ");

                while (userGuess != numberToGuess)
                {
                    int.TryParse(Console.ReadLine(), out userGuess);

                    if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Wrong number buddy! It's lower than {0} try again. ", userGuess);
                    }
                    else if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Wrong number buddy! It's higher than {0} try again. ", userGuess);
                    }
                    else if (userGuess == numberToGuess)
                    {
                        Console.WriteLine("That's right! The number was {0}. You win!", numberToGuess);
                    }
                }
            }
          
        }
    }
}
