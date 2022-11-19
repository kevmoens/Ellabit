namespace Ellabit.Challenges
{
    public class Challenge232AlTeRnAtInGcaps : IChallenge
    {
        public string? Header { get; set; } = "AlTeRnAtInG caps";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string AlternatingCaps(string str) 
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
            sumResult = tmp.alternatingcaps("" hello"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""hello"" ,  $""returned: {sumResult}  expected: hello"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.alternatingcaps(""how are you?"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""how you?"" ,   $""returned: {sumResult}  expected: how you?"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.alternatingcaps(""omg this website is awesome!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""omg awesome!"" ,   $""returned: {sumResult}  expected: omg awesome!"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  alternates  the  case  of  the  letters  in  a  string  (known  as  spongecase).

examples
alternatingcaps("" hello"") ➞ ""hello"" alternatingcaps(""how are you?"") ""how you?"" alternatingcaps(""omg this website is awesome!"") ""omg awesome!"" notes the first letter should always be uppercase. ignore spaces.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
