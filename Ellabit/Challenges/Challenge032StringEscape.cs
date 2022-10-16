namespace Ellabit.Challenges
{
    public class Challenge032StringEscape: IChallenge
    {
        public string? Header { get; set; } = "Return a string containing special characters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
public class Challenge 
{
	public string GetQuotation(string str) 
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
                    sumResult = tmp.GetQuotation(""Hello World!"");
                } catch (Exception ex)
                {
                    return (false, ex.ToString() + "" "" + ex.Message);
                }
                return (sumResult == ""\""Hello World!\"""", $""test returned: {sumResult}  expected: \""Hello World!\"""");
            }
            public (bool pass, string message) Test2()
            {
                var tmp = new Challenge();
                string sumResult;
                try
                {
                    sumResult = tmp.GetQuotation(""Some string"");
                } catch (Exception ex)
                {
                    return (false, ex.ToString() + "" "" + ex.Message);
                }
                return (sumResult == ""\""Some string\"""", $""test returned: {sumResult}  expected: \""Some string\"""");
            }
            public (bool pass, string message) Test3()
            {
                var tmp = new Challenge();
                string sumResult;
                try
                {
                    sumResult = tmp.GetQuotation("" Whatever 12345 "");
                } catch (Exception ex)
                {
                    return (false, ex.ToString() + "" "" + ex.Message);
                }
                return (sumResult == ""\"" Whatever 12345 \"""", $""test returned: {sumResult}  expected: \"" Whatever 12345 \"""");
            }

        }
        }";

        public string? Description { get; set; } = @"
            Create a fonction that takes a string and returns it starting and ending with quotation marks.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                GetQuotation(""Hello World!"") → ""Hello World!""
                <br/>
                GetQuotation(""Some string"") → ""Some string""
                <br/>
                GetQuotation("" Whatever 12345 "") → "" Whatever 12345 ""
                <br/>
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) { { "String", "Special characters" }, { "Level", "1" } };
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}