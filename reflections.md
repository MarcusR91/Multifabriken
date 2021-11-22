# Kodstruktur

När användaren först öppnar min applikation så möts denne av en meny där man får göra sina val. Detta görs genom att jag 
skapade en klass för menyn där jag lade in en metod som skriver ut sjävla menyn och sedan kallar jag på funktionen i program
klassen. 
```
public void Title()
        {
            Console.WriteLine("Välkommen till Multifabriken!");
```

När användaren sedan vill göra en beställning så klickar denne på den siffra som är kopplad till den produkt som han/hon 
vill köpa. Om användaren till exempel klickar på "[1]" så hoppar programmet in i en switch statement som skriver ut frågor om
vilken bil han/hon vill köpa. Produkten "Cars" har en egen klass som har getts vissa properties (variabler) där det som användaren
matar in sparas i. Dessa variablar skickas sedan in i objektet som skapas (myCar) som parametrar. Därefter så sparas objetet "myCar"
i en lista för alla bilar som köps.

Samma funktionalitet och teknik gäller för alla produkter som har skapats. Så om användaren klickar på "[2]" så hoppar min switch statement till
case 2 och samma sak händer fast med produkten "Tofu" istället. 

```
 switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Vilket bilmärke vill du ha?");
                        string brand = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Vilken färg ska din bil ha?");
                        string color = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Vad ska bilen ha för regnr?");
                        string licensePlate = Console.ReadLine();
                        Console.Clear();
                        var myCar = new Car(color, licensePlate, brand);
                        carList.Add(myCar);
                        Console.ReadLine();
                        Console.Clear();
                        break;
```

Om användaren väljer att klicka på "[5]" så vis
as alla de produkter som har beställts. Detta gjordes genom att spara objektet som skapas när en användare beställer 
något till en lista där varje produkt fich en egen lista av den typ som produkten tillhör. 

```
List<Car> carList = new List<Car>();
List<Tofu> tofuList = new List<Tofu>();
List<Godis> candyList = new List<Godis>();
List<Snöre> stringList = new List<Snöre>();
```

Sedan för att listan ska skrivas ut så används först en *if-statement* för att kolla om listorna inte är tomma. Om dem inte är tomma så används en *foreach* loop som 
går igenom allt innehåll i de listorna skriver ut produkterna en och en. 

För att få utmatningen av produkter att fungera på önskat vis så skapades funktioner i klasserna som returnerar de värden som matas in av annvändaren. Sedan gjordes funktionsanrop till dessa 
där jag fick specificera vilket object det gäller samt vilken funktion som ska kallas på det här sättet:
```car.getBrand()```

Nedan visar en kodsnutt på min *if-sats* och *foreach* loopen som matar ut produkterna. 

```
 if (carList.Count > 0)
    {
        Console.WriteLine("Bil:");
        foreach (Car car in carList)
        {
            Console.WriteLine($"Du har beställt {car.getBrand()} med färgen {car.getColor()}. Registreringsnumret är: {car.getLicense()}.");
        }
    }
```

Det sista valet som användaren får är att avsluta programmet. Detta sker genom att klicka på "[6]" och det enda som händer då är att ett "avsluta" meddelande visas och 
programet stängs ner. 
```
case 6:
    Console.Clear();
    Console.WriteLine("Programmet avslutas");
    Environment.Exit(0);
    break;
```


# Reflektion

Sättet jag valde att strukturera min kod på är att varje produkt skulle ha sin egen klass, för att om varje produkt har sin egen klass så förenklar det vidareutveckling av 
applikationen om man i framtiden vill lägga till flera produkter eller ge existerande produkter lite nya properties. När jag deklarerade mina fält så valde jag att ha dem
som *private* för att försöka följa den objektorienterade principen om inkapsulering. För att komma åt fälten gjorde jag istället en konstruktor där fälten deklarerades i
nya variabler. 

Till mina klasser valde jag även att skapa några enklare metoder som ska returnera de värden som användaren matar in i programmet. Detta valdes att göra för att användaren
ska kunna se produkterna som dem har beställt genom att göra funktionsanrop till dessa metoder. 

När jag började med programmet så var min ursprungliga plan att använda mig utav arv. Men eftersom att jag var lite kluven då jag har lärt mig att de subklasserna som ärver 
ifrån superklassen ska gärna dela properties osv så valde jag istället att inte använda mig utav det, då jag inte anser att produkterna hade så mycket gemensamt. Nu i efterhand, så inser jag dock att det hade gett mig vissa fördelar när det kommer till strukturen av min kod. Om jag hade gjort en superklass för "Produkter" så hade jag exempelvis kunnat göra en lista för alla mina produker istället för att göra en lista för varje typ
av produkt som jag har. Det tror jag hade bidragit till lite mindre kod som i sin tur hade gjort den lite mer lättläst.




