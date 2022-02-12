using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_data
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine($"Value: {i}");
                i++;
            }
            while (i < 10);
        }
    }
}