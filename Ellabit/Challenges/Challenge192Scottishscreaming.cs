namespace Ellabit.Challenges
{
    public class Challenge192Scottishscreaming : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Scottish screaming";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge {
	    public  string ToScottishScreaming(string str) {
		
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
            sumResult = tmp.ToScottishScreaming(""hello world"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""HELLE WERLD"" ,  $""returned: {sumResult}  expected: HELLE WERLD"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ToScottishScreaming(""Mr. Fox was very naughty"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""MR. FEX WES VERY NEEGHTY"",   $""returned: {sumResult}  expected: MR. FEX WES VERY NEEGHTY"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ToScottishScreaming(""Butterflies are beautiful!"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""BETTERFLEES ERE BEEETEFEL!"",   $""returned: {sumResult}  expected: BETTERFLEES ERE BEEETEFEL!"");
    }
}
}
";
        public string? Description { get; set; } = @"A strong Scottish accent makes every vowel similar to an ""e"", so you should replace every vowel with an ""e"". Additionally, it is being screamed, so it should be in block capitals.

Create a function that takes a string and returns a string.


        <h5>Examples</h5>
        <code>
ToScottishScreaming(""hello world"") ➞ ""HELLE WERLD""

ToScottishScreaming(""Mr. Fox was very naughty"") ➞ ""MR. FEX WES VERY NEEGHTY""

ToScottishScreaming(""Butterflies are beautiful!"") ➞ ""BETTERFLEES ERE BEEETEFEL!""
            </p>
        </code>

Notes
Make sure to include all punctuation that is in the original string.
You don't need any more namespaces than are already given.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
