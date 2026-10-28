using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    class Oefening3
    {
        static void Main(string[] args)
        {
            // 1. Vraag om de temperatuur in Celsius.
            Console.Write("Voer de temperatuur in Celsius in: ");

            // 2. Lees de invoer.
            string input = Console.ReadLine();

            // 3. Converteer de invoer met een try-catch-blok.
            try
            {
                // We gebruiken Convert.ToDouble omdat temperaturen kommagetallen kunnen zijn
                double celsius = Convert.ToDouble(input);

                // 4. Bereken de temperatuur in Fahrenheit.
                // Let op: We schrijven 9.0 / 5.0 om te zorgen dat C# een nauwkeurige double-deling doet.
                double fahrenheit = (celsius * 9.0 / 5.0) + 32;

                // 5. Toon het resultaat.
                Console.WriteLine($"De temperatuur in Fahrenheit is: {fahrenheit}");
            }
            catch (FormatException)
            {
                // Vang op wanneer de gebruiker tekst invult in plaats van een getal
                Console.WriteLine("Fout: Ongeldige invoer. Voer een getal in.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
