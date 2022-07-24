namespace Ellabit.Challenges
{
    public class Challenge027BuggycodePart4 : IChallenge
    {
        public string? Header { get; set; } = "Buggy code (part 4)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
	public  string greeting(string name) {
			return ""Hello, "" + name + ""!"";
			  if(name == ""Mubashir"") {
					return ""Hello, my Love!"";
				}
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
            sumResult = tmp.greeting(""Matt"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Hello, Matt!"",  $""returned: {sumResult}  expected: Hello, Matt!"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.greeting(""Helen"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Hello, Helen!"",  $""returned: {sumResult}  expected: Hello, Helen!"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.greeting(""Mubashir"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Hello, my Love!"",  $""returned: {sumResult}  expected: Hello, my Love!"");
    }
}
";
        public string? Description { get; set; } = @"Emmy has written a function that returns a greeting to users. however, she's in love with mubashir, and would like to greet him slightly differently. she added a special case in her function, but she made a mistake.

can you help her?

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
greeting(""Matt"") ➞ ""Hello, Matt!""

greeting(""Helen"") ➞ ""Hello, Helen!""

greeting(""Mubashir"") ➞ ""Hello, my Love!""
            </p>
        </code>

Notes
READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
Don't overthink this challenge; it's not supposed to be hard.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Bug", "Logic" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
