namespace Ellabit.Challenges
{
    public class Challenge091Thestudyofwumbology : IChallenge
    {
        public string? Header { get; set; } = "The study of wumbology";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string Wumbo(string words)
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
            sumResult = tmp.Wumbo(""I LOVE MAKING CHALLENGES"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""I LOVE WAKING CHALLENGES"",  $""returned: {sumResult}  expected: I LOVE WAKING CHALLENGES"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Wumbo(""MEET ME IN WARSAW"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""WEET WE IN WARSAW"",   $""returned: {sumResult}  expected: WEET WE IN WARSAW"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Wumbo(""WUMBOLOGY"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""WUWBOLOGY"",   $""returned: {sumResult}  expected: WUWBOLOGY"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that flips M's to W's (all uppercase).

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Wumbo(""I LOVE MAKING CHALLENGES"") ➞ ""I LOVE WAKING CHALLENGES""

Wumbo(""MEET ME IN WARSAW"") ➞ ""WEET WE IN WARSAW""

Wumbo(""WUMBOLOGY"") ➞ ""WUWBOLOGY""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
