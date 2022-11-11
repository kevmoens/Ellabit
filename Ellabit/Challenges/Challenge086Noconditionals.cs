namespace Ellabit.Challenges
{
    public class Challenge086Noconditionals : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "No conditionals?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  int Flip(int y)
	{
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Flip(1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  0,  $""returned: {sumResult}  expected:  0"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Flip(0) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1,   $""returned: {sumResult}  expected:  1"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that returns 0 if the input is 1, and returns 1 if the input is 0.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
flip(1) ➞ 0

flip(0) ➞ 1
            </p>
        </code>

notes
try completing this challenge without using any:
conditionals
ternary operators
negations
bit operators";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Statements", "If" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
