namespace Ellabit.Challenges
{
    public class Challenge353Findmissingalphabets : IChallenge
    {
        public string? Header { get; set; } = "Find missing alphabets";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  string MissingAlphabets(string str) {
		
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
            sumResult = tmp.missingalphabets("" abcdefghijklmnopqrstuvwxy"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""z"" is missing. ,  $""returned: {sumResult}  expected: z is missing."");
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  str  containing  only  letters  from  a  to  z  in  lowercase  and  returns  the  missing  letter(s)  in  alphabetical  order  a-z.
a  set  of  letters  is  given  by  abcdefghijklmnopqrstuvwxyz.
two  sets  of  alphabets  means  two  or  more  alphabets.

examples
missingalphabets("" abcdefghijklmnopqrstuvwxy"") ➞ ""z"" is missing. missingalphabets(""aa""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
