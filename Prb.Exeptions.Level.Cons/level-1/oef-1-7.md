# Oefening 7: De Wachtwoord-checker

Een inlogsysteem vereist dat een wachtwoord minimaal 8 tekens lang is. De gebruiker voert een wachtwoord in. De applicatie controleert de lengte. Als het wachtwoord te kort is, wordt er een `ArgumentException` gegooid en een foutmelding getoond.

## Voorbeeld van de console
```
Voer uw wachtwoord in: Wachtwoord123
Wachtwoord geaccepteerd.
```
```
Voer uw wachtwoord in: kort
Fout: Het wachtwoord moet minimaal 8 tekens lang zijn.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag de gebruiker om een wachtwoord.** Gebruik `Console.WriteLine()` om de gebruiker te vragen een wachtwoord in te voeren.
2.  **Lees de invoer.** Gebruik `Console.ReadLine()` om het wachtwoord te lezen.
3.  **Controleer de lengte.** Gebruik een `try-catch`-blok. Controleer de lengte van de ingevoerde `string`. Als de lengte minder dan 8 is, `throw` een `ArgumentException` met een specifieke boodschap.
4.  **Vang de fout op.** Vang de `ArgumentException` op en toon de boodschap van de exception.
5.  **Toon de boodschap.** Als er geen fout is, toon een succesbericht. Anders, toon de foutmelding.
