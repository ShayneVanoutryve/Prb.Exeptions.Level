namespace Prb.Exeptions.Level.Cons
{
    class Oefening2
    {
        static void Main(string[] args)
        {
            // 1. Vraag de gebruiker om het geboortejaar & 2. Lees de invoer.
            Console.Write("Geef uw geboortejaar in: ");
            string input = Console.ReadLine();

            // 3. Valideer de invoer met een try-catch-blok.
            try
            {
                // Probeer de invoer om te zetten naar een int
                int birthYear = Convert.ToInt32(input);
                int currentYear = DateTime.Now.Year;

                // 4. Controleer het geboortejaar (Gooi zelf een exception bij ongeldige data)
                if (birthYear > currentYear)
                {
                    throw new ArgumentOutOfRangeException("toekomst", "Fout: Het geboortejaar kan niet in de toekomst liggen.");
                }
                if (birthYear < 1900)
                {
                    throw new ArgumentOutOfRangeException("verleden", "Fout: Het geboortejaar is onrealistisch ver in het verleden.");
                }

                // 5. Bereken de leeftijd.
                int age = currentYear - birthYear;

                // 6. Controleer de leeftijd & 7. Toon de boodschap.
                if (age >= 16)
                {
                    Console.WriteLine($"U bent {age} jaar oud en oud genoeg.");
                }
                else
                {
                    Console.WriteLine($"U bent {age} jaar oud en te jong.");
                }
            }
            catch (FormatException)
            {
                // Vang op wanneer de gebruiker tekst invoert in plaats van cijfers
                Console.WriteLine("Fout: Ongeldig geboortejaar.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Vang de zelf opgeworpen fouten voor de jaartallen op
                Console.WriteLine(ex.Message);
            }

            // Houdt de console open
            Console.ReadLine();
        }
    }
}