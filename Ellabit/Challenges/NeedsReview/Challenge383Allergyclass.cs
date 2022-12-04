namespace Ellabit.Challenges
{
    public class Challenge383Allergyclass : IChallenge
    {
        public string? Header { get; set; } = "  \"Allergy class\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

// add additional libraries if required

using System;
using System.Collections.Generic;
using System.Linq;

public class Allergies
{
		// do not alter this enum
		[Flags]
		public enum Allergen
		{
			Eggs = 1,
			Peanuts = 2,
			Shellfish = 4,
			Strawberries = 8,
			Tomatoes = 16,
			Chocolate = 32,
			Pollen = 64,
			Cats = 128
		}
	
		// write your code below this line
	
		// constructors 
	
		// properties
	
		// methods
	
		public override string ToString()
		{
				// add code here to return string representation of this instance
				return base.ToString();
		}			
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Create content  an  allergies  class  that  holds  a  person's  name  and  the  things  s/he  is  allergic  to.  each  allergy  has  a  unique  score  value  as  follows:

allergy  |  score
---|---
eggs|1
peanuts|2
shellfish|4
strawberries|8
tomatoes|16
chocolate|32
pollen|64
cats|128

by  combining  the  scores  for  each  allergy  suffered  by  a  person  their  overall  allergy  score  is  obtained.  for  ex""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
