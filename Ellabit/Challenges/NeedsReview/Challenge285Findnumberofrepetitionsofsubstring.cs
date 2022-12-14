namespace Ellabit.Challenges
{
    public class Challenge285Findnumberofrepetitionsofsubstring : IChallenge
    {
        public string? Header { get; set; } = "Find number of repetitions of substring";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge {
	public  int NumberOfRepeats(string str) 
	{	
		return 0;
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
        public string? Description { get; set; } = @"Create a function that takes a string as an argument and returns the number of repitions of a substring. This the opposite of creating a string by repeating a smaller string n times. For example ""abc"" repeated4 times would be ""abcabcabcabc""

In this challenge, we do the opposite. Given the final string, and ask the number of times the substring is repeated.

Examples
NumberOfRepeats(""abcabcabcabc"" ) ➞ 4

NumberOfRepeats(""bcbcbc"") ➞ 3

NumberOfRepeats(""llbllbllbllbllbllb"") ➞ 6

NumberOfRepeats(""kc"") ➞ 1
Notes
Assume that the substring length is always greater than 1.
Assume that the string length is always greater than 1.
Assume that the substring is not always the same.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
