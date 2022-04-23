using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_6
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var words = new String[n];
            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine();
                if (temp != null)
                    words[i] = temp;
            }
            foreach (var w in words)
            {
                string par = "";
                string impar = "";
                for (int i = 0; i < w.Length; i++)
                {
                    if (i == 0 || i % 2 == 0)
                        par += w[i];
                    else
                        impar += w[i];
                }
                Console.WriteLine($"{par} {impar}");
            }
        }
    }
}