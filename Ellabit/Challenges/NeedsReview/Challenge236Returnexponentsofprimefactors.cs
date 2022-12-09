namespace Ellabit.Challenges
{
    public class Challenge236Returnexponentsofprimefactors : IChallenge
    {
        public string? Header { get; set; } = "Return exponents of prime factors";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
  	public  int[] ProductEqualTarget(int[] arr, int target) {
		
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
        int[] sumResult;
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
        int[] sumResult;
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
";
        public string? Description { get; set; } = @"You are given a list of prime factors arr and a target. When each number in the list is raised to an appropriate power their product will be equal to the target.

Your role is to return the exponents. All these lists will have a length of three. Basically, it is three numbers whose product is equal to challenge. The only difference is what you are expected to return.

Examples
ProductEqualTarget(new int[] { 2, 3, 5 }, 600) ➞ [3, 1, 2]
// Because 2^3*3^1*5^2 = 600

ProductEqualTarget(new int[] { 2, 3, 5 }, 720) ➞ [4, 2, 1]
// Because 2^4*3^2*5^1 = 720
Notes
The exponents you will return are expected to replace the base in the list.
Your returned values must be in the same order as the bases.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
