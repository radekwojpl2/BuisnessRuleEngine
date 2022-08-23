using System;
using BuissnessRuleEngine;

namespace BuisnessRuleEngine.Exceptions
{
    public class BrokenBuisnessRuleException : Exception
    {
        public IBuisnessRule _rule;

        public BrokenBuisnessRuleException(IBuisnessRule rule) : base(rule.Message)
        {
            _rule = rule;
        }
    }
}

