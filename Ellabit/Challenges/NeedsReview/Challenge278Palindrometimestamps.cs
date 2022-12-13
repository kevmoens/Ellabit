namespace Ellabit.Challenges
{
    public class Challenge278Palindrometimestamps : IChallenge
    {
        public string? Header { get; set; } = "Palindrome timestamps";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
  public  int PalendromeTimestamps(int h1, int m1, int s1, int h2, int m2, int s2) {
		
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
        public string? Description { get; set; } = @"Create a function that takes two times of day (hours, minutes, seconds) and returns the number of occurences of palindrome timestamps within that range, inclusive.

A palindrome timestamp should be read the same hours : minutes : seconds as seconds : minutes : hours, keeping in mind the seconds and hours digits will reverse. For example, 02 : 11 : 20 is a palindrome timestamp.

Examples
PalendromeTimestamps(2, 12, 22, 4, 35, 10) ➞ 14

PalendromeTimestamps(12, 12, 12, 13, 13, 13) ➞ 6

PalendromeTimestamps(6, 33, 15, 9, 55, 10) ➞ 0
Notes
Expect military time.
Include the given time parameters if they happen to be palendromes.
The parameter timestamps are chronological.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
