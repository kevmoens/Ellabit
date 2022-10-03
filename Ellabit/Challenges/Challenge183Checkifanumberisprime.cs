namespace Ellabit.Challenges
{
    public class Challenge183Checkifanumberisprime : IChallenge
    {
        public string? Header { get; set; } = "Check if a number is prime";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
	    public bool isPrime(int x)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.isPrime(31)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isPrime(18)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false, $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isPrime(11);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  returns  true  if  a  number  is  prime,  and  false  otherwise.  a  prime  number  is  any  positive  integer  that  is  evenly  divisible  by  only  two  divisors:  1  and  itself.

the  first  ten  prime  numbers  are:

2,  3,  5,  7,  11,  13,  17,  19,  23,  29

        <h5>Examples</h5>
        <code>
isprime(31)  ➞  true

isprime(18)  ➞  false

isprime(11)  ➞  true
            </p>
        </code>
notes
a  prime  number  has  no  other  factors except 1 and itself.
If a number is odd it is not divisible by an even number.
1 is not considered a prime number.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
