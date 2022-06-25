namespace Ellabit.Challenges
{
    public class Challenge094Lowercaseuppercaseormixed : IChallenge
    {
        public string? Header { get; set; } = "Lowercase, uppercase or mixed?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  string GetCase(string str) 
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
            sumResult = tmp.GetCase(""whisper..."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""lower"",  $""returned: {sumResult}  expected: lower"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetCase(""SHOUT!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""upper"",   $""returned: {sumResult}  expected: upper"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetCase(""Indoor Voice"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""mixed"",   $""returned: {sumResult}  expected: mixed"");
    }
}
";
        public string? Description { get; set; } = @"Create a function which returns ""upper"" if all the letters in a word are uppercase, ""lower"" if lowercase and ""mixed"" for any mix of the two.

Examples
GetCase(""whisper..."") ➞ ""lower""

GetCase(""SHOUT!"") ➞ ""upper""

GetCase(""Indoor Voice"") ➞ ""mixed""

Notes
Ignore punctuation, spaces and numbers.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
