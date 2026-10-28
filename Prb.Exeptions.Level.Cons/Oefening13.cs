using System;
using System.Collections.Generic;
using System.Text;

namespace Prb.Exeptions.Level.Cons
{
    internal class Oefening13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een bewerking (1=optellen, 2=aftrekken, 3=vermenigvuldigen, 4=delen): ");
            string menuChoiceInput = Console.ReadLine();

            try
            {
                int choice = Convert.ToInt32(menuChoiceInput);

                if (choice < 1 || choice > 4)
                {
                    throw new ArgumentException("Fout: Ongeldige keuze.");
                }

                Console.Write("Voer getal 1 in: ");
                string firstNumberInput = Console.ReadLine();

                Console.Write("Voer getal 2 in: ");
                string secondNumberInput = Console.ReadLine();

                double firstNumber = Convert.ToDouble(firstNumberInput);
                double secondNumber = Convert.ToDouble(secondNumberInput);

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = firstNumber + secondNumber;
                        break;
                    case 2:
                        result = firstNumber - secondNumber;
                        break;
                    case 3:
                        result = firstNumber * secondNumber;
                        break;
                    case 4:
                        if (secondNumber == 0)
                        {
                            throw new DivideByZeroException("Fout: Kan niet delen door nul.");
                        }
                        result = firstNumber / secondNumber;
                        break;
                }

                Console.WriteLine($"Resultaat: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Fout: Ongeldige invoer. Voer een geldig getal in.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Er is een onbekende fout opgetreden: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
