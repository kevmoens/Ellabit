namespace Ellabit.Challenges
{
    public class Challenge335Deadendnumbersequence : IChallenge
    {
        public string? Header { get; set; } = "Dead end number sequence";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  long[] DeadEnd(long n) {
		
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
        long[] sumResult;
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
        long[] sumResult;
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
        long[] sumResult;
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
        public string? Description { get; set; } = @"This number sequence can start with any positive integer n. s is the sum of the individual digits in n. If s divides into n evenly then the next term of the series is n//s. Otherwise the next term is n*s. Eventually the series will reach a dead end with two numbers alternating: 58, 754, 12064, 928, 17632, 928, 17632. This series has a length of 5 with 17632 as the last term.

Compose a function that takes a positive integer and returns its series length and its last term.

Examples
deadEnd(5) ➞ [2, 1]

deadEnd(11) ➞ [7, 11440]

deadEnd(123456789) ➞ [2, 5555555505]

deadEnd(35161) ➞ [39, 154838313273413215779502672965210112000]

deadEnd(101) ➞ [9, 136804096]";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
