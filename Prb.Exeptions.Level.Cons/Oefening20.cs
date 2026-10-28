using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening20
    {
        static void Main(string[] args)
        {
            // 1. Vraag om een bestandsnaam.
            Console.Write("Voer een bestandsnaam in: ");

            // 2. Lees de invoer.
            string inputFileName = Console.ReadLine();

            // 3. Valideer de naam binnen een try-catch-blok.
            try
            {
                // 4. Controleer op spaties.
                if (inputFileName.Contains(" "))
                {
                    throw new ArgumentException("Fout: Bestandsnaam mag geen spaties bevatten.");
                }

                // 6. Toon succesbericht als er geen fout is.
                Console.WriteLine("Bestandsnaam is geldig.");
            }
            catch (ArgumentException ex)
            {
                // 5. Vang de fout op en toon de Message.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 7. Gebruik een finally-blok. Dit voert altijd uit.
                Console.WriteLine("Validatie voltooid.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
