namespace Ellabit.Challenges
{
    public class Challenge038Stacktheboxes : IChallenge
    {
        public string? Header { get; set; } = "Stack the boxes";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

using System;
public class Challenge
{
	public  int StackBoxes(int n)
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
            sumResult = tmp.StackBoxes(1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1,  $""returned: {sumResult}  expected:  1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.StackBoxes(2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  4,   $""returned: {sumResult}  expected:  4"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.StackBoxes(0);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 0,   $""returned: {sumResult}  expected: 0"");
    }
}
}";
        public string? Description { get; set; } = @"Here's an image of four models. some of the cubes are hidden behind other cubes. model one consists of one cube. model two consists of four cubes, and so on...

stack the boxes

write a function that takes a number n and returns the number of stacked boxes in a model n levels high, visible and invisible.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
stackboxes(1) ➞ 1

stackboxes(2) ➞ 4

stackboxes(0) ➞ 0
            </p>
        </code>

Notes
Step n is a positive integer.
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
