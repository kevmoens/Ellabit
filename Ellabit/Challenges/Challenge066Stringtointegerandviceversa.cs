namespace Ellabit.Challenges
{
    public class Challenge066Stringtointegerandviceversa : IChallenge
    {
        public string? Header { get; set; } = "  \"String to integer and vice versa\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{

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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.toInt(""77"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 77,  $""returned: {sumResult}  expected: 77"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.toInt(""532"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 532,   $""returned: {sumResult}  expected: 532"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.toStr(77);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""77"",   $""returned: {sumResult}  expected: 77"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.toStr(532);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""532"",   $""returned: {sumResult}  expected: 532"");
    }
}
}";
        public string? Description { get; set; } = @"Write two functions:

toInt() : A function to convert a string to an integer.
toStr() : A function to convert an integer to a string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
toInt(""77"") ➞ 77

toInt(""532"") ➞ 532

toStr(77) ➞ ""77""

toStr(532) ➞ ""532""
            </p>
        </code>

Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
