namespace Ellabit.Challenges
{
    public class Challenge115H4ck3rsp34k : IChallenge
    {
        public string? Header { get; set; } = "H4ck3r sp34k";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  string HackerSpeak(string str)
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
            sumResult = tmp.HackerSpeak(""javascript is cool"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""j4v45cr1pt 15 c00l"",  $""returned: {sumResult}  expected: j4v45cr1pt 15 c00l"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HackerSpeak(""programming is fun"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""pr0gr4mm1ng 15 fun"",   $""returned: {sumResult}  expected: pr0gr4mm1ng 15 fun"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HackerSpeak(""become a coder"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""b3c0m3 4 c0d3r"",   $""returned: {sumResult}  expected: b3c0m3 4 c0d3r"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string as an argument and returns a coded (h4ck3r 5p34k) version of the string.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
HackerSpeak(""javascript is cool"") ➞ ""j4v45cr1pt 15 c00l""

HackerSpeak(""programming is fun"") ➞ ""pr0gr4mm1ng 15 fun""

HackerSpeak(""become a coder"") ➞ ""b3c0m3 4 c0d3r""
            </p>
        </code>
Notes
In order to work properly, the function should replace all ""a""s with 4, ""e""s with 3, ""i""s with 1, ""o""s with 0, and ""s""s with 5.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
