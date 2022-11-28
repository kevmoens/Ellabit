namespace Ellabit.Challenges
{
    public class Challenge326Areaofoverlappingrectangles : IChallenge
    {
        public string? Header { get; set; } = "Area of overlapping rectangles";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  int OverlappingRectangles(int[] rect1, int[] rect2)
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
            sumResult = tmp.overlappingrectangles(new  int[]  {  2,  1,  3,  4  },  new  int[]  {  3,  2,  2,  5  })  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   6

,  $""returned: {sumResult}  expected: 6"");
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
        public string? Description { get; set; } = @"Create content  a  function  that  returns  the  area  of  the  overlap  between  two  rectangles.  the  function  will  receive  two  rectangles,each  with  the  coordinates  of  the  lower  left  corner  followed  by  the  width  and  the  height  int[]  {  x,  y,  width,  height  }.

examples
overlappingrectangles(new  int[]  {  2,  1,  3,  4  },  new  int[]  {  3,  2,  2,  5  })  ➞  6

overlappingrectangles(new  int[]  {""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
