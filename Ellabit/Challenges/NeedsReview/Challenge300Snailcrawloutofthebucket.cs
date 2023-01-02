namespace Ellabit.Challenges
{
    public class Challenge300Snailcrawloutofthebucket : IChallenge
    {
        public string? Header { get; set; } = "Snail crawl out of the bucket";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int Cal(int depth) {
			
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
        public string? Description { get; set; } = @"A snail fell into a bucket and wanted to crawl out. Assuming we already know the snail can climb 5cm per minute, the snail can crawl for 30 minutes continuously and then needs to rest for 10 minutes. When it is resting it will slide down 30cm.

How many minutes will it take for the snail to crawl out from different depths? Create a function that takes the bucket depth (the unit is cm) as an argument and returns the time in minutes.

if depth = 270
the snail crawling process
process: (150 - 30) +  150
minutes: (30+10) + 150 / 5
it will take 70 minutes
the last 150cm, the snail doesn't need a rest
Examples
Cal(31) ➞ 7

Cal(150) ➞ 30

Cal(200) ➞ 56
Notes
The depth is a positive integer.
If the time is less than one minute it still counts as one minute.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
