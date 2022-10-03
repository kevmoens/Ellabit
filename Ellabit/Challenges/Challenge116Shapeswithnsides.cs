namespace Ellabit.Challenges
{
    public class Challenge116Shapeswithnsides : IChallenge
    {
        public string? Header { get; set; } = "Shapes with n sides";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string NSidedShape(int n)
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
        string sumResult;
        try 
        {
            sumResult = tmp.NSidedShape(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""triangle"",  $""returned: {sumResult}  expected: triangle"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.NSidedShape(1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""circle"",   $""returned: {sumResult}  expected: circle"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.NSidedShape(9);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""nonagon"",   $""returned: {sumResult}  expected: nonagon"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a whole number as input and returns the shape with that number's amount of sides. Here are the expected outputs to get from these inputs.

Inputs	Outputs
1	""circle""
2	""semi-circle""
3	""triangle""
4	""square""
5	""pentagon""
6	""hexagon""
7	""heptagon""
8	""octagon""
9	""nonagon""
10	""decagon""

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
NSidedShape(3) ➞ ""triangle""

NSidedShape(1) ➞ ""circle""

NSidedShape(9) ➞ ""nonagon""
            </p>
        </code>
Notes
There won't be any tests with a number below 1 or greater than 10.
Return the output in lowercase.
The challenge is intended to be completed without conditionals(it would take too long)!";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
