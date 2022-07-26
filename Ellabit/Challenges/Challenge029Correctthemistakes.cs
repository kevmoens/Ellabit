namespace Ellabit.Challenges
{
    public class Challenge029Correctthemistakes : IChallenge
    {
        public string? Header { get; set; } = "Correct the mistakes";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  int Squaed(int b) 
	{
		return a * a;
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
            sumResult = tmp.Squared(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 25,  $""returned: {sumResult}  expected: 25"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Squared(9);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 81,   $""returned: {sumResult}  expected: 81"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Squared(100);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 10000,   $""returned: {sumResult}  expected: 10000"");
    }
}
";
        public string? Description { get; set; } = @"Fix the code in the code tab to pass this challenge (only syntax errors). look at the examples below to get an idea of what the function should do.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
squared(5) ➞ 25

squared(9) ➞ 81

squared(100) ➞ 10000
            </p>
        </code>

notes
read every word carefully, character by character!
don't overthink this challenge; it's not supposed to be hard.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Bug", "Spelling" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
