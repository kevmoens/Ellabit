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
        public string? Description { get; set; } = @"Given an nxn grid of consecutive numbers, return the grid's Diamond Sum. The diamond sum is defined as the sum of the numbers making up the diagonals between adjacent sides.

Examples
DiamondSum(1) ➞ 1

[1]
DiamondSum(3) ➞ 20

[
  [1, _, 3],
  [_, 5, _],
  [7, _, 9]
]

// The numbers behind the underscores make up the Diamond Sum.
// 2 + 4 + 6 + 8 = 20
DiamondSum(5) ➞ 104

[
  [1, 2, _, 4, 5],
  [6, _, 8, _, 10],
  [_, 12, 13, 14, _],
  [16, _, 18, _, 20],
  [21, 22, _, 24, 25]
]

// 3 + 7 + 9 + 11 + 15 + 17 + 19 + 23 = 104
Notes
n is always an odd number.
Bonus points for solving it mathematically!";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
