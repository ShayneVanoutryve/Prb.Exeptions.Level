using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening12
    {
        static void Main(string[] args)
        {
            // 5. Roep de methode aan in Main.
            // We maken een geldige array aan met de getallen 1 tot en met 10 (som is 55)
            int[] validArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // TEST 1: Aanroep met een geldige array
            try
            {
                int sum = CalculateSum(validArray);
                // 7. Toon het resultaat.
                Console.WriteLine($"De som van de array is: {sum}");
            }
            catch (ArgumentNullException ex)
            {
                // De handmatige foutmelding die we in de exception hebben gestopt (ex.ParamName bevat "array")
                Console.WriteLine($"Fout: De array mag niet null zijn.");
            }

            Console.WriteLine(); // Witregel voor overzichtelijkheid in de console

            // TEST 2: Aanroep met een null-array om de foutafhandeling te testen.
            try
            {
                int[] invalidArray = null;
                int sum = CalculateSum(invalidArray);
                Console.WriteLine($"De som van de array is: {sum}");
            }
            catch (ArgumentNullException)
            {
                // 6. Test met null. Deze catch zal nu getriggerd worden.
                Console.WriteLine("Fout: De array mag niet null zijn.");
            }

            // Houdt de console open
            Console.ReadLine();
        }

        // 1. Maak een methode BerekenSom.
        public static int CalculateSum(int[] array)
        {
            // 2. Controleer op null.
            if (array == null)
            {
                // We werpen bewust de exception op met de parameternaam en een specifieke boodschap
                throw new ArgumentNullException("array", "De array mag niet null zijn.");
            }

            // 3. Bereken de som.
            int sum = 0;
            foreach (int getal in array)
            {
                sum += getal;
            }

            // 4. Retourneer de som.
            return sum;
        }
    }
}
