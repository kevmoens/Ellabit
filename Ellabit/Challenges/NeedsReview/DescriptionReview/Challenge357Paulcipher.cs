namespace Ellabit.Challenges
{
    public class Challenge357PaulCipher : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Paul cipher";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

using System;

public class Challenge
{
  	public  string PaulCipher(string txt) 
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
                sumResult = tmp.PaulCipher(""muBas41r"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == ""MHWCT41K"",  $""returned: {sumResult}  expected: MHWCT41K"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
                sumResult = tmp.PaulCipher(""a1rForce"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == ""A1SXUGUH"",  $""returned: {sumResult}  expected: A1SXUGUH"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
                sumResult = tmp.PaulCipher(""MATT"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == ""MNUN"",  $""returned: {sumResult}  expected: MNUN"");
        }
    }
}
";
        public string? Description { get; set; } = @"<div><p><span>In </span><strong><span>Paul Cipher</span></strong><span>, only alpha characters will be encoded with the following rules:</span></p><ul><li><span>All alpha characters will be treated as uppercase letters.</span></li><li><span>The first alpha character will not change (except for switching to upper case).</span></li><li><span>All subsequent alpha characters will be shifted toward ""Z"" by the alphabetical position of the previous alpha character (wrap back to ""A"" if ""Z"" is passed).</span></li></ul><p><code>he1lo</code><span> would be encoded as follows:</span></p><pre><code>PaulCipher(""he1lo"") ➞ ""HM1QA""

h -&gt; H (First character to be changed to uppercase)
e -&gt; M (H is the previous alpha character and 8th letter in the alphabets. E + 8 = M)
1 -&gt; 1 (Keep all characters other than alphabets as it is)
l -&gt; Q (E is the previous alpha character and 5th letter in the alphabets. L + 5 = Q)
o -&gt; A (L is the previous alpha character and 12th letter in the alphabets. O + 12 = A)</code></pre><p><span>Given a string </span><code>txt</code><span>, return the encoded message. See the below examples for a better understanding:</span></p><h3><span>Examples</span></h3><pre><code>PaulCipher(""muBas41r"") ➞ ""MHWCT41K""

PaulCipher(""a1rForce"") ➞ ""A1SXUGUH""

PaulCipher(""MATT"") ➞ ""MNUN""</code></pre><h3><span>Notes</span></h3><p><span>N/A</span></p></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
