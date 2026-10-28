# Oefening 5: De Kortingscalculator

Een winkel wil een korting van 10% geven op een product. De gebruiker voert de originele prijs in. De applicatie berekent de korting en de nieuwe prijs. Als de gebruiker een negatieve prijs of een ongeldige waarde (zoals tekst) invoert, moet er een foutmelding komen.

## Voorbeeld van de console
```
Voer de originele prijs in: 50.00
De korting is: 5.00
De nieuwe prijs is: 45.00
```
```
Voer de originele prijs in: -10
Fout: De prijs kan niet negatief zijn.
```
```
Voer de originele prijs in: vijftig
Fout: Ongeldige invoer. Voer een getal in.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag om de originele prijs.** Gebruik `Console.WriteLine()` om de gebruiker naar de prijs te vragen.
2.  **Lees de invoer.** Gebruik `Console.ReadLine()` om de invoer te lezen.
3.  **Valideer de invoer.** Gebruik een `try-catch`-blok. Probeer de invoer om te zetten naar een `decimal` omdat het om een geldbedrag gaat. Vang een `FormatException` op.
4.  **Controleer de prijs.** Gooi een `ArgumentException` als de prijs negatief is.
5.  **Bereken de korting en de nieuwe prijs.** Bereken 10% van de originele prijs en trek dit af van de originele prijs.
6.  **Toon de resultaten.** Toon de korting en de nieuwe prijs, of de foutmelding.
