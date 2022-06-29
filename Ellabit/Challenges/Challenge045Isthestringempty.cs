namespace Ellabit.Challenges
{
    public class Challenge045Isthestringempty : IChallenge
    {
        public string? Header { get; set; } = "Is the string empty?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  bool isEmpty(string str)
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
            sumResult = tmp.isEmpty("""");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isEmpty("" "");
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
            sumResult = tmp.isEmpty(""a"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that returns true if a string is empty and false otherwise.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
isEmpty("""") ➞ true

isEmpty("" "") ➞ false

isEmpty(""a"") ➞ false
            </p>
        </code>
Notes
A string containing only whitespaces "" "" does not count as empty.
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
