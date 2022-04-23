using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ocurrences
{
    class Program
    {
        static void Main()
        {
            // var strings = new List<string> { "ab", "ab", "abc" };
            // var queries = new List<string> { "ab", "abc", "bc" };
            var strings = new List<string> { "aba", "baba", "aba", "xzxb" };
            var queries = new List<string> { "aba", "xzxb", "ab" };
            List<int> result = new();
            foreach(var q in queries)
            {
                int contador = 0;
                foreach(var s in strings)
                    if(s == q) contador++;
                result.Add(contador);
            }
        foreach(var s in result)
            Console.Write(s + " ");
        }
    }
}