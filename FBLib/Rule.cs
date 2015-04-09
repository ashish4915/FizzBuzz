using System;

namespace FBLib
{
    public class Rule
    {
        public Rule(Func<int, bool> cond, string output)
        {
            Condition = cond;
            Output = output;
        }
        public Func<int, bool> Condition { get; private set; }
        public string Output { get; private set; }
    }
}
