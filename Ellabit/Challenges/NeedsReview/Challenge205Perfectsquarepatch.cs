namespace Ellabit.Challenges
{
    public class Challenge205Perfectsquarepatch : IChallenge
    {
        public string? Header { get; set; } = "Perfect square patch";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  int[,] SquarePatch(int n) 
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
        int[,] sumResult;
        try 
        {
            sumResult = tmp.squarepatch(3)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   [
  [3,  3,  3],
  [3,  3,  3],
  [3,  3,  3]
]

,  $""returned: {sumResult}  expected: [
  [3,  3,  3],
  [3,  3,  3],
  [3,  3,  3]
]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[,] sumResult;
        try 
        {
            sumResult = tmp.squarepatch(5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   [
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5]
]

,   $""returned: {sumResult}  expected: [
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5]
]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[,] sumResult;
        try 
        {
            sumResult = tmp.squarepatch(1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   [
  [1]
]

,   $""returned: {sumResult}  expected: [
  [1]
]"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an integer and outputs an n x n square solely consisting of the integer n.

Examples
SquarePatch(3) ➞ [
  [3, 3, 3],
  [3, 3, 3],
  [3, 3, 3]
]

SquarePatch(5) ➞ [
  [5, 5, 5, 5, 5],
  [5, 5, 5, 5, 5],
  [5, 5, 5, 5, 5],
  [5, 5, 5, 5, 5],
  [5, 5, 5, 5, 5]
]

SquarePatch(1) ➞ [
  [1]
]

SquarePatch(0) ➞ []
Notes
n >= 0.
If n = 0, return an empty array.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
