namespace Ellabit.Challenges
{
    public class Challenge351Longestalternatingsubstring : IChallenge
    {
        public string? Header { get; set; } = "Longest alternating substring";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
		public  string LongestSubstring(string digits)
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
            sumResult = tmp.longestsubstring("" 225424272163254474441338664823"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""272163254"" ""254,"" substrings 272163254, 474, 41, 38, 23 ,  $""returned: {sumResult}  expected: 272163254 254, substrings 272163254, 474, 41, 38, 23"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Given content  a  string  of  digits,  return  the  longest  substring  with  alternating  odd/even  or  even/odd  digits.  if  two  or  more  substrings  have  the  same  length,  return  the  substring  that  occurs  first.

examples
longestsubstring("" 225424272163254474441338664823"") ➞ ""272163254"" ""254,"" substrings 272163254, 474, 41, 38, 23 longestsubstring(""594127169973391692147228678476""""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
