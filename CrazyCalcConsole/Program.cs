using System;
using CrazyCalcEngine;

namespace CrazyCalcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = String.Join("", args);
            Console.WriteLine($"problem: {problem}");

            var m = new MathEngine();
            int answer;
            if (m.TryParse(problem, out answer))
            {
                Console.WriteLine($"answer: {answer}");
            }
            else
            {
                Console.WriteLine($"Error parsing problem.");
            }
        }
    }
}
