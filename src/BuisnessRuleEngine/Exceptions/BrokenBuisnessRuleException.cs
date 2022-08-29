using System;
using BuissnessRuleEngine;

namespace BuisnessRuleEngine.Exceptions
{
    public class BrokenBuisnessRuleException : Exception
    {
        public IBuisnessRule _rule;

        public  string Message { get; init; }

        public BrokenBuisnessRuleException(IBuisnessRule rule) : base(rule.Message)
        {
            _rule = rule;
            Message = rule.Message;
            
        }
    }
}

