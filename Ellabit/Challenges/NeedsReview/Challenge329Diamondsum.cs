namespace Ellabit.Challenges
{
    public class Challenge329Diamondsum : IChallenge
    {
        public string? Header { get; set; } = "Diamond sum";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  int DiamondSum(int n) 
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
            sumResult = tmp.diamondsum(1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   1

[1]

,  $""returned: {sumResult}  expected: 1

[1]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
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
        int sumResult;
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
        public string? Description { get; set; } = @"Given content  an  nxn  grid  of  consecutive  numbers,  return  the  grid's  diamond  sum.  the  diamond  sum  is  defined  as  the  sum  of  the  numbers  making  up  the  diagonals  between  adjacent  sides.

examples
diamondsum(1)  ➞  1

[1]

diamondsum(3)  ➞  20

[
  [1,  _,  3],
  [,  5,  ],
  [7,  _,  9]
]

//  the  numbers  behind  the  underscores  make  up  the  diamond  sum.
//  2  +  4  +  6  + 20

Diamond"" 8";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
