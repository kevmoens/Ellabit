namespace Ellabit.Challenges
{
    public class Challenge028Checkifanintegerisdivisiblebyfive : IChallenge
    {
        public string? Header { get; set; } = "Check if an integer is divisible by five";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  bool divisibleByFive(int n)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.divisibleByFive(5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.divisibleByFive(-55) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.divisibleByFive(37) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
divisiblebyfive(5) ➞ true

divisiblebyfive(-55) ➞ true

divisiblebyfive(37) ➞ false
            </p>
        </code>

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
