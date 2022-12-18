namespace Ellabit.Challenges
{
    public class Challenge325Maximumoccurrence : IChallenge
    {
        public string? Header { get; set; } = "Maximum occurrence";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  string MaxOccur(string text)
	{
		
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
            sumResult = tmp.maxoccur(""computer science"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""e"" ,  $""returned: {sumResult}  expected: e"");
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
        public string? Description { get; set; } = @"Given a string text. Write a function that returns the character with the highest frequency. If more than 1 character has the same highest frequency, return all those characters as a comma separated string. If there is no repetition in characters, return ""No Repetition"".

Examples
MaxOccur(""Computer Science"") ➞ ""e""

MaxOccur(""Edabit"") ➞ ""No Repetition""

MaxOccur(""system admin"") ➞ ""m, s""

MaxOccur(""the quick brown fox jumps over the lazy dog"") ➞ "" ""
Notes
Characters are case sensitive, so, for example, ""C"" and ""c"" are counted separately";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
