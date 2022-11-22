namespace Ellabit.Challenges
{
    public class Challenge265LCMofmorethanthreenumbers : IChallenge
    {
        public string? Header { get; set; } = "  \"LCM of more than three numbers\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int LcmOfArray (int[] numbers) {
		
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
            sumResult = tmp.lcmofarray(new  int[]  {  1,  2,  3,  4,  5,  6,  7,  8,  9,  10  })  ;
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
            sumResult = tmp.lcmofarray(new  int[]  {  13,  6,  17,  18,  19,  20,  37  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   27965340

,   $""returned: {sumResult}  expected: 27965340"");
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  more  than  three  numbers  and  returns  the  least  common  multiple  (lcm).

examples
lcmofarray(new  int[]  {  1,  2,  3,  4,  5,  6,  7,  8,  9,  10  })  ➞  2520

lcmofarray(new  int[]  {  13,  6,  17,  18,  19,  20,  37  })  ➞  27965340

lcmofarray(new  int[]  {  44,  64,  12,  17,  65  })  ➞  2333760

notes
the  lcm  of  an  array  of  numbers  is  the  smallest  posit""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
