namespace Prb.Exeptions.Level.Cons
{
    class Oefening1
    {
        static void Main(string[] args)
        {
            // 1. Vraag de gebruiker om twee getallen & 2. Lees de invoer van de gebruiker.
            Console.Write("Voer het eerste getal in: ");
            string input1 = Console.ReadLine();

            Console.Write("Voer het tweede getal in: ");
            string input2 = Console.ReadLine();

            // 3. Converteer de invoer naar getallen.
            try
            {
                int number1 = Convert.ToInt32(input1);
                int number2 = Convert.ToInt32(input2);

                // 4. Voer de deling uit & 5. Toon het resultaat.
                try
                {
                    int result = number1 / number2;
                    Console.WriteLine($"Het resultaat van de deling is: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Fout: Kan niet delen door nul.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Fout: Ongeldige invoer. Voer een geheel getal in.");
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}