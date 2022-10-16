namespace Ellabit.Challenges
{
    public class Challenge191StringEscape: IChallenge
    {
        public string? Header { get; set; } = "Return a string containing special characters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
public class Challenge 
{
	public string GetQuotation() 
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
            string str = tmp.GetQuotation();
            Console.WriteLine(str);
            if (str.StartsWith(""\"""") && str.EndsWith(""\""""))
            {
                sumResult = true;
            } else
            {
                sumResult = false;
            }
        } catch (Exception ex)
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true, $""test returned: {sumResult}  expected: true"");
    }

}
}";
        public string? Description { get; set; } = @"
            Create a fonction that returns a string containing quotation marks.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                GetQuotation() → ""Hello World!""
                <br/>
                GetQuotation() → ""Some string""
                <br/>
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1"}.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) { { "String", "Special characters" }, { "Level", "1" } };
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}