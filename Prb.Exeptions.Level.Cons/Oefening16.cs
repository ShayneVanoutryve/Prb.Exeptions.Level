using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening16
    {
        static void Main(string[] args)
        {
            // 1. Definieer de ticketprijs als een constante decimal.
            const decimal TicketPrice = 25.00m;

            Console.WriteLine($"Prijs per ticket: €{TicketPrice:0.00}");

            // 2. Vraag om het aantal personen.
            Console.Write("Voer het aantal personen in: ");

            // 3. Lees de invoer.
            string inputPeople = Console.ReadLine();

            // 4. Valideer de invoer met een try-catch-blok.
            try
            {
                // 5. Converteer naar getal.
                int numberOfPeople = Convert.ToInt32(inputPeople);

                // 6. Controleer op positiviteit.
                if (numberOfPeople < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(numberOfPeople), "Fout: Aantal personen kan niet negatief zijn.");
                }
                if (numberOfPeople == 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(numberOfPeople), "Fout: Ongeldig aantal. Voer een positief getal in.");
                }

                // 8. Bereken de totale kosten.
                decimal totalCost = numberOfPeople * TicketPrice;

                // 9. Toon het resultaat (geformatteerd als geldbedrag).
                Console.WriteLine($"Totale kosten: €{totalCost:0.00}");
            }
            // 7. Vang de fouten op.
            catch (FormatException)
            {
                Console.WriteLine("Fout: Ongeldig aantal. Voer een positief getal in.");
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
