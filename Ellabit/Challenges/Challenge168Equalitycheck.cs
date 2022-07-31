namespace Ellabit.Challenges
{
    public class Challenge168Equalitycheck : IChallenge
    {
        public string? Header { get; set; } = "Equality check";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

using System.Reflection;

public class Challenge
{
	public  bool CheckEquality(object a, object b)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEquality(1, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEquality(0, ""0"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEquality(1,  1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
}";
        public string? Description { get; set; } = @"In this challenge, you must verify the equality of two different values given the parameters a and b.

Both the value and type of the parameters need to be equal. The possible types of the given parameters are:

Numbers
Strings
Booleans (false or true)
What have you learned so far that will permit you to do two different checks (value and type) with a single statement?

Implement a function that returns true if the parameters are equal, and false if they are not.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
CheckEquality(1, true) ➞ false
// A number and a boolean: the value and type are different.

CheckEquality(0, ""0"") ➞ false
// A number and a string: the type is different.

CheckEquality(1,  1) ➞ true
// A number and a number: the type and value are equal.
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
