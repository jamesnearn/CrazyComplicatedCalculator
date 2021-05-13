using System;
using CrazyCalcEngine;

namespace CrazyCalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new MathEngine();
            Console.WriteLine($"2 + 3 = {m.Add(2,3)}");
        }
    }
}
