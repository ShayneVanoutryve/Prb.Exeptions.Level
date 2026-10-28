using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening10
    {
        static void Main(string[] args)
        {
            // 1. Vraag om productnaam, prijs en aantal & 2. Lees de invoer.
            Console.Write("Voer de productnaam in: ");
            string productName = Console.ReadLine();

            Console.Write("Voer de prijs per stuk in: ");
            string priceInput = Console.ReadLine();

            Console.Write("Voer het aantal in: ");
            string amountInput = Console.ReadLine();

            // Variabelen buiten de try-blokken declareren zodat ze daarna ook bereikbaar zijn
            decimal price = 0;
            int amount = 0;
            bool inputIsValid = true;

            try
            {
                // 3. Valideer de prijs.
                try
                {
                    price = Convert.ToDecimal(priceInput);
                    if (price < 0)
                    {
                        throw new ArgumentOutOfRangeException("prijs", "Fout: Prijs kan niet negatief zijn.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fout: Ongeldige invoer voor prijs.");
                    inputIsValid = false;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    // ex.Message bevat ook de parameternaam, dus we tonen hier de heldere boodschap
                    Console.WriteLine("Fout: Prijs kan niet negatief zijn.");
                    inputIsValid = false;
                }

                // Als de prijs al ongeldig was, hoeven we het aantal niet meer te valideren/overschrijven
                if (inputIsValid)
                {
                    // 4. Valideer het aantal.
                    try
                    {
                        amount = Convert.ToInt32(amountInput);
                        if (amount < 0)
                        {
                            throw new ArgumentOutOfRangeException("aantal", "Fout: Aantal kan niet negatief zijn.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Fout: Ongeldige invoer voor aantal.");
                        inputIsValid = false;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Fout: Aantal kan niet negatief zijn.");
                        inputIsValid = false;
                    }
                }

                // 5. Bereken de totaalprijs & 6. Toon de factuur.
                if (inputIsValid)
                {
                    decimal totalPrice = price * amount;
                    Console.WriteLine($"Factuur voor: {productName}");
                    // :0.00 zorgt voor een nette weergave als geldbedrag
                    Console.WriteLine($"Totaalprijs: {totalPrice:0.00}");
                }
            }
            finally
            {
                // 7. Gebruik een finally-blok dat ALTIJD uitvoert.
                Console.WriteLine("Factuurverwerking voltooid.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
