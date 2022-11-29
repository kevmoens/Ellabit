namespace Ellabit.Challenges
{
    public class Challenge334Reversethestringwithacatch : IChallenge
    {
        public string? Header { get; set; } = "Reverse the string (with a catch)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

// Its possible to solve using some or all of these librarys.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Challenge 
{
	public  string SpecialReverseString(string txt)
	{
		return string.Empty;
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  and  returns  the  reversed  string.  however  there's  a  few  rules  to  follow  in  order  to  make  the  challenge  interesting:

the  uppercase/lowercase  positions  must  be  kept  in  the  same  order  as  the  original  string  (see  example  #1  and  #2).
spaces  must  be  kept  in  the  same  order  as  the  original  string  (see  example  #3).

examples
specia""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
