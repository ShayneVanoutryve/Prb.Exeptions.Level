# Oefening 4: De Indexzoeker

Een bibliotheek wil een programma om een boek te vinden in een array van boektitels. De gebruiker geeft een indexnummer op, en de applicatie toont de titel van het boek op die positie. De applicatie moet een foutmelding geven als de gebruiker een ongeldig indexnummer invoert (geen getal, of een getal buiten de grenzen van de array).

## Voorbeeld van de console
```
Geef een indexnummer (0-4): 2
Het boek op index 2 is: The Lord of the Rings
```
```
Geef een indexnummer (0-4): 5
Fout: Index is buiten de grenzen van de lijst.
```
```
Geef een indexnummer (0-4): twee
Fout: Ongeldige invoer. Voer een geheel getal in.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Maak een array met boektitels.** Maak een `string[]` met een aantal boektitels.
2.  **Vraag de gebruiker om een index.** Gebruik `Console.WriteLine()` om de gebruiker te vragen een indexnummer in te voeren.
3.  **Lees de invoer.** Gebruik `Console.ReadLine()` om de invoer te lezen.
4.  **Valideer de invoer.** Gebruik een `try-catch`-blok. Probeer de invoer om te zetten naar een `int`. Vang een `FormatException` op als de invoer geen getal is.
5.  **Zoek het boek.** Gebruik nog een `try-catch`-blok om het boek op de opgegeven index te vinden. Vang een `IndexOutOfRangeException` op als de index buiten de grenzen van de array valt.
6.  **Toon het resultaat.** Toon de boektitel of de juiste foutmelding.
7.  **Gebruik een `finally`-blok.** Toon in een `finally`-blok een bericht zoals "Zoekopdracht voltooid.". Dit bericht moet altijd getoond worden, ongeacht of de zoekopdracht succesvol was of niet.
