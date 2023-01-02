namespace Ellabit.Challenges
{
    public class Challenge355DistancetoNearestVowel : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Distance to nearest vowel";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

using System;
using System.Linq;

public class Challenge
{
	public  int[] DistanceToNearestVowel(string str)
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.distancetonearestvowel("" aaaaa"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  [0, 0, 0] ,  $""returned: {sumResult}  expected: [0, 0, 0]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.distancetonearestvowel(""babbb"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  [1, 1, 2, 3] ,   $""returned: {sumResult}  expected: [1, 1, 2, 3]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
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
        public string? Description { get; set; } = @"<div><p><span>Write a function that takes in a string and for each character, returns the distance to the nearest vowel in the string. If the character is a vowel itself, return </span><code>0</code><span>.</span></p><h3><span>Examples</span></h3><pre><code>DistanceToNearestVowel(""aaaaa"") ➞ [0, 0, 0, 0, 0]

DistanceToNearestVowel(""babbb"") ➞ [1, 0, 1, 2, 3]

DistanceToNearestVowel(""abcdabcd"") ➞ [0, 1, 2, 1, 0, 1, 2, 3]

DistanceToNearestVowel(""shopper"") ➞ [2, 1, 0, 1, 1, 0, 1]</code></pre><h3><span>Notes</span></h3><ul><li><span>All input strings will contain </span><strong><span>at least one vowel</span></strong><span>.</span></li><li><span>Strings will be lowercased.</span></li><li><span>Vowels are: </span><code>a, e, i, o, u</code><span>.</span></li></ul></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
