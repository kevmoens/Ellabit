namespace Ellabit.Challenges
{
    public class Challenge355Distancetonearestvowel : IChallenge
    {
        public string? Header { get; set; } = "Distance to nearest vowel";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;

public class Challenge
{
	public  int[] DistanceToNearestVowel(string str)
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.distancetonearestvowel("" aaaaa"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  [0, 0, 0] ,  $""returned: {sumResult}  expected: [0, 0, 0]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.distancetonearestvowel(""babbb"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  [1, 1, 2, 3] ,   $""returned: {sumResult}  expected: [1, 1, 2, 3]"");
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
        public string? Description { get; set; } = @"Write content  a  function  that  takes  in  a  string  and  for  each  character,  returns  the  distance  to  the  nearest  vowel  in  the  string.  if  the  character  is  a  vowel  itself,  return  0.

examples
distancetonearestvowel("" aaaaa"") ➞ [0, 0, 0] distancetonearestvowel(""babbb"") [1, 1, 2, 3] distancetonearestvowel(""abcdabcd"") distancetonearestvow""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
