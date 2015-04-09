using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FBLib
{
    public class FizzBuzzer
    {
        private readonly Rule[] _rules;
        private readonly TextWriter _textWriter;

        public FizzBuzzer(TextWriter textWriter, params Rule[] rules)
        {
            _rules = rules;
            _textWriter = textWriter;
        }

        public void Print(int start, int end)
        {
            var matches = GetOutputs(start, end);
            foreach (var match in matches)
            {
                _textWriter.WriteLine(match);
            }
        }

        public IEnumerable<string> GetOutputs(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                var match = _rules.Where(r => r.Condition(i)).Select(x => x.Output).ToArray();
                yield return match.Any() ? string.Join("", match) : i.ToString();
            }
        }

    }
}
