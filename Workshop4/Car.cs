using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine($"Car {Brand} {Model} engine is starting!");
        }

        public void OpenTrunk()
        {
            Console.WriteLine("Trunk is open!");
        }
    }
}
