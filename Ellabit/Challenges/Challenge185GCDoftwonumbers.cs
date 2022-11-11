namespace Ellabit.Challenges
{
    public class Challenge185GCDoftwonumbers : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "GCD of two numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
	    public  int gcd(int n1, int n2)
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
        int sumResult;
        try 
        {
            sumResult = tmp.gcd(32,  8)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   8,  $""returned: {sumResult}  expected: 8"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.gcd(8,  12)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   4,   $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.gcd(17,  13)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   1,   $""returned: {sumResult}  expected: 1"");
    }
}
}
";
        public string? Description { get; set; } = @"Write content  a  function  that  returns  the  greatest  common  divisor  (gcd)  of  two  integers.

        <h5>Examples</h5>
        <code>
gcd(32,  8)  ➞  8

gcd(8,  12)  ➞  4

gcd(17,  13)  ➞  1
            </p>
        </code>
Notes
both  values  will  be  positive.
the  gcd  is  the  largest  factor  that  divides  both  numbers.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        public bool ShowBlockly { get => true; }
    }
}
