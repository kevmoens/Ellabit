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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  integer  and  outputs  an  n  x  n  square  solely  consisting  of  the  integer  n.

examples
squarepatch(3)  ➞  [
  [3,  3,  3],
  [3,  3,  3],
  [3,  3,  3]
]

squarepatch(5)  ➞  [
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5],
  [5,  5,  5,  5,  5]
]

squarepatch(1)  ➞  [
  [1]
]

squarepatch(0)  ➞";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
