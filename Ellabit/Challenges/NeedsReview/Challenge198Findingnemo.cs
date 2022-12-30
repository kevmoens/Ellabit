namespace Ellabit.Challenges
{
    public class Challenge198FindingNemo : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Finding nemo";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{


using System;
class Program
{
	public  string FindNemo(string sentence)
	{
		
	}
}


}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
    {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
                sumResult = tmp.FindNemo(""I am finding Nemo !"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == ""I found Nemo at 4!"",  $""returned: {sumResult}  expected: I found Nemo at 4!"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
                sumResult = tmp.FindNemo(""Nemo is me"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == ""I found Nemo at 1!"",  $""returned: {sumResult}  expected: I found Nemo at 1!"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
                sumResult = tmp.FindNemo(""I Nemo am"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == ""I found Nemo at 2!"",  $""returned: {sumResult}  expected: I found Nemo at 2!"");
        }
    }
}
";
        public string? Description { get; set; } = @"<div><p><span>You're given a string of words. You need to find the word ""Nemo"", and return a string like this: </span><code>""I found Nemo at [the order of the word you find Nemo]!""</code><span>.</span></p><p><span>If you can't find Nemo, return </span><code>""I can't find Nemo :(""</code><span>.</span></p><h3><span>Examples</span></h3><pre><code>FindNemo(""I am finding Nemo !"") ➞ ""I found Nemo at 4!""

FindNemo(""Nemo is me"") ➞ ""I found Nemo at 1!""

FindNemo(""I Nemo am"") ➞ ""I found Nemo at 2!""</code></pre><h3><span>Notes</span></h3><ul><li><code>! , ? .</code><span> are always separated from the last word.</span></li><li><span>Nemo will always look like </span><em><span>Nemo</span></em><span>, and not </span><em><span>NeMo</span></em><span> or other capital variations.</span></li><li><em><span>Nemo's</span></em><span>, or anything that says </span><em><span>Nemo</span></em><span> with something behind it, doesn't count as </span><em><span>Finding Nemo</span></em><span>.</span></li><li><span>If there are multiple </span><em><span>Nemo's</span></em><span> in the sentence, only return the first one.</span></li></ul></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
