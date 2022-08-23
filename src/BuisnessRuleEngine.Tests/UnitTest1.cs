using BuisnessRuleEngine.Exceptions;
using BuissnessRuleEngine;
using NUnit.Framework;

namespace BuisnessRuleEngine.Tests;

class TestClass
{
    public TestClass(bool isBroken)
    {
        IsBroken = isBroken;
    }

    public bool IsBroken { get; }
}

class TestBuisnessRule : BuisnessRuleSubject<TestClass>, IBuisnessRule
{
    public TestBuisnessRule(TestClass testClass): base(testClass)
    {

    }

    public string Message => "This Rule is broken";

    public bool IsBroken() => _subject.IsBroken;
}

internal class Tests
{

    [Test]
    public void Test1()
    {

        var test = new TestClass(true);

        Assert.Throws<BrokenBuisnessRuleException>(() => Check.Rule(new TestBuisnessRule(test)));
    }
}
