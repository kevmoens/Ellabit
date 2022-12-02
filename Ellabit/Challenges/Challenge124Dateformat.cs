namespace Ellabit.Challenges
{
    public class Challenge124Dateformat : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Date format";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  string FormatDate(string date) 
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
            sumResult = tmp.FormatDate(""11/12/2019"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""20191211"",  $""returned: {sumResult}  expected: 20191211"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FormatDate(""12/31/2019"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""20193112"",   $""returned: {sumResult}  expected: 20193112"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FormatDate(""01/15/2019"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""20191501"",   $""returned: {sumResult}  expected: 20191501"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
FormatDate(""11/12/2019"") ➞ ""20191211""

FormatDate(""12/31/2019"") ➞ ""20193112""

FormatDate(""01/15/2019"") ➞ ""20191501""
            </p>
        </code>
Notes
Return value should be a string.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Date", "Format" },{ "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
