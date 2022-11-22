namespace Ellabit.Challenges
{
    public class Challenge268Gausssaddition : IChallenge
    {
        public string? Header { get; set; } = "Gauss's addition";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  long Gauss(long[] arr) {
		
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.gauss({ 100 }) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  5050 from the video,  $""returned: {sumResult}  expected:  5050 from the video"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.gauss({ 5001, 7000 }) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  12001000 also ^^,   $""returned: {sumResult}  expected:  12001000 also ^^"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3>"");
    }
}
";
        public string? Description { get; set; } = @"Watch the video about gauss's addition in the resources tab to see how you can use the formula for your function.

gauss

create a function that adds all the numbers together from 1 to n or, if two numbers are given: n to m. the input can be in any order.

examples
gauss({ 100 }) ➞ 5050 from the video

gauss({ 5001, 7000 }) ➞ 12001000 also ^^

gauss({ 19
Watch the video about gauss's addition in the resources tab to see how you can use the formula for your function.

gauss

create a function that adds all the numbers together from 1 to n or, if two numbers are given: n to m. the input can be in any order.

examples
gauss({ 100 }) ➞ 5050 from the video

gauss({ 5001, 7000 }) ➞ 12001000 also ^^

gauss({ 19";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
