using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening17
    {
        static void Main(string[] args)
        {
            // 1. Vraag om een tekst.
            Console.Write("Voer een tekst in: ");

            // 2. Lees de invoer.
            string userInput = Console.ReadLine();

            // 3. Valideer de invoer met een try-catch-blok.
            try
            {
                // Controleer of de string leeg of null is
                if (string.IsNullOrEmpty(userInput))
                {
                    throw new ArgumentException("Fout: Invoer mag niet leeg zijn.");
                }

                // 5. Roep de omdraai-methode aan vanuit het try-blok.
                string reversedResult = ReverseString(userInput);

                // 7. Toon het resultaat (Succes).
                Console.WriteLine(reversedResult);
            }
            // 6. Vang de fout op.
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Houdt de console open
            Console.ReadLine();
        }

        // 4. Draai de string om. Maak een methode die een string als input neemt.
        public static string ReverseString(string text)
        {
            // Converteer de string naar een char[] array
            char[] charArray = text.ToCharArray();

            // Gebruik de ingebouwde Array.Reverse om de karakters om te draaien
            Array.Reverse(charArray);

            // Maak er dan weer een nieuwe string van en retourneer deze
            return new string(charArray);
        }
    }
}
