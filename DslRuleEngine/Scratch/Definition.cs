using System;

namespace DslRuleEngine
{
    public static class Device
    {
        public static void TurnOn() => Console.WriteLine("turned on");
        public static void TurnOff() => Console.WriteLine("turned off");
    }

    interface IRule
    {
        Func<bool> Condition { get; }
    }

    public class Rule : IRule
    {
        public Func<bool> Condition { get; }

        public Rule(Func<bool> condition) => Condition = condition ?? throw new ArgumentNullException(nameof(condition));
    }

    static class Evaluator
    {
        public static void Run(IRule rule)
        {
            if (rule.Condition())
            {
                Device.TurnOn();
            }
            else
            {
                Device.TurnOff();
            }
        }
    }
}