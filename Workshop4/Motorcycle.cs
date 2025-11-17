using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public override void Start()
        {
            Console.WriteLine($"Motorcycle {Brand} {Model} is revving up!");
        }
    }
}
