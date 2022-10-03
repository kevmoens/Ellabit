namespace Ellabit.Challenges
{
    public class Challenge128Recursiontorepeatastringnnumberoftimes : IChallenge
    {
        public string? Header { get; set; } = "Recursion to repeat a string n number of times";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string Repetition(string txt, int n)
	{
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Repetition(""ab"", 3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""ababab"",  $""returned: {sumResult}  expected: ababab"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Repetition(""kiwi"", 1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""kiwi"",   $""returned: {sumResult}  expected: kiwi"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Repetition(""cherry"", 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""cherrycherry"",   $""returned: {sumResult}  expected: cherrycherry"");
    }
}
}";
        public string? Description { get; set; } = @"Create a recursive function that takes two parameters and repeats the string n number of times. The first parameter txt is the string to be repeated and the second parameter is the number of times the string is to be repeated.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Repetition(""ab"", 3) ➞ ""ababab""

Repetition(""kiwi"", 1) ➞ ""kiwi""

Repetition(""cherry"", 2) ➞ ""cherrycherry""
            </p>
        </code>
Notes
The second parameter of the function is positive integer.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
