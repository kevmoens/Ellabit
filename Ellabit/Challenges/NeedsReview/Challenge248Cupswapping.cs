namespace Ellabit.Challenges
{
    public class Challenge248Cupswapping : IChallenge
    {
        public string? Header { get; set; } = "Cup swapping";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  string CupSwapping(string[] swaps) {
		
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
        string sumResult;
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
        string sumResult;
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
        string sumResult;
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
        public string? Description { get; set; } = @"There are three cups on a table, at positions A, B, and C. At the start, there is a ball hidden under the cup at position B.

Image of cups where ball is under middle cup

However, I perform several swaps on the cups, which is notated as two letters. For example, if I swap the cups at positions A and B, I could notate this as AB or BA.

Create a function that returns the letter position that the ball is at, once I finish swapping the cups. The swaps will be given to you as an array.

Worked Example
cupSwapping([""AB"", ""CA"", ""AB""]) ➞ ""C""

// Ball begins at position B.
// Cups A and B swap, so the ball is at position A.
// Cups C and A swap, so the ball is at position C.
// Cups A and B swap, but the ball is at position C, so it doesn't move.
Examples
cupSwapping([""AB"", ""CA""]) ➞ ""C""

cupSwapping([""AC"", ""CA"", ""CA"", ""AC""]) ➞ ""B""

cupSwapping([""BA"", ""AC"", ""CA"", ""BC""]) ➞ ""A""
Notes
A swap could be notated in two different ways, since both ways end up with the same outcome.
All swaps will be notated as capital letters and will be valid.
You cannot swap a cup with itself.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
