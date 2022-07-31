namespace Ellabit.Challenges
{
    public class Challenge073Caseinsensitivecomparison : IChallenge
    {
        public string? Header { get; set; } = "Case insensitive comparison";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  bool match(string s1, string s2)
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
            sumResult = tmp.match(""hello"", ""hELLo"");
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
            sumResult = tmp.match(""motive"", ""emotive"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.match(""venom"", ""VENOM"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.match(""mask"", ""mAskinG"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that validates whether two strings are identical. Make it case insensitive.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
match(""hello"", ""hELLo"") ➞ true

match(""motive"", ""emotive"") ➞ false

match(""venom"", ""VENOM"") ➞ true

match(""mask"", ""mAskinG"") ➞ false
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
