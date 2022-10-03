namespace Ellabit.Challenges
{
    public class Challenge120Howmanydsarethere : IChallenge
    {
        public string? Header { get; set; } = "How many d's are there?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  int CountDs(string str)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountDs(""My friend Dylan got distracted in school."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 4,   $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountDs(""Debris was scattered all over the yard."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 3,   $""returned: {sumResult}  expected: 3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountDs(""The rodents hibernated in their den."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 3,   $""returned: {sumResult}  expected: 3"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that counts how many D's are in a sentence.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
CountDs(""My friend Dylan got distracted in school."") ➞ 4

CountDs(""Debris was scattered all over the yard."") ➞ 3

CountDs(""The rodents hibernated in their den."") ➞ 3
            </p>
        </code>
Notes
Your function must be case-insensitive.
Remember to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
