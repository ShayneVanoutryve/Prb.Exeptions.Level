using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening9
    {
        static void Main(string[] args)
        {
            // 1. Maak een Dictionary met kleuren (KleurNaam -> HexCode).
            Dictionary<string, string> colors = new Dictionary<string, string>()
            {
                { "Rood", "#FF0000" },
                { "Groen", "#00FF00" },
                { "Blauw", "#0000FF" }
            };

            // 2. Toon de beschikbare kleuren.
            // string.Join voegt de sleutels (Keys) netjes samen met een komma en spatie ertussen.
            Console.WriteLine($"Beschikbare kleuren: {string.Join(", ", colors.Keys)}");

            // 3. Vraag de gebruiker om een kleur te kiezen & 4. Lees de invoer.
            Console.Write("Kies een kleur: ");
            string input = Console.ReadLine();

            // 5. Zoek de kleur binnen een try-catch-blok.
            try
            {
                // Als de sleutel (invoer) niet bestaat, gooit deze regel automatisch een KeyNotFoundException.
                // Let op: Dit is hoofdlettergevoelig ("groen" is dus niet hetzelfde als "Groen").
                string hexCode = colors[input];

                // 7. Toon het resultaat (Succes).
                Console.WriteLine($"U heeft {input} gekozen. (Hex-code: {hexCode})");
            }
            catch (KeyNotFoundException)
            {
                // 6. Vang de fout op als de ingevoerde kleur niet in de Dictionary staat.
                Console.WriteLine($"Fout: De kleur '{input}' is niet beschikbaar.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
