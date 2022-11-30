namespace Ellabit.Challenges
{
    public class Challenge348Leastcommonmultiple : IChallenge
    {
        public string? Header { get; set; } = "Least common multiple";
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
	public  int LCM(int[] nums)
	{
		return 0;
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
            sumResult = tmp.lcm({  1,  2,  3,  4,  5,  6,  7,  8,  9  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   2520

,  $""returned: {sumResult}  expected: 2520"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.lcm({  5  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   5

,   $""returned: {sumResult}  expected: 5"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.lcm({  5,  7,  11  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   385

,   $""returned: {sumResult}  expected: 385"");
    }
}
";
        public string? Description { get; set; } = @"Given content  a  array  of  integers,  create  a  function  that  will  find  the  smallest  positive  integer  that  is  evenly  divisible  by  all  the  members  of  the  list.  in  other  words,  find  the  least  common  multiple  (lcm).

examples
lcm({  1,  2,  3,  4,  5,  6,  7,  8,  9  })  ➞  2520

lcm({  5  })  ➞  5

lcm({  5,  7,  11  })  ➞  385

lcm({  5,  7,  11,  35,  55,  77  })  ➞  385

notes
n/a""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
