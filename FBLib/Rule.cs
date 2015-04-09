using System;

namespace FBLib
{
    public class Rule
    {
        public Func<int, bool> Condition { get; private set; }
        public string Output { get; private set; }

        public Rule(Func<int, bool> cond, string output)
        {
            Condition = cond;
            Output = output;
        }
    }
}
