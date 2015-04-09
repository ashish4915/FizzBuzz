using System;
using System.Linq;
using FBLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        [TestMethod]
        public void TestFizBuzz()
        {
            Func<int, bool> div3 = i => (i % 3 == 0);
            Func<int, bool> div5 = i => (i % 5 == 0);
            Func<int, bool> div7 = i => (i % 7 == 0);

            var fizzBuzzer = new FizzBuzzer(Console.Out, new Rule(div3, "fizz"), new Rule(div5, "buzz"),
                new Rule(div7, "hello"));

            CollectionAssert.AreEqual(new[]{"hello", "fizzbuzz","16", "17", "fizz", "19", "buzz", "fizzhello"},
                fizzBuzzer.GetOutputs(14, 21).ToArray());


            CollectionAssert.AreEqual(new[] { "fizzbuzzhello" },
                fizzBuzzer.GetOutputs(105, 105).ToArray());
        }
    }
}
