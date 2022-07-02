namespace Ellabit.Challenges
{
    public class Challenge111Returnthefactorial : IChallenge
    {
        public string? Header { get; set; } = "Return the factorial";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  int Factorial(int num)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Factorial(3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  6,  $""returned: {sumResult}  expected:  6"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Factorial(5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  120,   $""returned: {sumResult}  expected:  120"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Factorial(13) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  6227020800,   $""returned: {sumResult}  expected:  6227020800"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an integer and returns the factorial of that integer. that is, the integer multiplied by all positive lower integers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
factorial(3) ➞ 6

factorial(5) ➞ 120

factorial(13) ➞ 6227020800
            </p>
        </code>

notes
assume all inputs are greater than or equal to 0.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
