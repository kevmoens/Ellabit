namespace Ellabit.Challenges
{
    public class Challenge201PitoNDecimalPlaces : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Pi to n decimal places";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{


public class Challenge 
{
    public  decimal MyPi(int n) 
    {
    	
    }
}


}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
    {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        decimal sumResult;
        try 
        {
            sumResult = tmp.mypi(5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == 3.14159,  $""returned: {sumResult}  expected: 3.14159"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        decimal sumResult;
        try 
        {
            sumResult = tmp.mypi(4)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == 3.1416,  $""returned: {sumResult}  expected: 3.1416"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        decimal sumResult;
        try 
        {
            sumResult = tmp.mypi(15)  ;
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 3.141592653589793,  $""returned: {sumResult}  expected: 3.141592653589793"");
        }
    }
}
";
        public string? Description { get; set; } = @"<div><p><span>Given a number </span><code>n</code><span>, write a function that returns PI to </span><code>n</code><span> decimal places.</span></p><h3><span>Examples</span></h3><pre><code>MyPi(5) ➞ 3.14159

mypi(4)  ➞  3.1416

MyPi(15) ➞ 3.141592653589793</code></pre><h3><span>Notes</span></h3><ul><li><code>n</code><span> will not be above 15, to keep this challenge simple.</span></li><li><span>Round up the last digit if the next digit in PI is greater or equal to 5 (see second example above).</span></li><li><span>The return value must be a number (add  suffix -m to returning number), not a string.</span></li></ul></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
