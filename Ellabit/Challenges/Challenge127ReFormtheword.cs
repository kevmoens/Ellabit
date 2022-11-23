namespace Ellabit.Challenges
{
    public class Challenge127ReFormtheword : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "  \"Re-Form the word\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public string GetWord(string left, string right)
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
            sumResult = tmp.GetWord(""seas"", ""onal"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Seasonal"",  $""returned: {sumResult}  expected: Seasonal"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetWord(""comp"", ""lete"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Complete"",   $""returned: {sumResult}  expected: Complete"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetWord(""lang"", ""uage"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Language"",   $""returned: {sumResult}  expected: Language"");
    }
}
}";
        public string? Description { get; set; } = @"A word has been split into a left part and a right part. Re-form the word by adding both halves together, changing the first character to an uppercase letter.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
GetWord(""seas"", ""onal"") ➞ ""Seasonal""

GetWord(""comp"", ""lete"") ➞ ""Complete""

GetWord(""lang"", ""uage"") ➞ ""Language""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "char.ToUpper(str[0]) + str.Substring(1)" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
