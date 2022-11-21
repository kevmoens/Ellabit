namespace Ellabit.Challenges
{
    public class Challenge250Aweeklater : IChallenge
    {
        public string? Header { get; set; } = "A week later";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;

public class Challenge
{
	public  string WeekAfter(string date) {
		
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
            sumResult = tmp.weekafter("" 12 03 2020"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""19 2020"" ,  $""returned: {sumResult}  expected: 19 2020"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.weekafter(""21 1989"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""28 1989"" ,   $""returned: {sumResult}  expected: 28 1989"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.weekafter(""01 01 2000"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""08 2000"" ,   $""returned: {sumResult}  expected: 08 2000"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  which  takes  in  a  date  as  a  string,  and  returns  the  date  a  week  after.

examples
weekafter("" 12 03 2020"") ➞ ""19 2020"" weekafter(""21 1989"") ""28 1989"" weekafter(""01 01 2000"") ""08 2000"" notes note that dates will be given in day month year format. single digit numbers should zero padded.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
