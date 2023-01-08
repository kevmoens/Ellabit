namespace Ellabit.Challenges
{
    public class Challenge356XORCipher : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "XOR cipher";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{


public class Challenge 
{
	public  string XORCipher(string msg1, string msg2)
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
                sumResult = tmp.XORCipher(""11"" ""22"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == ""33"",  $""returned: {sumResult}  expected: 33"");
    }

        public (bool pass, string message) <rep.test.testname>()
    {
        var tmp = new Challenge();
            <rep.test.returnType> sumResult;
        try 
        {
                sumResult = tmp.<rep.test>;
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
    }
            return (<rep.test.resultCheck>,  $""returned: <rep.test.resultDisplay>  expected: <rep.test.resultVal>"");
        }
    }
}
";
        public string? Description { get; set; } = @"<div><p><span>In </span><strong><span>XOR Cipher</span></strong><span>, encoding is done by an XOR operation on two given strings. If the strings are of different lengths then the output should be the length of the shorter string. Cut the length of the longer string to the same size as the smaller string before XOR operation.</span></p><p><span>Given two strings of </span><code>msg1</code><span> and </span><code>msg2</code><span>, return the </span><strong><span>encoded message</span></strong><span>.</span></p><h3><span>Examples</span></h3><pre><code>XORCipher(""11"", ""22"") ➞ ""33""
// 11 XOR 22 = 33

XORCipher(""1020304"", ""403201"") ➞ ""501231""

XORCipher(""c611d9bdd9de38b9eb"", ""23a0745505d4d25494"") ➞ ""e5b1ade8dc0aeaed7f""</code></pre><h3><span>Notes</span></h3><p><span>A hint is in the </span><strong><span>Comments</span></strong><span> section.</span></p></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
