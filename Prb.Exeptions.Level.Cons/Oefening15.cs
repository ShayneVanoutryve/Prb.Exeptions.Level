using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening15
    {
        static void Main(string[] args)
        {
            // 1. Vraag om gewicht en lengte & 2. Lees de invoer.
            Console.Write("Voer uw gewicht in (kg): ");
            string weightInput = Console.ReadLine();

            Console.Write("Voer uw lengte in (meter): ");
            string heightInput = Console.ReadLine();

            double weight = 0;
            double height = 0;
            bool isInputValid = true;

            // 3. Valideer gewicht.
            try
            {
                weight = Convert.ToDouble(weightInput);
                if (weight < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(weight), "Fout: Gewicht kan niet negatief zijn.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fout: Ongeldige invoer voor gewicht. Voer een getal in.");
                isInputValid = false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                isInputValid = false;
            }

            // 4. Valideer lengte (alleen als het gewicht al klopte).
            if (isInputValid)
            {
                try
                {
                    height = Convert.ToDouble(heightInput);
                    if (height == 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(height), "Fout: Lengte kan niet nul zijn.");
                    }
                    if (height < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(height), "Fout: Lengte kan niet negatief zijn.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fout: Ongeldige invoer voor lengte. Voer een getal in.");
                    isInputValid = false;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    isInputValid = false;
                }
            }

            // 5. Bereken de BMI & 6. Toon het resultaat.
            if (isInputValid)
            {
                try
                {
                    // Extra proactieve check mocht de voorgaande validatie falen
                    if (height == 0)
                    {
                        throw new DivideByZeroException("Fout: Kan niet delen door een lengte van nul.");
                    }

                    double bmi = weight / (height * height);

                    // :0.00 zorgt voor een nette afronding op 2 decimalen
                    Console.WriteLine($"Uw BMI is: {bmi:0.00}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}
