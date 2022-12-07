namespace Ellabit.Challenges
{
    public class Challenge220Letterdistance : IChallenge
    {
        public string? Header { get; set; } = "Letter distance";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int LetterDistance(string str1, string str2) {
	  	
	}	
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
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
        int sumResult;
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
";
        public string? Description { get; set; } = @"Given two words, the letter distance is calculated by taking the absolute value of the difference in character codes and summing up the difference.

If one word is longer than another, add the difference in lengths towards the score.

To illustrate:

letterDistance(""house"", ""fly"") = dist(""h"", ""f"") + dist(""o"", ""l"") + dist(""u"", ""y"") + dist(house.Length, fly.Length)

= |104 - 102| + |111 - 108| + |117 - 121| + |5 - 3|
= 2 + 3 + 4 + 2
= 11
Examples
LetterDistance(""sharp"", ""sharq"") ➞ 1

LetterDistance(""abcde"", ""Abcde"") ➞ 32

LetterDistance(""abcde"", ""bcdef"") ➞ 5
Notes
Always start comparing the two strings from their first letter.
Excess letters are not counted towards distance.
Capital letters are included.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
