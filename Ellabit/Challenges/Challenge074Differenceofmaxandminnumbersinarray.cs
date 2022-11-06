namespace Ellabit.Challenges
{
    public class Challenge074Differenceofmaxandminnumbersinarray : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Difference of max and min numbers in array";
        public string? Code { get; set; } = @"
using System;
using System.Linq;

namespace Ellabit {

public class Challenge 
{
	public  int differenceMaxMin(int[] arr) 
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
            sumResult = tmp.differenceMaxMin(new int[] {10, 4, 1, 4, -10, -50, 32, 21}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  82,  $""returned: {sumResult}  expected:  82"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.differenceMaxMin(new int[] {44, 32, 86, 19});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 67,   $""returned: {sumResult}  expected: 67"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes an array and returns the difference between the biggest and smallest numbers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
differencemaxmin([10, 4, 1, 4, -10, -50, 32, 21]) ➞ 82
// smallest number is -50, biggest is 32.

differencemaxmin([44, 32, 86, 19]) ➞ 67
// smallest number is 19, biggest is 86.
            </p>
        </code>

";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Array", "Math" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
