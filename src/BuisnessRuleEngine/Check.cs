using BuisnessRuleEngine;
using BuisnessRuleEngine.Exceptions;

namespace BuissnessRuleEngine;

public static class Check
{
    public static void Rule(IBuisnessRule rule)
    {
        if (rule.IsBroken())
        {
            throw new BrokenBuisnessRuleException(rule);
        }
    }
}

