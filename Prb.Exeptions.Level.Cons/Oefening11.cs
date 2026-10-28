using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening11
    {
        static void Main(string[] args)
        {
            // 1. Vraag de gebruiker om een datum.
            Console.Write("Voer een datum in (dd-mm-jjjj): ");

            // 2. Lees de invoer.
            string input = Console.ReadLine();

            // 3. Valideer de datum binnen een try-catch-blok.
            try
            {
                // We gebruiken "dd-MM-yyyy". Let op: MM (hoofdletters) staat voor maanden, mm (kleine letters) staat voor minuten.
                // CultureInfo.InvariantCulture zorgt ervoor dat de datumcontrole onafhankelijk is van lokale pc-instellingen.
                DateTime validDatum = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                // 5. Toon het resultaat (Succes).
                // We gebruiken de variabele 'invoer' om exact te tonen wat de gebruiker typte, 
                // of we kunnen geldigeDatum.ToString("dd-MM-yyyy") gebruiken.
                Console.WriteLine($"De datum {input} is geldig.");
            }
            catch (FormatException)
            {
                // 4. Vang de fout op. Deze exception treedt op bij een fout formaat (bv. 'vandaag') 
                // óf bij een onbestaande datum (bv. 32-12-2023).
                Console.WriteLine($"Fout: '{input}' is geen geldige datum.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
