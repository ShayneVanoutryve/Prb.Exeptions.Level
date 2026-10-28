using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening7
    {
        static void Main(string[] args)
        {
            // 1. Vraag de gebruiker om een wachtwoord.
            Console.Write("Voer uw wachtwoord in: ");

            // 2. Lees de invoer.
            string password = Console.ReadLine();

            // 3. Controleer de lengte binnen een try-catch-blok.
            try
            {
                // Controleer of de lengte van de string kleiner is dan 8 tekens
                if (password.Length < 8)
                {
                    // Gooi een ArgumentException met de specifieke foutboodschap
                    throw new ArgumentException("Fout: Het wachtwoord moet minimaal 8 tekens lang zijn.");
                }

                // 5. Toon de boodschap (Succes).
                Console.WriteLine("Wachtwoord geaccepteerd.");
            }
            catch (ArgumentException ex)
            {
                // 4. Vang de fout op en toon de boodschap van de exception
                Console.WriteLine(ex.Message);
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
