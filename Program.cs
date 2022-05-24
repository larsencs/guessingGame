using System;

namespace Guessing
{
    class GuessingGame
    {

        public static void Main(string[] args)
        {
            Greeting();
            PlayGame(DifficultyLevel());
        }

        public static void Greeting()
        {
            Console.WriteLine("Guessing Random Numbers!");
            Console.WriteLine("------------------------");
            Console.WriteLine();
         
        }

        public static int DifficultyLevel()
        {
            Console.WriteLine("Select a difficulty level:");
            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            Console.WriteLine("4) Cheater");
            Console.Write("Enter choice: ");
            int choice;
            bool checkType = int.TryParse(Console.ReadLine(), out choice);

            while(!checkType)
            {
                Console.WriteLine();
                Console.WriteLine("Entry is not an integer.");
                Console.WriteLine("Select a difficulty level:");
                Console.WriteLine("1) Easy");
                Console.WriteLine("2) Medium");
                Console.WriteLine("3) Hard");
                Console.WriteLine("4) Cheater");
                Console.Write("Enter choice: ");

            checkType = int.TryParse(Console.ReadLine(), out choice);
            }

            switch(choice)
            {
                case 1:
                    return 8;
                case 2:
                    return 6;
                case 3:
                    return 4;
                case 4:
                    return 0;
                default:
                    while(choice > 4 || choice < 0)
                    {
                        Console.WriteLine("Select a difficulty level:");
                        Console.WriteLine("1) Easy");
                        Console.WriteLine("2) Medium");
                        Console.WriteLine("3) Hard");
                        Console.WriteLine("4) Cheater");
                        Console.Write("Enter choice: ");
                        choice = int.Parse(Console.ReadLine());
                    }
                    break;
            }
            return choice;

        }
        public static void PlayGame(int choice)
        {
            int secretNumber = GetSecretNumber();
            int userGuess;
 
            int index = 0;

            if(choice == 0)
            {
                while(true){

                Console.Write("Enter guess (1-100): ");
                string answer = Console.ReadLine();

                bool checkType =  int.TryParse(answer, out userGuess);
                    
                while(!checkType)
                {
                    Console.WriteLine();
                    Console.WriteLine("Entry is not an integer.");
                    Console.Write("Enter guess (1-100): ");
                    answer = Console.ReadLine();
                    checkType =  int.TryParse(answer, out userGuess);

                }
                
                if(userGuess == secretNumber)
                {
                    Console.WriteLine($"Guess {index+1}: you did it!");
                    break;
                }
                else if(userGuess > secretNumber)
                {
                    Console.WriteLine($"Guess {index+1}: Your guess is too high!");
                }
                else if(userGuess < secretNumber)
                {  
                    Console.WriteLine($"Guess {index+1}: Your guess is too low!");
                }
                index++;
            }



            }

            while(index < choice){

                Console.Write("Enter guess (1-100): ");
                string answer = Console.ReadLine();

                bool checkType =  int.TryParse(answer, out userGuess);

                while(!checkType)
                {
                    Console.WriteLine();
                    Console.WriteLine("Entry is not an integer.");
                    Console.Write("Enter guess (1-100): ");
                    answer = Console.ReadLine();
                    checkType =  int.TryParse(answer, out userGuess);

                } 

                if(userGuess == secretNumber)
                {
                    Console.WriteLine($"Guess {index+1}: you did it!");
                    break;
                }
                else if(userGuess > secretNumber)
                {
                    Console.WriteLine($"Guess {index+1}: Your guess is too high!");
                    Console.WriteLine($"You have {choice-index-1} remaining");
                }
                else if(userGuess < secretNumber)
                {  
                    Console.WriteLine($"Guess {index+1}: Your guess is too low!");
                    Console.WriteLine($"You have {choice-index-1} remaining");
                }
                index++;
            }


        }

        public static int GetSecretNumber()
        {
            Random r = new Random();
            int secretNumber = r.Next(1, 100);

            return secretNumber;
        }
    }
}