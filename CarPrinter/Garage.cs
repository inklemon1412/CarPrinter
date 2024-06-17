using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrinter
{
    internal class Garage
    {
        public static void Start()
        {
            var garage = new Garage();

            while (true)
            {
                Console.WriteLine("Press 1 to see cars");
                Console.WriteLine("Press 2 to see motorcycles");

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                   
                    case "1":
                        seeCars();
                        break;

                    case "2":
                        seeCycles();
                        break;
                }
                void seeCars()
                {
                    var car1 = new Car(
                         "Turbo 911",
                         "Porsche",
                         1977,
                        "Black",
                         true
                        );
                    car1.PrintInfo();
                    car1.Run();

                     var car2 = new Car(
                        "Type-66 Avenger",
                        "Quadra",
                        2055,
                        "Grey",
                       false
                        );
                    car2.PrintInfo();
                    car2.Run();

                    var car3 = new Car(
                        "Riptide GT2",
                        "Herrera",
                        2077,
                        "Grey and red",
                        true
                        );
                    car3.PrintInfo();
                    car3.Run();


                }
                void seeCycles()
                {
                    var cycle1 = new Cycles(
                        "Kusanagi CT-3X",
                        "Yaiba",
                        2068,
                        "Rear-Wheel drive",
                        820
                        );
                    cycle1.PrintInfo();
                    cycle1.Run();

                    var cycle2 = new Cycles(
                        "Apollo",
                        "Brennan",
                        2052,
                        "Rear-Wheel drive",
                        503
                        );
                    cycle2.PrintInfo();
                    cycle2.Run();
                }
            }
        }
    }
}
