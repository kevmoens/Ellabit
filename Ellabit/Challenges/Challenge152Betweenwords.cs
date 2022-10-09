namespace Ellabit.Challenges
{
    public class Challenge152Betweenwords : IChallenge
    {
        public string? Header { get; set; } = "Between words";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  bool isBetween(string first, string last, string word)
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
            sumResult = tmp.isBetween(""apple"", ""banana"", ""azure"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isBetween(""monk"", ""monument"", ""monkey"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected: "");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isBetween(""bookend"", ""boolean"", ""boost"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Write content  a  function  that  takes  three  string  arguments  (first,  last,  and  word)  and  returns  true  if  word  is  found  between  first  and  last  in  the  dictionary,  otherwise  false.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
isbetween("" apple"", ""banana"", ""azure"") ➞ true 
isbetween(""monk"", ""monument"", ""monkey"") ➞ true
isbetween(""bookend"", ""boolean"", ""boost"") ➞ false 
            </p>
        </code>

notes all letters will be in lowercase.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
