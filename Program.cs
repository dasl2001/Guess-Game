using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace uppgift._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string play = "JA";
            while (play == "JA")
            {
                int numberOfGuesses = 1;
                Random random = new Random();
                int randomNumber = random.Next(1, 100);
                Console.WriteLine("Gissa ett tal mellan 1 och 100. ");
                bool checkInput = true;
                while (checkInput == true)
                {
                    Console.Write($"Gissningar {numberOfGuesses}: ");
                    if (int.TryParse(Console.ReadLine(), out int userNumber))
                    {
                        if ((userNumber > 1 && userNumber <= 100))
                        {
                            if (userNumber == randomNumber)
                            {
                                Console.WriteLine($"Rätt! Du gissade rätt på {numberOfGuesses} Försök");
                                checkInput = false;

                            }
                            else if (userNumber < randomNumber)
                            {
                                Console.WriteLine("Talet är större");
                                numberOfGuesses++;
                            }
                            else if (userNumber > randomNumber)
                            {
                                Console.WriteLine("Talet är Mindre");
                                numberOfGuesses++;
                            }       
                        }
                        else
                        {
                            Console.WriteLine("Du skrev inte ett tal mellan 1 och 100. Försök igen!");
                            checkInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Du kan bara skriva ett tal med siffror. Försök igen!");
                        checkInput = true;
                    }
                }
                string playAgain = "J";
                while (playAgain == "J")
                {
                    Console.Write("Vill du spela igen (J/N): ");
                    string playAgainAnwser = Console.ReadLine();
                    if (playAgainAnwser == "J")
                    {
                        Console.Clear();
                        playAgain = "N";
                    }
                    else if (playAgainAnwser == "N")
                    {
                        playAgain = "N";
                        play = "Nej";
                    }
                }
            }
        }
    }
}
