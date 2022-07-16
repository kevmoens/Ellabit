namespace Ellabit.Challenges
{
    public class Challenge096Convertnumbertostringofdashes : IChallenge
    {
        public string? Header { get; set; } = "Convert number to string of dashes";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  string Go(int num)
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
            sumResult = tmp.Go(1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""-"",   $""returned: {sumResult}  expected: -"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Go(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""-----"",   $""returned: {sumResult}  expected: -----"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Go(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""---"",   $""returned: {sumResult}  expected: ---"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a number (from 1 - 60) and returns a corresponding string of hyphens.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Go(1) ➞ ""-""

Go(5) ➞ ""-----""

Go(3) ➞ ""---""
            </p>
        </code>
Notes
You will be provided integers ranging from 1 to 60.
Don't forget to return your result as a string.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
