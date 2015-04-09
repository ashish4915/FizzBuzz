using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBLib;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, bool> div3 = i => (i % 3 == 0);
            Func<int, bool> div5 = i => (i % 5 == 0);
            Func<int, bool> div7 = i => (i % 7 == 0);

            var fizzBuzzer = new FizzBuzzer(Console.Out, 
                new Rule(div3, "fizz"), 
                new Rule(div5, "buzz"),
                new Rule(div7, "hello"));

            fizzBuzzer.Print(1, 100);
            Console.ReadLine();
        }
    }
}
