using System;
namespace BuisnessRuleEngine
{
    public abstract class BuisnessRuleSubject<TSubject> where TSubject : class
    {
        public readonly TSubject _subject;

        public BuisnessRuleSubject(TSubject subject)
        {
            _subject = subject;
        }
    }
}

