using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening8
    {
        static void Main(string[] args)
        {
            // 1. Vraag om de cijfers & 2. Lees de invoer.
            Console.Write("Voer cijfers in, gescheiden door komma's: ");
            string input = Console.ReadLine();

            // 3. Valideer de invoer (Buitenste try-catch).
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new Exception("Fout: Invoer mag niet leeg zijn.");
                }

                // 4. Splits de invoer op basis van komma's.
                string[] numbers = input.Split(',');

                double totalSum = 0;
                int amountOfNumbers = 0;

                // 5. Loop door de getallen.
                foreach (string number in numbers)
                {
                    // Verwijdert eventuele spaties rondom het getal (bijv. "7, 8" -> "8")
                    string cleanedNumber = number.Trim();

                    // 6. Converteer en tel op (Binnenste try-catch).
                    try
                    {
                        double cijfer = Convert.ToDouble(cleanedNumber);
                        totalSum += cijfer;
                        amountOfNumbers++;
                    }
                    catch (FormatException)
                    {
                        // Toon de specifieke foutmelding en stop direct met het programma (return)
                        Console.WriteLine($"Fout: '{cleanedNumber}' is geen geldig getal.");
                        Console.ReadLine(); // Houdt de console open voor het sluiten
                        return;
                    }
                }

                // 7. Bereken het gemiddelde & 8. Toon het resultaat.
                if (amountOfNumbers > 0)
                {
                    double average = totalSum / amountOfNumbers;
                    Console.WriteLine($"Het gemiddelde is: {average}");
                }
            }
            catch (Exception ex)
            {
                // Vangt de algemene exception op voor lege invoer
                Console.WriteLine(ex.Message);
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
