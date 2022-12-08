namespace Ellabit.Challenges
{
    public class Challenge270Twoproductproblempart2 : IChallenge
    {
        public string? Header { get; set; } = "Two product problem (part 2)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  int[] TwoProduct(int[] arr, int n) {
		
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.twoproduct(new  int[]  {  1,  2,  3,  4,  13,  5  },  39)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   {  3,  13  }

,  $""returned: {sumResult}  expected: {  3,  13  }"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.twoproduct(new  int[]  {  11,  2,  7,  3,  5,  0  },  55)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   {  5,  11  }

,   $""returned: {sumResult}  expected: {  5,  11  }"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  arr  and  a  number  n  and  returns  an  array  of  two  integers  whose  product  is  that  of  the  number  n.

examples
twoproduct(new  int[]  {  1,  2,  3,  4,  13,  5  },  39)  ➞  {  3,  13  }

twoproduct(new  int[]  {  11,  2,  7,  3,  5,  0  },  55)  ➞  {  5,  11  }

twoproduct(new  int[]  {  100,  12,  4,  1,  2  }  15)  ➞  {  }

notes
no  duplicates.
sort  the  result.
try  d""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
