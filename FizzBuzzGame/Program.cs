using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new FizzBuzz();

            Console.WriteLine("To Twoja szansa zagrać w grę FizzBuzz.");
            Console.WriteLine("Let the game begin!");
            
            while (true)
            {
                Console.WriteLine("Wprowadź liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                    Console.WriteLine(game.FizzOrBuzz(number));
                else
                    Console.WriteLine("Wprowadzono nieprawidłowe dane.");

                Console.WriteLine("Czy chcesz zagrać ponownie [t/n]?");
                var keepPlaying = Console.ReadLine().ToLower();
                try
                {
                    if (keepPlaying == "t")
                        continue;
                    else if (keepPlaying == "n")
                    {
                        Console.WriteLine("Gra zakończona");
                        break;
                    }
                    else
                        throw new Exception("Nie wiem co zrobić");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wprowadziłeś nieprawidłową wartość");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Gra została przerwana");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
