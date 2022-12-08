namespace Ellabit.Challenges
{
    public class Challenge378Prefixnotationevaluation : IChallenge
    {
        public string? Header { get; set; } = "Prefix notation evaluation";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int Prefix(string exp) {
	  	
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
        int sumResult;
        try 
        {
            sumResult = tmp.prefix("" + 5 4"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  9 ,  $""returned: {sumResult}  expected: 9"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.prefix(""* 12 2"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  24 ,   $""returned: {sumResult}  expected: 24"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.prefix(""+ -10 10"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  0 ,   $""returned: {sumResult}  expected: 0"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  mathematical  expression  in  prefix  notation  as  a  string  and  evaluates  the  expression.

examples
prefix("" + 5 4"") ➞ 9 prefix(""* 12 2"") 24 prefix(""+ -10 10"") 0 notes the mathematical expression is valid. check resources.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
