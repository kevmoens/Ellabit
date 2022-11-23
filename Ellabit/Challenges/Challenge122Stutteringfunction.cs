namespace Ellabit.Challenges
{
    public class Challenge122Stutteringfunction : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Stuttering function";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	  public  string Stutter(string word)
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
            sumResult = tmp.Stutter(""incredible"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""in... in... incredible?"",  $""returned: {sumResult}  expected: in... in... incredible?"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Stutter(""enthusiastic"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""en... en... enthusiastic?"",   $""returned: {sumResult}  expected: en... en... enthusiastic?"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Stutter(""outstanding"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""ou... ou... outstanding?"",   $""returned: {sumResult}  expected: ou... ou... outstanding?"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that stutters a word as if someone is struggling to read it. The first two letters are repeated twice with an ellipsis ... and space after each, and then the word is pronounced with a question mark ?.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Stutter(""incredible"") ➞ ""in... in... incredible?""

Stutter(""enthusiastic"") ➞ ""en... en... enthusiastic?""

Stutter(""outstanding"") ➞ ""ou... ou... outstanding?""
            </p>
        </code>
Notes
Assume all input is in lower case and at least two characters long.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Substring" },{ "Level" , "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
