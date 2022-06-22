namespace Ellabit.Challenges
{
    public class Challenge033Profitablegamble : IChallenge
    {
        public string? Header { get; set; } = "Profitable gamble";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  bool ProfitableGamble(double prob, int prize, double pay) 
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
            sumResult = tmp.ProfitableGamble(0.2, 50, 9);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.ProfitableGamble(0.9, 1, 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.ProfitableGamble(0.9, 3, 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes three arguments prob, prize, pay and returns true if prob * prize > pay; otherwise return false.

To illustrate:

ProfitableGamble(0.2, 50, 9)

... should yield true, since the net profit is 1 (0.2 * 50 - 9), and 1 > 0.

Examples

ProfitableGamble(0.2, 50, 9) ➞ true

ProfitableGamble(0.9, 1, 2) ➞ false

ProfitableGamble(0.9, 3, 2) ➞ true

Notes
A profitable gamble is a game that yields a positive net profit, where net profit is calculated in the following manner: net_outcome = probability_of_winning * prize - cost_of_playing.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
