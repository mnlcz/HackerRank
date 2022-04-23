using System;
using System.Collections.Generic;
using System.Linq;

namespace Bill
{
    class Program
    {
        static void Main()
        {
            var sampleBill = new List<int> { 3, 10, 2, 9 };
            int sampleIndex = 1;
            int charged = 12;
            double totalCost = sampleBill.Sum() - sampleBill[sampleIndex];
            double costPerPerson = totalCost / 2;
            if(costPerPerson == charged) Console.WriteLine("Bon Appetit");
            else
            {
                double overcharge = charged - costPerPerson;
                Console.WriteLine(overcharge);
            }

        }
    }
}