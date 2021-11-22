using System;
using System.Collections.Generic;

namespace multifabriken_MarcusR91
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            List<Tofu> tofuList = new List<Tofu>();
            List<Godis> candyList = new List<Godis>();
            List<Snöre> stringList = new List<Snöre>();

            while (true)
            {
                var menu = new menu();
                menu.Title();
                menu.Options();
                int input;
                input = Convert.ToInt32(Console.ReadLine());
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
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Hur många liter vill du ha?");
                        string volume = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Vilken kryddning=");
                        string seasoning = Console.ReadLine();
                        var tofu = new Tofu(volume, seasoning);
                        tofuList.Add(tofu);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Hur många vill du ha?");
                        string flavor = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Vilken smak vill du ha?");
                        string quantity = Console.ReadLine();
                        var candy = new Godis(flavor, quantity);
                        candyList.Add(candy);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vilken färg vill du ha på ditt snöre?");
                        string stringColor = Console.ReadLine();
                        Console.WriteLine("Vilken längd vill du ha?");
                        string length = Console.ReadLine();
                        var snöre = new Snöre(stringColor, length);
                        stringList.Add(snöre);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Varukorg:\n");
                        if (carList.Count > 0)
                        {
                            Console.WriteLine("Bil:");
                            foreach (Car car in carList)
                            {
                                Console.WriteLine($"Du har beställt {car.getBrand()} med färgen {car.getColor()}. Registreringsnumret är: {car.getLicense()}.");
                            }
                        }
                        if (tofuList.Count > 0)
                        {

                            Console.WriteLine("Tofu:");
                            foreach (Tofu myTofu in tofuList)
                            {
                                Console.WriteLine($"Du har beställt {myTofu.showVolume()} liter 'tofu' med kryddan {myTofu.showSeasoning()}.");
                            }
                        }
                        if (candyList.Count > 0)
                        {

                            Console.WriteLine("Godis:");
                            foreach (Godis myCandy in candyList)
                            {
                                Console.WriteLine($"Du har beställt {myCandy.showQuantity()} stycken godisar med smak av {myCandy.showFlavor()}.");
                            }
                        }
                        if (stringList.Count > 0)
                        {

                            Console.WriteLine("Snöre:");
                            foreach (Snöre myString in stringList)
                            {
                                Console.WriteLine($"Du har beställt ett snöre med färgen {myString.showStringColor()} och en längd på {myString.showStringLength()} meter.");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Programmet avslutas");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ogiltig input");
                        break;
                }
            }
        }
    }
}

