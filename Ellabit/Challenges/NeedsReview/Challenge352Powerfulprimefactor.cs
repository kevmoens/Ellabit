namespace Ellabit.Challenges
{
    public class Challenge352Powerfulprimefactor : IChallenge
    {
        public string? Header { get; set; } = "Powerful prime factor";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
  	public  string ExpressFactors(int n) 
	{
		
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
        string sumResult;
        try 
        {
            sumResult = tmp.expressfactors(2)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   "" 2"" ,  $""returned: {sumResult}  expected:  2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.expressfactors(4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""2^2"" ,   $""returned: {sumResult}  expected: 2^2"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.expressfactors(10);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""2 x 5"" ,   $""returned: {sumResult}  expected: 2 x 5"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a positive integer and returns a string expressing how the number can be made by multiplying powers of its prime factors.

Examples
expressFactors(2) ➞ ""2""

expressFactors(4) ➞ ""2^2""

expressFactors(10) ➞ ""2 x 5""

expressFactors(60) ➞ ""2^2 x 3 x 5""
Notes
All inputs will be positive integers in the range 1 < n < 10,000.
If a factor is repeated express it in the form ""x^y"" where x is the factor and y is the number of repetitions of the factor.
If n is a prime number, return n as a string as in example #1 above.
Factors should appear in ascending order in the expression.
Make sure you include the space either side of the multiplication sign, "" x "".
Check the Resources if you need to understand Prime Factorization.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
