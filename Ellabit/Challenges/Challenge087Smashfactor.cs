namespace Ellabit.Challenges
{
    public class Challenge087Smashfactor : IChallenge
    {
        public string? Header { get; set; } = "Smash factor";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
public class Challenge
{
	public  double SmashFactor(double a, double b)
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
        double sumResult = 0;
        try 
        {
            sumResult = tmp.SmashFactor(139.4, 93.8) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1.49,   $""returned: {sumResult}  expected: 1.49"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult = 0;
        try 
        {
            sumResult = tmp.SmashFactor(181.2, 124.5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1.46,   $""returned: {sumResult}  expected: 1.46"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult = 0;
        try 
        {
            sumResult = tmp.SmashFactor(154.7, 104.3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 1.48,   $""returned: {sumResult}  expected: 1.48"");
    }
}
";
        public string? Description { get; set; } = @"Smash factor is a term in golf that relates to the amount of energy transferred from the club head to the golf ball. The formula for calculating smash factor is ball speed divided by club speed.

Create a function that takes ball speed a and club speed b as arguments and returns the smash factor to the nearest hundredth.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
SmashFactor(139.4, 93.8) ➞ 1.49

SmashFactor(181.2, 124.5) ➞ 1.46

SmashFactor(154.7, 104.3) ➞ 1.48
            </p>
        </code>

Notes
Remember to round to the nearest hundredth.
All values will be valid (so no dividing by zero).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
