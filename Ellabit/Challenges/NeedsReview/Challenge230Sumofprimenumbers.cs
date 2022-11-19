namespace Ellabit.Challenges
{
    public class Challenge230Sumofprimenumbers : IChallenge
    {
        public string? Header { get; set; } = "Sum of prime numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  int SumPrimes(int[] arr)
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
        int sumResult;
        try 
        {
            sumResult = tmp.sumprimes(new  int[]  {  1,  2,  3,  4,  5,  6,  7,  8,  9,  10  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   17

,  $""returned: {sumResult}  expected: 17"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.sumprimes(new  int[]  {  2,  3,  4,  11,  20,  50,  71  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   87

,   $""returned: {sumResult}  expected: 87"");
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  list  of  numbers  and  returns  the  sum  of  all  prime  numbers  in  the  list.

examples
sumprimes(new  int[]  {  1,  2,  3,  4,  5,  6,  7,  8,  9,  10  })  ➞  17

sumprimes(new  int[]  {  2,  3,  4,  11,  20,  50,  71  })  ➞  87

sumprimes(new  int[]  {  })  ➞  0

notes
given  numbers  won't  exceed  101.
a  prime  number  is  a  number  which  has  exactly  two  divisors  (1  and  it""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
