namespace Ellabit.Challenges
{
    public class Challenge020Namegreeting : IChallenge
    {
        public string? Header { get; set; } = "Name greeting!";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
		public  string HelloName(string name)
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
            sumResult = tmp.HelloName(""Gerald"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Hello Gerald!"",  $""returned: {sumResult}  expected: Hello Gerald!"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HelloName(""Tiffany"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Hello Tiffany!"",  $""returned: {sumResult}  expected: Hello Tiffany!"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HelloName(""Ed"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Hello Ed!"",  $""returned: {sumResult}  expected: Hello Ed!"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a name and returns a greeting in the form of a string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
HelloName(""Gerald"") ➞ ""Hello Gerald!""

HelloName(""Tiffany"") ➞ ""Hello Tiffany!""

HelloName(""Ed"") ➞ ""Hello Ed!""
            </p>
        </code>
Notes
The input is always a name(as string).
Don't forget the exclamation mark!";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Concatenation" }, { "Expression", "==" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
