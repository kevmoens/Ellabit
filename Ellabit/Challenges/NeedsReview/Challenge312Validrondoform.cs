namespace Ellabit.Challenges
{
    public class Challenge312Validrondoform : IChallenge
    {
        public string? Header { get; set; } = "Valid rondo form?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  bool ValidRondo(string s) {
		
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
        bool sumResult;
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
        bool sumResult;
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
        bool sumResult;
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
        public string? Description { get; set; } = @"Rondo Form is a type of musical structure, in which there is a recurring theme/refrain, notated as A. Here are the rules for valid rondo forms:

Rondo forms always start and end with an A section.
In between the A sections, there should be contrasting sections notated as B, then C, then D, etc... No letter should be skipped.
There shouldn't be any repeats in the sequence (such as ABBACCA).
Create a function which validates whether a given string is a valid Rondo Form.

Examples
ValidRondo(""ABACADAEAFAGAHAIAJA"") ➞ true

ValidRondo(""ABA"") ➞ true

ValidRondo(""ABBACCA"") ➞ false

ValidRondo(""ACAC"") ➞ false

ValidRondo(""A"") ➞ false
Notes
Inputs will be given as all uppercase.
For the purposes of this challenge, accept ABA as valid Rondo forms.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
