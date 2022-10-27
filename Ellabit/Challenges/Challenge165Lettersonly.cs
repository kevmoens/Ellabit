namespace Ellabit.Challenges
{
    public class Challenge165Lettersonly : IChallenge
    {
        public string? Header { get; set; } = "Letters only";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  string LettersOnly(string str)
    {
			
    }
}

}";        public string? TestCode { get; set; } = @"
using System;

using System.Linq;
namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.LettersOnly(""R!=:~0o0./c&}9k`60=y"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Rocky"",  $""returned: {sumResult}  expected: Rocky"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.LettersOnly(""^,]%4B|@56a![0{2m>b1&4i4"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Bambi"",   $""returned: {sumResult}  expected: Bambi"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.LettersOnly(""^U)6$22>8p)."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Up"",   $""returned: {sumResult}  expected: Up"");
    }
}
}";        public string? Description { get; set; } = @"Write content  a  function  that  removes  any  non-letters  from  a  string,  returning  a  well-known  film  title.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
LettersOnly(""R!=:~0o0./c&}9k`60=y"") ➞ ""Rocky""

LettersOnly(""^,]%4B|@56a![0{2m>b1&4i4"") ➞ ""Bambi""

LettersOnly(""^U)6$22>8p)."") ➞ ""Up""

            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Format" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
