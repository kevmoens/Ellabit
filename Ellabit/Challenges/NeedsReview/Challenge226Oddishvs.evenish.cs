namespace Ellabit.Challenges
{
    public class Challenge226Oddishvsevenish : IChallenge
    {
        public string? Header { get; set; } = "Oddish vs. evenish";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string OddishOrEvenish(int num) 
    {
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
        string sumResult;
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
";
        public string? Description { get; set; } = @"Create a function that determines whether a number is Oddish or Evenish. A number is Oddish if the sum of all of its digits is odd, and a number is Evenish if the sum of all of its digits is even. If a number is Oddish, return ""Oddish"". Otherwise, return ""Evenish"".

For example, OddishOrEvenish(121) should return ""Evenish"", since 1 + 2 + 1 = 4. OddishOrEvenish(41) should return ""Oddish"", since 4 + 1 = 5.

Examples
OddishOrEvenish(43) ➞ ""Oddish""
// 4 + 3 = 7
// 7 % 2 = 1

OddishOrEvenish(373) ➞ ""Oddish""
// 3 + 7 + 3 = 13
// 13 % 2 = 1

OddishOrEvenish(4433) ➞ ""Evenish""
// 4 + 4 + 3 + 3 = 14
// 14 % 2 = 0";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
