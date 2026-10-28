using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening19
    {
        static void Main(string[] args)
        {
            // 1. Definieer het geluksgetal als een constante integer.
            const int LuckyNumber = 42;

            // 2. Vraag de gebruiker om te raden.
            Console.Write("Raad het geluksgetal (1-100): ");

            // 3. Lees de invoer.
            string inputGuess = Console.ReadLine();

            // 4. Valideer de invoer met een try-catch-blok.
            try
            {
                // 5. Converteer naar getal.
                int userGuess = Convert.ToInt32(inputGuess);

                // 6. Controleer het bereik.
                if (userGuess < 1 || userGuess > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(userGuess), "Fout: Het getal moet tussen 1 en 100 liggen.");
                }

                // 7. Vergelijk de getallen.
                if (userGuess == LuckyNumber)
                {
                    Console.WriteLine("Gefeliciteerd! U heeft het geluksgetal geraden!");
                }
                else
                {
                    Console.WriteLine("Helaas, dat is niet correct.");
                }
            }
            // 8. Vang de fouten op.
            catch (FormatException)
            {
                Console.WriteLine("Fout: Ongeldige invoer.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Toon de specifieke boodschap die we hierboven hebben meegegeven
                Console.WriteLine(ex.Message);
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
