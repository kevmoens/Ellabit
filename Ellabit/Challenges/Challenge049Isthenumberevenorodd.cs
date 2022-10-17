namespace Ellabit.Challenges
{
    public class Challenge049Isthenumberevenorodd : IChallenge
    {
        public string? Header { get; set; } = "Is the number even or odd?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string IsEvenOrOdd(int num)
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
            sumResult = tmp.IsEvenOrOdd(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""odd"",  $""returned: {sumResult}  expected: odd"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.IsEvenOrOdd(146);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""even"",   $""returned: {sumResult}  expected: even"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.IsEvenOrOdd(19);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""odd"",   $""returned: {sumResult}  expected: odd"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a number as an argument and returns ""even"" for even numbers and ""odd"" for odd numbers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
isEvenOrOdd(3) ➞ ""odd""

isEvenOrOdd(146) ➞ ""even""

isEvenOrOdd(19) ➞ ""odd""
            </p>
        </code>
Notes
Dont forget to return the result.
Input will always be a valid integer.
Expect negative integers (whole numbers).
Tests are case sensitive (return ""even"" or ""odd"" in lowercase).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Parity" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyToolboxXML { get => string.Empty; }
        public string BlocklyXML { get => string.Empty; }
    }
}
