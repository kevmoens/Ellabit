namespace Ellabit.Challenges
{
    public class Challenge255Findthevertexofaquadratic : IChallenge
    {
        public string? Header { get; set; } = "Find the vertex of a quadratic";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge {
	public  double[] FindVertex(int a, int b, int c) {
		
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
        double[] sumResult;
        try 
        {
            sumResult = tmp.findvertex(1,  0,  25)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   [0,  25]
//  the  vertex  of x²+25 y  is  at  (0,  25).

,  $""returned: {sumResult}  expected: [0,  25]
//  the  vertex  of x²+25 y  is  at  (0,  25)."");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double[] sumResult;
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
        double[] sumResult;
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
        public string? Description { get; set; } = @"Every content  quadratic  curve a y  x²  +  b  x  +  c  has  a  vertex  point:  the  turning  point  where  the  curve  stops  heading  down  and  starts  going  up.

given  the  values  a,  b  and  c,  you  need  to  return  the  coordinates  of  the  vertex.  return  your  answers  rounded  to  2  decimal  places.

examples
findvertex(1,  0,  25)  ➞  [0,  25]
//  the  vertex  of x²+25 y  is  at  (0,  25).

findvertex(-1,""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
