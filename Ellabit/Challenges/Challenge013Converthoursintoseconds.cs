namespace Ellabit.Challenges
{
    public class Challenge013Converthoursintoseconds : IChallenge
    {
        public string? Header { get; set; } = "Convert hours into seconds";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  int HowManySeconds(int hours)
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
            sumResult = tmp.HowManySeconds(2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  7200,  $""returned: {sumResult}  expected:  7200"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HowManySeconds(10) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  36000,   $""returned: {sumResult}  expected:  36000"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HowManySeconds(24) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  86400,   $""returned: {sumResult}  expected:  86400"");
    }
}
";
        public string? Description { get; set; } = @"Write a function that converts hours into seconds.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
howmanyseconds(2) ➞ 7200

howmanyseconds(10) ➞ 36000

howmanyseconds(24) ➞ 86400
            </p>
        </code>

notes
60 seconds in a minute, 60 minutes in an hour.
don't forget to return your answer.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
