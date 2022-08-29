# BuisnessRuleEngine

This buisness rule engine is based on https://github.com/kgrzybek/modular-monolith-with-ddd.

## USAGE
``` C#

// let say this is our model
  class ClimbingGym
  {
      public ClimbingGym(bool isClosed)
      {
          IsClosed = isClosed;
      }

      public bool IsClosed { get; }
  }
  
// and in our system we have some rule that Climbing gym must be open befor performing some action 
  class ClimbingGymMustBeOpen : BuisnessRuleSubject<ClimbingGym>, IBuisnessRule
  {
      public TestBuisnessRule(ClimbingGym climbingGym): base(climbingGym)
      {

      }

      public string Message => "Climbing gym must be open";

      public bool IsBroken() => _subject.IsClosed;
  }

  var climbingGym = new ClimbingGym(true)
  
// insted of this 
if(climbingGym.IsClosed)
{
  throw new ConfictException("Clibing gym must be open")
}

// we can use 
  Check.Rule(new ClimbingGymMustBeOpen(climbingGym))
