namespace Ellabit.Challenges
{
    public class Challenge132Reverseandcapitalize : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Reverse and capitalize";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  string ReverseCapitalize(string str) 
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
            sumResult = tmp.ReverseCapitalize(""abc"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""CBA"",  $""returned: {sumResult}  expected: CBA"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ReverseCapitalize(""hellothere"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""EREHTOLLEH"",   $""returned: {sumResult}  expected: EREHTOLLEH"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ReverseCapitalize(""input"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""TUPNI"",   $""returned: {sumResult}  expected: TUPNI"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string of lowercase characters and returns that string reversed and in upper case.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
ReverseCapitalize(""abc"") ➞ ""CBA""

ReverseCapitalize(""hellothere"") ➞ ""EREHTOLLEH""

ReverseCapitalize(""input"") ➞ ""TUPNI""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "ToCharArray()" }, { "Level", "3"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
