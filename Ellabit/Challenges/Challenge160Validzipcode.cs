namespace Ellabit.Challenges
{
    public class Challenge160Validzipcode : IChallenge
    {
        public string? Header { get; set; } = "Valid zip code";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  bool IsValid(string zip)
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
            sumResult = tmp.IsValid(""59001"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsValid(""853a7"");
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
            sumResult = tmp.IsValid(""732 32"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult ;
        try 
        {
            sumResult = tmp.IsValid(""393939"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Zip codes consist of 5 consecutive digits. given a string, write a function to determine whether the input is a valid zip code. a valid zip code is as follows:

must only contain numbers (no non-digits allowed).
must not contain any spaces.
must not be greater than 5 digits in length.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
IsValid(""59001"") ➞ true

IsValid(""853a7"") ➞ false

IsValid(""732 32"") ➞ false

IsValid(""393939"") ➞ false
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
