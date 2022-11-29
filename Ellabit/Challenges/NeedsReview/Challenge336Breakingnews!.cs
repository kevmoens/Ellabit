namespace Ellabit.Challenges
{
    public class Challenge336Breakingnews : IChallenge
    {
        public string? Header { get; set; } = "Breaking news!";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  string[] NewsAtTen(string txt, int n) {
			
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
        string[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string[] sumResult;
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
        string[] sumResult;
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
        public string? Description { get; set; } = @"A content  local  news  station  needs  your  help  to  generate  the  scrolling  text  for  the  headlines!

create  a  function  that  returns  an  array  of  strings,  where  each  string  contains  a  single  frame  of  what  the  scrolling  text  will  look  like.

text  will  scroll  from  right  to  left.
the  screen  will  have  a  width  of  n  characters.
start  and  stop  when  no  letters  appear  on  the  screen.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
