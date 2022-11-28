namespace Ellabit.Challenges
{
    public class Challenge322Knightsonaboard : IChallenge
    {
        public string? Header { get; set; } = "Knights on a board";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Collections.Generic;
using System.Linq;

public class Challenge 
{
	public  bool CannotCapture(int[,] board)
	{
		return true || false;
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
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
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
        public string? Description { get; set; } = @"Write content  a  function  that  returns  true  if  the  knights  are  placed  on  a  chessboard  such  that  no  knight  can  capture  another  knight.  here,  0s  represent  empty  squares  and  1s  represent  knights.

examples
cannotcapture(new  int[,]  {
  {  0,  0,  0,  1,  0,  0,  0,  0  },
  {  0,  0,  0,  0,  0,  0,  0,  0  },
  {  0,  1,  0,  0,  0,  1,  0,  0  },
  {  0,  0,  0,  0,  1,  0,  1,  0  },
  {  0,  1,  0,  0,  0,  1,""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
