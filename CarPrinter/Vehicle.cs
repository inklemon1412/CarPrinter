using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrinter
{
   abstract class Vehicle
    {
        public string Name { get; }
        public string Brand { get; }
        public int Year { get; }

        protected Vehicle(string name, string brand, int year) 
        {
            Name = name;
            Brand = brand;
           Year = year;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Brand = {Brand}");
            Console.WriteLine($"Year = {Year}");
        }
        public abstract void Run();
   } 
}
