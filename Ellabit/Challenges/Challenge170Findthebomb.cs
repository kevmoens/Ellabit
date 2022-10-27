namespace Ellabit.Challenges
{
    public class Challenge170Findthebomb : IChallenge
    {
        public string? Header { get; set; } = "Find the bomb";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string Bomb(string txt)
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
            sumResult = tmp.Bomb(""There is a bomb."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Duck!!!"",   $""returned: {sumResult}  expected: Duck!!!"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Bomb(""Hey, did you think there is a Bomb?"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Duck!!!"",   $""returned: {sumResult}  expected: Duck!!!"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Bomb(""This goes boom!!!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""There is no bomb, relax."",   $""returned: {sumResult}  expected: There is no bomb, relax."");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that finds the word ""bomb"" in the given string (not case sensitive). If found, return ""Duck!!!"", otherwise, return ""There is no bomb, relax."".


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Bomb(""There is a bomb."") ➞ ""Duck!!!""

Bomb(""Hey, did you think there is a Bomb?"") ➞ ""Duck!!!""

Bomb(""This goes boom!!!"") ➞ ""There is no bomb, relax.""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Contains" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
