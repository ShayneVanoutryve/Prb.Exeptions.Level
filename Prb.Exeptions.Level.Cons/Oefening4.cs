using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening4
    {
        private static void Main(string[] args)
        {
            // 1. Maak een array met boektitels.
            string[] books = {
                "Harry Potter",
                "1984",
                "The Lord of the Rings",
                "To Kill a Mockingbird",
                "The Great Gatsby"
            };

            // 2. Vraag de gebruiker om een index & 3. Lees de invoer.
            Console.Write("Geef een indexnummer (0-4): ");
            string input = Console.ReadLine();

            // 4. Valideer de invoer (Buitenste try-catch voor het formaat).
            try
            {
                int index = Convert.ToInt32(input);

                // 5. Zoek het boek (Binnenste try-catch voor de array grenzen).
                try
                {
                    // Haal het boek op. Dit triggert een exception als de index bv. 5 of -1 is.
                    string chosenBook = books[index];

                    // 6. Toon het resultaat.
                    Console.WriteLine($"Het boek op index {index} is: {chosenBook}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Fout: Index is buiten de grenzen van de lijst.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fout: Ongeldige invoer. Voer een geheel getal in.");
            }
            finally
            {
                // 7. Gebruik een finally-blok. Dit wordt ALTIJD uitgevoerd.
                Console.WriteLine("Zoekopdracht voltooid.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
