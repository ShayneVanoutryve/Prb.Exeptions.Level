using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening5
    {
        static void Main(string[] args)
        {
            // 1. Vraag om de originele prijs.
            Console.Write("Voer de originele prijs in: ");

            // 2. Lees de invoer.
            string input = Console.ReadLine();

            // 3. Valideer de invoer met een try-catch-blok.
            try
            {
                // We gebruiken Convert.ToDecimal omdat het om geldbedragen gaat
                decimal originalPrice = Convert.ToDecimal(input);

                // 4. Controleer de prijs.
                if (originalPrice < 0)
                {
                    throw new ArgumentException("Fout: De prijs kan niet negatief zijn.");
                }

                // 5. Bereken de korting en de nieuwe prijs.
                // De 'm' achter de getallen geeft aan dat het om een 'decimal' gaat.
                decimal discount = originalPrice * 0.10m;
                decimal newPrice = originalPrice - discount;

                // 6. Toon de resultaten (geformatteerd op 2 decimalen met "0.00").
                Console.WriteLine($"De korting is: {discount:0.00}");
                Console.WriteLine($"De nieuwe prijs is: {newPrice:0.00}");
            }
            catch (FormatException)
            {
                // Vang op wanneer de gebruiker tekst invoert in plaats van een geldig getal
                Console.WriteLine("Fout: Ongeldige invoer. Voer een getal in.");
            }
            catch (ArgumentException ex)
            {
                // Vang de zelf opgeworpen fout op voor de negatieve prijs
                Console.WriteLine(ex.Message);
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
