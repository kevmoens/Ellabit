namespace Ellabit.Challenges
{
    public class Challenge016Basicvariableassignment : IChallenge
    {
        public string? Header { get; set; } = "Basic variable assignment";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  string nameString(string name) {
		  string b == ""Ellabit"";
		  string result == name + b;
		  return result;
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
            sumResult = tmp.nameString(""Mubashir"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""MubashirEllabit"",  $""returned: {sumResult}  expected: Mubashir"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.nameString(""Matt"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""MattEllabit"",   $""returned: {sumResult}  expected: MattEllabit"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.nameString(""C#"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""C#Ellabit"",   $""returned: {sumResult}  expected: C#Ellabit"");
    }
}
}";
        public string? Description { get; set; } = @"A student learning c# was trying to make a function. his code should concatenate a passed string name with string name with string ""Ellabit"" and store it in a variable called result. He needs your help to fix this code.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
nameString(""Mubashir"") ➞ ""MubashirEllabit""

nameString(""Matt"") ➞ ""MattEllabit""

nameString(""C#"") ➞ ""C#Ellabit""
            </p>
        </code>
Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Concatenation" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
