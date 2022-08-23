# BuisnessRuleEngine

This buisness rule engine is based on https://github.com/kgrzybek/modular-monolith-with-ddd.

## USAGE
``` C#

  class ClimbingGym
  {
      public ClimbingGym(bool isClosed)
      {
          IsClosed = isClosed;
      }

      public bool IsClosed { get; }
  }

  class ClimbingGymMustBeOpen : BuisnessRuleSubject<ClimbingGym>, IBuisnessRule
  {
      public TestBuisnessRule(ClimbingGym climbingGym): base(climbingGym)
      {

      }

      public string Message => "Climbing gym must be open";

      public bool IsBroken() => _subject.IsClosed;
  }

  var climbingGym = new ClimbingGym(true)

  Check.Rule(new ClimbingGymMustBeOpen(climbingGym))
