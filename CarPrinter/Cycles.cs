using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPrinter
{
    class Cycles : Vehicle
    {
        public string Drivetrain {  get; }
        public int Weight { get; }

        public Cycles(string name, string brand, int year,string drivetrain, int weight)
            : base (name, brand, year)
        {
            Drivetrain = drivetrain;
            Weight = weight;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Drivetrain = {Drivetrain}");
            Console.WriteLine($"Weight = {Weight}");
            Console.WriteLine();
        }
        public override void Run()
        {
            Console.WriteLine("Showing off cycle");
        }
    }
}
