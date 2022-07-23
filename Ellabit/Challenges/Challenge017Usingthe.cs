namespace Ellabit.Challenges
{
    public class Challenge017Usingthe : IChallenge
    {
        public string? Header { get; set; } = "Using the && Operator";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  bool And(bool x, bool y)
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
            sumResult = tmp.And(true, false);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.And(true, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.And(false, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.And(false, false);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"C# has a logical operator &&. the && operator takes two boolean values, and returns true if both values are true.

consider a && b:

a is checked if it is true or false.
if a is false, false is returned.
b is checked if it is true or false.
if b is false, false is returned.
otherwise, true is returned (as both a and b are therefore true ).
rembember that the default value for bool is false.

The && operator will only return true for true && true.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
And(true, false) ➞ false

And(true, true) ➞ true

And(false, true) ➞ false

And(false, false) ➞ false
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Expression", "&&" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
