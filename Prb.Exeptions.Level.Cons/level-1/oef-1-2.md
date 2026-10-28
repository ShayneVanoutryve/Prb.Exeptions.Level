# Oefening 2: De Leeftijdscontrole

Een bioscoop wil een systeem om de leeftijd van een bezoeker te controleren. De gebruiker moet zijn geboortejaar invoeren. De applicatie berekent de leeftijd en controleert of de bezoeker oud genoeg is (16 jaar of ouder). Als de gebruiker een ongeldig geboortejaar invoert (bijvoorbeeld tekst, een toekomstig jaar of een onrealistisch ver verleden jaar), moet er een foutmelding worden gegeven.

## Voorbeeld van de console
```
Geef uw geboortejaar in: 2005
U bent 20 jaar oud en oud genoeg.
```
```
Geef uw geboortejaar in: 2015
U bent 10 jaar oud en te jong.
```
```
Geef uw geboortejaar in: negentienvijfennegentig
Fout: Ongeldig geboortejaar.
```
```
Geef uw geboortejaar in: 2030
Fout: Het geboortejaar kan niet in de toekomst liggen.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag de gebruiker om het geboortejaar.** Gebruik `Console.WriteLine()` om de gebruiker te vragen zijn geboortejaar in te voeren.
2.  **Lees de invoer.** Gebruik `Console.ReadLine()` om de invoer te lezen.
3.  **Valideer de invoer.** Gebruik een `try-catch`-blok. Probeer de invoer om te zetten naar een `int`. Vang een `FormatException` op als de invoer geen getal is.
4.  **Controleer het geboortejaar.** Gooi een `ArgumentOutOfRangeException` als het geboortejaar in de toekomst ligt of onrealistisch ver in het verleden (bv. voor 1900).
5.  **Bereken de leeftijd.** Trek het geboortejaar af van het huidige jaar (`DateTime.Now.Year`).
6.  **Controleer de leeftijd.** Gebruik een `if`-statement om te controleren of de leeftijd 16 of hoger is.
7.  **Toon de boodschap.** Toon een bericht of de bezoeker oud genoeg is of niet, of toon de juiste foutmelding.
