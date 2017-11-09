using System;

namespace DslRuleEngine
{
    interface IExpressionRuleEvaluator
    {
        bool Evaluate(Func<bool> predicate);
    }

    class ExpressionRuleEvaluator : IExpressionRuleEvaluator
    {
        public bool Evaluate(Func<bool> predicate) => predicate();
    }
}