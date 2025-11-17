using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine($"{Brand} {Model} is starting...");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Year} {Brand} {Model}");
        }
    }
}
