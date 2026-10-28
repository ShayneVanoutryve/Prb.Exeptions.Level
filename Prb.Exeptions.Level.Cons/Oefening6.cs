using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening6
    {
        static void Main(string[] args)
        {
            // 1. Vraag de gebruiker om een zin.
            Console.Write("Voer een zin in: ");

            // 2. Lees de invoer.
            string input = Console.ReadLine();

            // 3. Controleer op lege invoer binnen een try-catch-blok.
            try
            {
                // IsNullOrWhiteSpace controleert op null, lege strings ("") en strings met alleen spaties ("   ")
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("invoer", "Fout: De zin mag niet leeg zijn.");
                }

                // 4. Tel de woorden.
                // We splitsen de string op elke spatie. Dit levert een array van woorden op.
                // StringSplitOptions.RemoveEmptyEntries zorgt ervoor dat extra spaties achter elkaar 
                // (bijv. "Dit  is  een  test") niet als extra lege 'woorden' worden meegeteld.
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int amountOfWords = words.Length;

                // 5. Toon het resultaat.
                Console.WriteLine($"De zin bevat {amountOfWords} woorden.");
            }
            catch (ArgumentNullException ex)
            {
                // Vang de zelf opgeworpen fout op wanneer de invoer leeg is
                // ex.ParamName bevat de naam van de parameter, ex.Message bevat de hele boodschap.
                // Omdat de standaard message extra dotnet-tekst bevat, tonen we hier een duidelijke eigen tekst:
                Console.WriteLine("Fout: De zin mag niet leeg zijn.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
