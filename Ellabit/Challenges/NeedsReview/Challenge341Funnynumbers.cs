namespace Ellabit.Challenges
{
    public class Challenge341Funnynumbers : IChallenge
    {
        public string? Header { get; set; } = "Funny numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  int? FunnyNumbers(int n, int p) {
			
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
        int? sumResult;
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
        int? sumResult;
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
        int? sumResult;
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
        public string? Description { get; set; } = @"Mubashir was playing with some numbers. He observed some funny numbers.

Funny Numbers
89 --> 8¹ + 9² = 89 * 1

695 --> 6² + 9³ + 5⁴ = 1390 = 695 * 2

46288 --> 4³ + 6⁴ + 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51
Create a function which takes a number n and a positive integer p and returns a positive integer k, such as the sum of the digits of n taken to the successive powers of p is equal to k * n.

In other words, is there an integer k such as:

(a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ... ) = n * k
// A given number = n
// A given positive integer = p
// Digits of the given number = a, b, c, d ...
// A positive integer = k
Your function should return null if k is not found.

Examples
funnyNumbers(89, 1) ➞ 1
// since 8¹ + 9² = 89 = 89 * 1

funnyNumbers(92, 1) ➞ null
// since there is no k such as 9¹ + 2² equals 92 * k

funnyNumbers(695, 2) ➞ 2
// 6² + 9³ + 5⁴= 1390 = 695 * 2
Notes
Given number and power will always >=1";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
