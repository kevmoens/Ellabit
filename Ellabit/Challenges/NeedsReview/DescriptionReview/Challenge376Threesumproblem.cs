namespace Ellabit.Challenges
{
    public class Challenge376Threesumproblem : IChallenge
    {
        public string? Header { get; set; } = "Three sum problem";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

// The following libraries may be useful 

using System;
using System.Linq;
using System.Collections.Generic;

public class Challenge
{
	public  List<int[]> ThreeSum(int[] arr) 
	{
		return new List<int[]>();
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
        List<int[]> sumResult;
        try 
        {
            sumResult = tmp.threesum(new  int[]  {  0,  1,  -1,  -1,  2  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   {  {  0,  1,  -1  },  {  -1,  -1,  2  }  }

,  $""returned: {sumResult}  expected: {  {  0,  1,  -1  },  {  -1,  -1,  2  }  }"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        List<int[]> sumResult;
        try 
        {
            sumResult = tmp.threesum(new  int[]  {  0,  0,  0,  5,  -5])  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   {  {  0,  0,  0  },  {  0,  5,  -5  }  }

,   $""returned: {sumResult}  expected: {  {  0,  0,  0  },  {  0,  5,  -5  }  }"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        List<int[]> sumResult;
        try 
        {
            sumResult = tmp.threesum(new  int[]  {  1,  2,  3])  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   {  }

,   $""returned: {sumResult}  expected: {  }"");
    }
}
";
        public string? Description { get; set; } = @"Write content  a  function  that  returns  all  sets  of  three  elements  that  sum  to  0.

examples
threesum(new  int[]  {  0,  1,  -1,  -1,  2  })  ➞  {  {  0,  1,  -1  },  {  -1,  -1,  2  }  }

threesum(new  int[]  {  0,  0,  0,  5,  -5])  ➞  {  {  0,  0,  0  },  {  0,  5,  -5  }  }

threesum(new  int[]  {  1,  2,  3])  ➞  {  }

threesum(new  int[1])  ➞  {  }

notes
the  original  array  may  contain  duplicate  numbers.
each  three-e""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
