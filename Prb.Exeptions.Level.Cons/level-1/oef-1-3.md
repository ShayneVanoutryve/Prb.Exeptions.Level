# Oefening 3: De Temperatuurconverter

Een weerstation heeft een applicatie nodig om temperaturen van Celsius naar Fahrenheit om te zetten. De gebruiker voert een temperatuur in Celsius in. De applicatie moet deze omzetten naar Fahrenheit en het resultaat tonen. De formule is: `Fahrenheit = (Celsius * 9/5) + 32`. De applicatie moet een foutmelding geven als de gebruiker geen geldig getal invoert.

## Voorbeeld van de console
```
Voer de temperatuur in Celsius in: 20
De temperatuur in Fahrenheit is: 68
```
```
Voer de temperatuur in Celsius in: tien
Fout: Ongeldige invoer. Voer een getal in.
```

## Nodige onderdelen
Plaats hieronder de verschillende componenten.

## Programmastructuur
Plaats hieronder een mogelijke structuur van het programma.

## Stappenplan
1.  **Vraag om de temperatuur in Celsius.** Gebruik `Console.WriteLine()` om de gebruiker om de temperatuur te vragen.
2.  **Lees de invoer.** Gebruik `Console.ReadLine()` om de invoer van de gebruiker te lezen.
3.  **Converteer de invoer.** Gebruik een `try-catch`-blok om de `string`-invoer om te zetten naar een `double`. We gebruiken `double` omdat een temperatuur een kommagetal kan zijn. Vang een `FormatException` op als de invoer geen geldig getal is.
4.  **Bereken de temperatuur in Fahrenheit.** Pas de formule `(Celsius * 9/5) + 32` toe.
5.  **Toon het resultaat.** Toon de omgerekende temperatuur of de foutmelding.
