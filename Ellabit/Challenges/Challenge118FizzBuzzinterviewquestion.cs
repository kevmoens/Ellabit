namespace Ellabit.Challenges
{
    public class Challenge118FizzBuzzinterviewquestion : IChallenge
    {
        public string? Header { get; set; } = "FizzBuzz interview question";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string FizzBuzz(int n)
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
            sumResult = tmp.FizzBuzz(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Fizz"",  $""returned: {sumResult}  expected: Fizz"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FizzBuzz(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Buzz"",   $""returned: {sumResult}  expected: Buzz"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FizzBuzz(15);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""FizzBuzz"",   $""returned: {sumResult}  expected: FizzBuzz"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FizzBuzz(4);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""4"",   $""returned: {sumResult}  expected: 4"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a number as an argument and returns ""Fizz"", ""Buzz"" or ""FizzBuzz"".

If the number is a multiple of 3 the output should be ""Fizz"".
If the number given is a multiple of 5, the output should be ""Buzz"".
If the number given is a multiple of both 3 and 5, the output should be ""FizzBuzz"".
If the number is not a multiple of either 3 or 5, the number should be output on its own as shown in the examples below.
The output should always be a string even if it is not a multiple of 3 or 5.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
FizzBuzz(3) ➞ ""Fizz""

FizzBuzz(5) ➞ ""Buzz""

FizzBuzz(15) ➞ ""FizzBuzz""

FizzBuzz(4) ➞ ""4""
            </p>
        </code>
Notes
Try to be precise with how you spell things and where you put the capital letters.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
