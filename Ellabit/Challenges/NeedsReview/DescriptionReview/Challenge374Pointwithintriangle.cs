namespace Ellabit.Challenges
{
    public class Challenge374Pointwithintriangle : IChallenge
    {
        public string? Header { get; set; } = "Point within triangle";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  bool WithinTriangle(int[] p1, int[] p2, int[] p3, int[] test)
	{
		return false;
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
        bool sumResult;
        try 
        {
            sumResult = tmp.withintriangle((1,  4),  (5,  6),  (6,  1),  (4,  5))  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true

,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
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
        bool sumResult;
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  four  integer  arrays  of  2  elements.  the  first  three  are  (x,  y)  coordinates  of  three  corners  of  a  triangle.  return  true  if  the  fourth  array  —  the  (x,  y)  coordinates  of  a  test  point  —  lies  within  the  triangle,  false  if  it  doesn't.

examples
withintriangle((1,  4),  (5,  6),  (6,  1),  (4,  5))  ➞  true

withintriangle((1,  4),  (5,  6),  (6,  1),  (""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
