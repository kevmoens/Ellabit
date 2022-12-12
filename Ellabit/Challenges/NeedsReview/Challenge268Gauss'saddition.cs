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
        public string? Description { get; set; } = @"Gauss's Addition is a mathematical technique named after the famous mathematician Carl Friedrich Gauss. It is a method for quickly calculating the sum of a series of numbers, using a clever trick to avoid having to add all of the numbers individually. Here is an example of how it works:
Suppose you are asked to find the sum of the first 100 numbers. You could add the numbers individually, starting with 1 and going up to 100, but this would be a long and tedious process. Instead, you can use Gauss's Addition to find the sum quickly.

Here is how it works:

First, pair up the first and last numbers of the series (1 and 100, in this case).
Next, add these two numbers together to get the sum of the first and last numbers (1 + 100 = 101).
Repeat this process for the second and second-to-last numbers (2 and 99), and so on, until all of the numbers have been paired up.
Finally, add up all of the pairs of numbers to find the sum of the entire series.



Create a function that adds all the numbers together from 1 to n or, if two numbers are given: n to m. The input can be in any order.

Examples
Gauss({ 100 }) ➞ 5050 // From the video

Gauss({ 5001, 7000 }) ➞ 12001000 // Also ^^

Gauss({ 1975, 165 }) ➞ 1937770
Notes
Try not to use a for or while loop.
Try not to create a recursive function.
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
