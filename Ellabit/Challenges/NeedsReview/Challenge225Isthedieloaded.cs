namespace Ellabit.Challenges
{
    public class Challenge225Isthedieloaded : IChallenge
    {
        public string? Header { get; set; } = "Is the die loaded";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
  	public  bool FairDie(int[] arr) {
			
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
        bool sumResult;
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
        bool sumResult;
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
        bool sumResult;
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
        public string? Description { get; set; } = @"The Chi-Squared (χ²) goodness of fit test estimates if an empirical (observed) distribution fits a theoretical (expected) distribution within reasonable margins. For example, to figure out if a die is loaded you could roll it many times and note the results. Because of randomness, you can't expect to get the same frequency for all faces, but if one or more faces turn up much more frequently than some others, it is reasonable to assume the die is loaded.

The formula to calculate the Chi-Square parameter is:
Χ² = ∑ (Oi – Ei)2/Ei

Chi-squared

Below is an example of a die rolled 600 times:

<table>
<th><td><b>Face</b></td><td><b>1</b></td><td><b>2</b></td><td><b>3</b></td><td><b>4</b></td><td><b>5</b></td><td><b>6</b></th></tr>
<tr><td>Observed frequency</td><td>101</td><td>116</td><td>89</td><td>108</td><td>97</td><td>89</td></tr>
<tr><td>Expected frequency</td><td>100</td><td>100</td><td>100</td><td>100</td><td>100</td><td>100</td></tr>
<tr><td>Difference</td><td>1</td><td>16</td><td>-11</td><td>8</td><td>-3</td><td>-11</td></tr>
</table>

In this example, the Chi-Square parameter has a value of:

χ² = ((1)^2 + (16)^2 + (-11)^2 + (8)^2 + (-3)^2 + (-11)^2) / 100 = 5.72
This parameter is then compared to a critical value, calculated taking into account the number of categories and the confidence level. Here, the critical value is 11.0705. Since 5.72 < 11.0705, it is safe to assume the die is unloaded.

Given a list with the six observed frequencies, write a function that returns true if a die is unloaded, or false if it is loaded. Take 11.0705 as the critical value for all cases.

Examples
FairDie([44, 52, 33, 40, 41, 30]) ➞ true
(χ² = 7.75) < 11.0705

FairDie([34, 27, 23, 20, 32, 28]) ➞ true
(χ² = 1.6) < 11.0705

FairDie([10, 20, 11, 5, 19, 16]) ➞ false
(χ² = 12.556) > 11.0705
Notes
N/A";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
