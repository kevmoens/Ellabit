namespace Ellabit.Challenges
{
    public class Challenge056Returnastringasaninteger : IChallenge
    {
        public string? Header { get; set; } = "Return a string as an integer";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int StringInt(string txt) 
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.StringInt(""6"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 6,  $""returned: {sumResult}  expected: 6"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.StringInt(""1000"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1000,   $""returned: {sumResult}  expected: 1000"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.StringInt(""12"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 12,   $""returned: {sumResult}  expected: 12"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a string and returns it as an integer.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
StringInt(""6"") ➞ 6

StringInt(""1000"") ➞ 1000


StringInt(""12"") ➞ 12
            </p>
        </code>

Notes
All numbers will be whole.
All numbers will be positive.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
