namespace Ellabit.Challenges
{
    public class Challenge110Smallerstringnumber : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Smaller string number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string smallerNum(string n1, string n2)
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
            sumResult = tmp.smallerNum(""21"", ""44"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""21"",  $""returned: {sumResult}  expected: 21"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.smallerNum(""1500"", ""1"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""1"",   $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.smallerNum(""5"", ""5"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""5"",   $""returned: {sumResult}  expected: 5"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that returns the smaller number.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
smallerNum(""21"", ""44"") ➞ ""21""

smallerNum(""1500"", ""1"") ➞ ""1""

smallerNum(""5"", ""5"") ➞ ""5""
            </p>
        </code>
Notes
Numbers will be represented as strings, and your output should also be a string.
If both numbers tie, return either number.
Numbers will be positive.
Bonus: See if you can do this without converting to integers.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"String", "Comparison" }, { "Logic", "If"}, { "Expression", "==" }, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
<<<<<<< Updated upstream
=======
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
>>>>>>> Stashed changes
    }
}
