# Oefening 6: De Woordenteller

Een tekstverwerker heeft een functie nodig om het aantal woorden in een zin te tellen. De gebruiker voert een zin in. De applicatie telt het aantal woorden. Als de gebruiker een lege zin invoert, moet de applicatie een specifieke foutmelding geven.

## Voorbeeld van de console
```
Voer een zin in: Dit is een test.
De zin bevat 4 woorden.
```
```
Voer een zin in: 
Fout: De zin mag niet leeg zijn.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag de gebruiker om een zin.** Gebruik `Console.WriteLine()` om de gebruiker te vragen een zin in te voeren.
2.  **Lees de invoer.** Gebruik `Console.ReadLine()` om de zin te lezen.
3.  **Controleer op lege invoer.** Gebruik een `try-catch`-blok. Controleer of de ingevoerde `string` leeg of `null` is (`string.IsNullOrWhiteSpace()`). Als dat zo is, `throw` een nieuwe `ArgumentNullException` met een gepaste boodschap.
4.  **Tel de woorden.** Als er geen fout is, splits de zin op spaties (`Split(' ')`) en tel het aantal elementen in de resulterende array.
5.  **Toon het resultaat.** Toon het aantal woorden of de foutmelding.
