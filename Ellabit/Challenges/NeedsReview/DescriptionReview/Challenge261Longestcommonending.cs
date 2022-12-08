namespace Ellabit.Challenges
{
    public class Challenge261Longestcommonending : IChallenge
    {
        public string? Header { get; set; } = "Longest common ending";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  string LongestCommonEnding(string str1, string str2)
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
            sumResult = tmp.longestcommonending("" multiplication"", ""ration"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""ation"" ,  $""returned: {sumResult}  expected: ation"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.longestcommonending(""potent"", ""tent"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""tent"" ,   $""returned: {sumResult}  expected: tent"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.longestcommonending(""skyscraper"", ""carnivore"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  """" ,   $""returned: {sumResult}  expected: "");
    }
}
";
        public string? Description { get; set; } = @"Write content  a  function  that  returns  the  longest  common  ending  between  two  strings.

examples
longestcommonending("" multiplication"", ""ration"") ➞ ""ation"" longestcommonending(""potent"", ""tent"") ""tent"" longestcommonending(""skyscraper"", ""carnivore"") """" notes return an empty string if there exists no common ending.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
