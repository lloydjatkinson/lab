using System;
using DslRuleEngine;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeRule = new Rule(() => DateTime.Now.DayOfWeek == DayOfWeek.Saturday);

            Evaluator.Run(timeRule);
        }
    }
}