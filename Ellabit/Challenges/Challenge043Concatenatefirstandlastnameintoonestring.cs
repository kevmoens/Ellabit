namespace Ellabit.Challenges
{
    public class Challenge043Concatenatefirstandlastnameintoonestring : IChallenge
    {
        public string? Header { get; set; } = "Concatenate first and last name into one string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  string ConcatName(string firstName, string lastName)
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
        string sumResult;
        try 
        {
            sumResult = tmp.ConcatName(""First"", ""Last"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Last, First"",  $""returned: {sumResult}  expected: Last, First"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ConcatName(""John"", ""Doe"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Doe, John"",   $""returned: {sumResult}  expected: Doe, John"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ConcatName(""Mary"", ""Jane"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Jane, Mary"",   $""returned: {sumResult}  expected: Jane, Mary"");
    }
}
";
        public string? Description { get; set; } = @"Given two strings, firstName and lastName, return a single string in the format ""last, first"".

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
ConcatName(""First"", ""Last"") ➞ ""Last, First""

ConcatName(""John"", ""Doe"") ➞ ""Doe, John""

ConcatName(""Mary"", ""Jane"") ➞ ""Jane, Mary""
            </p>
        </code>

Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
