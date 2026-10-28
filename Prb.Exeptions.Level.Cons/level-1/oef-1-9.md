# Oefening 9: De Cijferlijst

Een docent wil het gemiddelde van een reeks cijfers berekenen. De gebruiker voert een reeks cijfers in, gescheiden door komma's. De applicatie berekent het gemiddelde. De applicatie moet fouten afhandelen voor ongeldige getallen in de reeks en voor een lege invoer.

## Voorbeeld van de console
```
Voer cijfers in, gescheiden door komma's: 7,8,9,10
Het gemiddelde is: 8.5
```
```
Voer cijfers in, gescheiden door komma's: 7,acht,9
Fout: 'acht' is geen geldig getal.
```
```
Voer cijfers in, gescheiden door komma's: 
Fout: Invoer mag niet leeg zijn.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag om de cijfers.** Vraag de gebruiker om een reeks cijfers, gescheiden door komma's.
2.  **Lees de invoer.** Lees de `string` met cijfers.
3.  **Valideer de invoer.** Gebruik een `try-catch`-blok. Controleer eerst of de invoer leeg is. Zo ja, `throw` een `Exception`.
4.  **Splits de invoer.** Splits de `string` op komma's om een array van `string`-getallen te krijgen.
5.  **Loop door de getallen.** Gebruik een `foreach`-lus om door de array te gaan.
6.  **Converteer en tel op.** Binnen de lus, gebruik een genest `try-catch`-blok om elk `string`-getal naar een `double` te converteren. Vang een `FormatException` op als een getal ongeldig is en toon een specifieke foutmelding. Tel de geldige getallen op.
7.  **Bereken het gemiddelde.** Deel de som door het aantal geldige cijfers.
8.  **Toon het resultaat.** Toon het gemiddelde of de foutmelding.
