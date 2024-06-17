using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrinter
{
   class Car : Vehicle
    {
       
        public string Color { get; }
      
        public bool IsExpensive { get; }

        public Car( string name, string brand, int year, string color, bool isExpensive)
        : base ( name, brand, year)
        {
            
            Color = color;
            
            IsExpensive = isExpensive;
        }
        public override void PrintInfo()
        {

            base.PrintInfo();
            Console.WriteLine($"Color = {Color}");
            if (IsExpensive) Console.WriteLine("Is expensive");
            Console.WriteLine();
        }

        public override void Run()
        {
            Console.WriteLine("Showing off car");
        }
    } 
}
