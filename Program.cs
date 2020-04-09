using System;
using System.Collections.Generic;
using demoPhone.Models;
using demoPhone.Interfaces;

namespace demoPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            iPhone mine = new iPhone("iPhone 8",80,"Bringgg a ding ring ring","T-Mobile");
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            Console.WriteLine(mine.Ring());
            
            Console.WriteLine(mine.BatteryPercentage);
            while(mine.BatteryPercentage < 100)
            {
                mine.Charge();
            }
            Console.WriteLine(mine.BatteryPercentage);


            // List<IRingable> rings = new List<IRingable>();
            // rings.Add(mine);
        }
    }
}
