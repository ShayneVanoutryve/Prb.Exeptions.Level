using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening14
    {
        static void Main(string[] args)
        {
            // 1. Vraag om de toegangscode.
            Console.Write("Voer de 4-cijferige toegangscode in: ");

            // 2. Lees de invoer.
            string inputCode = Console.ReadLine();

            // 3. Start een try-blok om de validatie uit te voeren.
            try
            {
                // 4. Controleer de lengte.
                if (inputCode.Length != 4)
                {
                    throw new ArgumentException("Fout: De code moet exact 4 cijfers lang zijn.");
                }

                // 5. Controleer op cijfers. 
                // Dit gooit automatisch een FormatException als er letters of symbolen in zitten.
                int parsedCode = int.Parse(inputCode);

                // 7. Toon succesbericht als er geen fouten zijn.
                Console.WriteLine("Toegang verleend.");
            }
            // 6. Vang de fouten afzonderlijk op en toon de juiste foutmelding.
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Fout: De code mag alleen cijfers bevatten.");
            }
            finally
            {
                // 8. Gebruik een finally-blok.
                Console.WriteLine("Validatiepoging beëindigd.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
