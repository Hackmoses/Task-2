using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int top = 0;
            int guessLimit = 0;

            Console.Write("Welcome, Please select your difficulty level. \n1 for Easy. \n2 for Intermediate. \n3 for Hard :");
            int level = int.Parse(Console.ReadLine());

            if (level == 1)
            {
                top = 10;
                guessLimit = 6;
                Console.WriteLine("You have selected Easy and you have 6 trials");
                Console.WriteLine("Guess a number between 1 and 10");
            }

            if (level == 2)
            {
                top = 20;
                guessLimit = 4;
                Console.WriteLine("You have selected Intermediate and you have 4 trials");
                Console.WriteLine("Guess a number between 1 and 20");
            }
            if (level == 3)
            {
                top = 50;
                guessLimit = 3;
                Console.WriteLine("You have selected Hard and you have 3 trials");
                Console.WriteLine("Guess a number between 1 and 50");
            }

            int randomNumber = random.Next(1, top);

           
            int guess;
            bool outOfGuess = false;


            Console.Write("Try your guess: ");
            while (outOfGuess == false)
            {   
                    
                    guess = int.Parse(Console.ReadLine());
                    guessLimit--;

                if (guess != randomNumber && guessLimit == 0)
                {
                    Console.WriteLine("You guesses are wrong");
                    outOfGuess = true;
                    
                  
                } else if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulation, You have WON");
                    break;
                } else if (guess < randomNumber)
                {
                    Console.Write("Wrong Try again! Number too small: ");
                 
                }else if (guess > randomNumber)
                {
                    Console.Write("Wrong Try again! Number too big: ");
                   
                }
            }


            if (outOfGuess)
            {
                Console.WriteLine("Sorry you are out of guess, YOU LOSS!");
                
            } else
            {
                Console.WriteLine("Congratulation, Champion");
            }
       
        }
    }
}
