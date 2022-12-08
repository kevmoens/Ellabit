namespace Ellabit.Challenges
{
    public class Challenge283Wraparound : IChallenge
    {
        public string? Header { get; set; } = "Wrap around";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
    public  string WrapAround(string input, int offset)
    {   
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
            sumResult = tmp.wraparound("" hello, world!"", 2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""llo, world!he"" ,  $""returned: {sumResult}  expected: llo, world!he"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.wraparound(""from what i gathered"", -4);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""eredfrom gath"" ,   $""returned: {sumResult}  expected: eredfrom gath"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.wraparound(""excelsior"", 30);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""elsiorexc"" ,   $""returned: {sumResult}  expected: elsiorexc"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  to  reproduce  the  wrap  around  effect  shown:

examples
wraparound("" hello, world!"", 2) ➞ ""llo, world!he"" wraparound(""from what i gathered"", -4) ""eredfrom gath"" wraparound(""excelsior"", 30) ""elsiorexc"" wraparound(""nonscience"", -116) ""ciencenons"" notes the offset can be negative. greater than string.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
