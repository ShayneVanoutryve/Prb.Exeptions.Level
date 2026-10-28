using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening18
    {
        static void Main(string[] args)
        {
            // 1. Vraag om het e-mailadres.
            Console.Write("Voer uw e-mailadres in: ");

            // 2. Lees de invoer.
            string inputEmail = Console.ReadLine();

            // 3. Valideer het e-mailadres binnen een try-catch-blok.
            try
            {
                // 4. Controleer op "@". 
                // We gebruiken het uitroepteken (!) om te controleren of het NIET waar is (Does NOT contain).
                if (!inputEmail.Contains("@"))
                {
                    throw new FormatException("Fout: Ongeldig e-mailadres formaat. Het '@' teken ontbreekt.");
                }

                // 6. Toon succesbericht als er geen fout is.
                Console.WriteLine("E-mailadres is geldig.");
            }
            catch (FormatException ex)
            {
                // 5. Vang de fout op en toon de Message.
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 7. Gebruik een finally-blok. Dit voert altijd uit.
                Console.WriteLine("E-mail validatie uitgevoerd.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
