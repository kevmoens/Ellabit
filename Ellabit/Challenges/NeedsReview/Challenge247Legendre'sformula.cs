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

Legendre's formula example (p = 2 and n = 27):

<table>
<tr>
<td>e<sub>2</sub>(27!)</td>
<td> |27/2| + |27/2<sup>2</sup>| + |27/2<sup>3</sup>| + |27/2<sup>4</sup>|</td>
</tr>
<tr><td></td><td> = 13 + 6 + 3 + 1</td></tr>
<tr><td></td><td> = 23</td></tr>
</table>

Legendre's Formula

So 2^23 is the largest power of 2 that divides 27!.

The formula returns the sum of many fractions (rounded down) with n as the numerator and a steadily increasing power of p as the denominator, stopping when it exceeds the numerator.

To illustrate:

p = 5
n = 100

int(100/5) + int(100/25)
// No 100/125 because 125 > 100.
p = 2
n = 128

int(128/2) + int(128/4) + int(128/8) + ... + int(128/128)
Given p and n, return the result of Legendre's formula (see Resources).

Examples
Legendre(5, 100) ➞ 24

Legendre(2, 128) ➞ 127

Legendre(3, 50) ➞ 22
Notes
p and n will be positive integers.
When p exceeds n, the result should be 0.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
