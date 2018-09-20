using System;

namespace coinflip
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Global Variables
            int coin;
            string userGuess;
            string coinDescription = "Tails";
            Random rng = new Random();



            // Query the user
            Console.Write("Enter your guess Heads or Tails (H or T): ");
            userGuess = Console.ReadLine();



            // Get a random number for the coin flip
            coin = rng.Next(0, 2);



            // Call the names of the coin
            if (coin == 1) 
            {
                coinDescription = "Heads";
            } 
            else 
            {
                coinDescription = "Tails";
            }


            // Flip the coin
            if ((coin == 0 && userGuess == "T") || (coin == 1 && userGuess == "H"))
            {
               
               Console.WriteLine("The coin flip was {0}, you lose less", coinDescription);
                
            } 
            else 
            {
 
                Console.WriteLine("The coins flip was {0}, you lose", coinDescription);

            }

            Console.ReadLine();

        }
    }
}