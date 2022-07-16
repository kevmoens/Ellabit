namespace Ellabit.Challenges
{
    public class Challenge031Dividesevenly : IChallenge
    {
        public string? Header { get; set; } = "Divides evenly";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  bool dividesEvenly(int a, int b) 
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
            sumResult = tmp.dividesEvenly(98, 7) ;
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
            sumResult = tmp.dividesEvenly(85, 4);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"Given two integers, a and b, return true if a can be divided evenly by b. return false otherwise.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
dividesevenly(98, 7) ➞ true
// 14

dividesEvenly(85, 4) ➞ false
// 21.25
            </p>
        </code>

Notes
a will always be greater than or equal to b.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
