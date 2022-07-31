namespace Ellabit.Challenges
{
    public class Challenge057Checkstringforspaces : IChallenge
    {
        public string? Header { get; set; } = "Check string for spaces";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  bool HasSpaces(string str)
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
            sumResult = tmp.HasSpaces(""hello"");
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
            sumResult = tmp.HasSpaces(""hello, world"");
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
            sumResult = tmp.HasSpaces("" "");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.HasSpaces("""");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.HasSpaces("",./!@#"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that returns true if a string contains any spaces.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
HasSpaces(""hello"") ➞ false

HasSpaces(""hello, world"") ➞ true

HasSpaces("" "") ➞ true

HasSpaces("""") ➞ false

HasSpaces("",./!@#"") ➞ false
            </p>
        </code>
Notes
An empty string does not contain any spaces.
Try doing this without RegEx.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
