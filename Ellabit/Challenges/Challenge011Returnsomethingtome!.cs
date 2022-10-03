namespace Ellabit.Challenges
{
    public class Challenge011Returnsomethingtome : IChallenge
    {
        public string? Header { get; set; } = "Return something to me!";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  string GiveMeSomething(string a) {
		
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
            sumResult = tmp.GiveMeSomething(""is better than nothing"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""something is better than nothing"",  $""returned: {sumResult}  expected: \""something is better than nothing\"""");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GiveMeSomething(""Bob Jane"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""something Bob Jane"",   $""returned: {sumResult}  expected: \""something Bob Jane\"""");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GiveMeSomething(""something"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""something something"",   $""returned: {sumResult}  expected: \""something something\"""");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that returns the string ""something"" joined with a space "" "" and the given argument a.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >

GiveMeSomething(""is better than nothing"") ➞ ""something is better than nothing""

GiveMeSomething(""Bob Jane"") ➞ ""something Bob Jane""

GiveMeSomething(""something"") ➞ ""something something""
            </p>
        </code>
Notes
Assume an input is given.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Concatenation" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
    }
}
