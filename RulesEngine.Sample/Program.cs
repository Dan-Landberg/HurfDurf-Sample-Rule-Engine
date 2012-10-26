using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RulesEngine.Sample
{
    class Program
    {
        public static void Main()
        {
            Unit unit1 = new Unit();
            Unit unit2 = new Unit();

            Console.WriteLine("Unit1");
            Console.WriteLine("Name:");
            unit1.Name = Console.ReadLine();

            Console.WriteLine("Minimum Range:");
            unit1.MinimumRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("Minimum Ideal Range:");
            unit1.MinimumIdealRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("Maximum Range:");
            unit1.MaximumRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("Maximum Ideal Range:");
            unit1.MaximumIdealRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("X:");
            unit1.XCoordinate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Y:");
            unit1.YCoordinate = Int32.Parse(Console.ReadLine());

            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);

            Console.WriteLine("Unit2");
            Console.WriteLine("Name:");
            unit2.Name = Console.ReadLine();

            Console.WriteLine("Minimum Range:");
            unit2.MinimumRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("Minimum Ideal Range:");
            unit2.MinimumIdealRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("Maximum Range:");
            unit2.MaximumRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("Maximum Ideal Range:");
            unit2.MaximumIdealRange = Double.Parse(Console.ReadLine());

            Console.WriteLine("X:");
            unit2.XCoordinate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Y:");
            unit2.YCoordinate = Int32.Parse(Console.ReadLine());

            
            Console.WriteLine(unit1.Fire(unit2));

            Console.ReadLine();
        }
    }
}
