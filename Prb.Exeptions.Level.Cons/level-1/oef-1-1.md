# Oefening 1: De Deler

Een klant wil een eenvoudige applicatie om twee getallen te delen. De gebruiker moet twee gehele getallen kunnen invoeren. De applicatie moet de deling uitvoeren en het resultaat tonen. Als de gebruiker een ongeldige invoer geeft (bijvoorbeeld tekst in plaats van een getal), of als er door nul wordt gedeeld, moet er een duidelijke foutmelding verschijnen.

## Voorbeeld van de console
```
Voer het eerste getal in: 10
Voer het tweede getal in: 2
Het resultaat van de deling is: 5
```
```
Voer het eerste getal in: 10
Voer het tweede getal in: 0
Fout: Kan niet delen door nul.
```
```
Voer het eerste getal in: abc
Fout: Ongeldige invoer. Voer een geheel getal in.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag de gebruiker om twee getallen.** Gebruik `Console.WriteLine()` om de gebruiker te vragen om het eerste en tweede getal in te voeren.
2.  **Lees de invoer van de gebruiker.** Gebruik `Console.ReadLine()` om de invoer van de gebruiker voor beide getallen te lezen.
3.  **Converteer de invoer naar getallen.** Gebruik een `try-catch`-blok om de `string`-invoer om te zetten naar `int`-variabelen. Een `FormatException` kan optreden als de gebruiker geen geldig getal invoert. Vang deze fout op en geef een gepaste foutmelding.
4.  **Voer de deling uit.** Gebruik nog een `try-catch`-blok om de deling uit te voeren. Een `DivideByZeroException` kan optreden als de gebruiker als tweede getal 0 invoert. Vang deze fout op en geef een gepaste foutmelding.
5.  **Toon het resultaat of de foutmelding.** Als de deling succesvol is, toon het resultaat. Als er een fout is opgetreden, toon dan de juiste foutmelding.
