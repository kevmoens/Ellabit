namespace Ellabit.Challenges
{
    public class Challenge218Guessthesequence : IChallenge
    {
        public string? Header { get; set; } = "Guess the sequence";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
	public  int GuessSequence(int num) {
		
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
        public string? Description { get; set; } = @"Mubashir is trying to figure out the corresponding quadratic formula for the following quadratic sequence of numbers:

n  |  result
---  |  ---
1  |  90
2  |  240
3  |  450
4  |  720
5  |  1050

If you can figure this out, then help him by creating a function that takes a number n and returns the nth number of this quadratic sequence.

Examples
GuessSequence(1) ➞ 90

GuessSequence(2) ➞ 240

GuessSequence(3) ➞ 450
Notes
If you are not sure about how to find the formula of a quadratic sequence, check the Resources.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
