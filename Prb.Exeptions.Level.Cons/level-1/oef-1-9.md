# Oefening 9: De Kleurkiezer

Een programma heeft een lijst met beschikbare kleuren. De gebruiker kiest een kleur uit de lijst door de naam in te voeren. Als de kleur niet in de lijst voorkomt, moet er een `KeyNotFoundException` worden opgevangen.

## Voorbeeld van de console
```
Beschikbare kleuren: Rood, Groen, Blauw
Kies een kleur: Groen
U heeft Groen gekozen.
```
```
Beschikbare kleuren: Rood, Groen, Blauw
Kies een kleur: Geel
Fout: De kleur 'Geel' is niet beschikbaar.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Maak een `Dictionary` met kleuren.** Maak een `Dictionary<string, string>` waarbij de sleutel de kleurnaam is en de waarde bijvoorbeeld een hex-code (bv. "#FF0000" voor Rood).
2.  **Toon de beschikbare kleuren.** Toon de sleutels van de `Dictionary` aan de gebruiker.
3.  **Vraag de gebruiker om een kleur te kiezen.**
4.  **Lees de invoer.**
5.  **Zoek de kleur.** Gebruik een `try-catch`-blok. Probeer de waarde op te halen die bij de ingevoerde sleutel hoort.
6.  **Vang de fout op.** Als de sleutel niet bestaat, gooit de `Dictionary` een `KeyNotFoundException`. Vang deze op en geef een duidelijke foutmelding.
7.  **Toon het resultaat.** Toon een bevestiging of de foutmelding.
