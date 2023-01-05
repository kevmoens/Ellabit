namespace Ellabit.Challenges
{
    public class Challenge353FindMissingAlphabets : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Find missing alphabets";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

using System;

public class Challenge
{
    public  string MissingAlphabets(string str) {
		
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
            sumResult = tmp.missingalphabets("" abcdefghijklmnopqrstuvwxy"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""z"" is missing. ,  $""returned: {sumResult}  expected: z is missing."");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
}
";
        public string? Description { get; set; } = @"<div><p><span>Create a function that takes a string </span><code>str</code><span> containing only letters from </span><strong><span>a to z</span></strong><span> in lowercase and returns the </span><strong><span>missing letter(s)</span></strong><span> in alphabetical order a-z.</span></p><ul><li><span>A set of letters is given by </span><code>abcdefghijklmnopqrstuvwxyz</code><span>.</span></li><li><span>Two sets of alphabets means two or more alphabets.</span></li></ul><h3><span>Examples</span></h3><pre><code>MissingAlphabets(""abcdefghijklmnopqrstuvwxy"") ➞ ""z""
// ""z"" is missing.

MissingAlphabets(""aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyy"") ➞ ""zz""
// Given string has a set of two alphabets so output will be ""zz""

MissingAlphabets(""edabit"") ➞ ""cfghjklmnopqrsuvwxyz""</code></pre><h3><span>Notes</span></h3><p><span>If the string contains all letters from </span><code>a-z</code><span>, return an empty string </span><code>""""</code><span>.</span></p></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
