using System;
namespace BuisnessRuleEngine
{
    public interface IBuisnessRule
    {
        string Message { get; }

        bool IsBroken();
    }
}

