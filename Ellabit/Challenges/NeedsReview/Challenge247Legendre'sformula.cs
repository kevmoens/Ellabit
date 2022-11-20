namespace Ellabit.Challenges
{
    public class Challenge247Legendresformula : IChallenge
    {
        public string? Header { get; set; } = "Legendre's formula";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int Legendre(int p, int n) {
		
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
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2>"");
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
        public string? Description { get; set; } = @"Legendre's formula finds the exponent of the largest power of some prime p that divides (is a factor of) the factorial of some number n.
legendre's formula example 2 and 27):
Legendre's formula
so 2^23 is the largest power of 2 that divides 27!.
the formula returns the sum of many fractions (rounded down) with n as the numerator and a steadily inc Legendre's formula finds the exponent of the largest power of some prime p that divides (is a factor of) the factorial of some number n.
legendre's formula example 2 and 27):
Legendre's formula
so 2^23 is the largest power of 2 that divides 27!.
            the formula returns the sum of many fractions (rounded down) with n as the numerator and a steadily inc";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
