namespace Ellabit.Challenges
{
    public class Challenge397RotateTransformthetwodimensionalmatrix : IChallenge
    {
        public string? Header { get; set; } = "Rotate-Transform the two-dimensional matrix";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
    public  int[,] RotateTransform(int[,] arr, int num)
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
            sumResult = tmp.rotatetransform({
  {2,  4},
  {0,  0}
},  1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   {
  {0,  2},
  {0,  4}
}

,  $""returned: {sumResult}  expected: {
  {0,  2},
  {0,  4}
}"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[,] sumResult;
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
        int[,] sumResult;
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
        public string? Description { get; set; } = @"Create content  a  function  to  rotate  a  two-dimensional  matrix  of  n  *  n  integer  elements  num  times,  where  if  num  is  positive,  the  rotation  is  clockwise,  and  if  not,  counterclockwise.

examples
rotatetransform({
  {2,  4},
  {0,  0}
},  1)  ➞  {
  {0,  2},
  {0,  4}
}

rotatetransform({
  {2,  4},
  {0,  0}
},  -1)  ➞  {
  {4,  0},
  {2,  0}
}

notes
n/a""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
