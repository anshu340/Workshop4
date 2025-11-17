using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public class ParameterDemo
    {
        // Method using ref parameter
        public void Increase(ref int number)
        {
            number += 10;
        }

        // Method using out parameter
        public void GetFullName(out string fullname)
        {
            fullname = "Anshu Karki";
        }

        // Method using params parameter
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
