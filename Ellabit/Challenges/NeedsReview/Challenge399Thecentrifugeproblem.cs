namespace Ellabit.Challenges
{
    public class Challenge399Thecentrifugeproblem : IChallenge
    {
        public string? Header { get; set; } = "The centrifuge problem";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
  	public  bool Centrifuge(int n, int k)
	{
		return true | false; 
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
        public string? Description { get; set; } = @"A content  centrifuge,  as  you  probably  know,  is  a  laboratory  device  used  to  separate  fluids  based  on  density.  the  separation  is  achieved  through  centripetal  force  by  spinning  a  collection  of  test  tubes  at  high  speeds.  this  means,  the  configuration  needs  to  be  in  balance.

create  a  function  that  takes  two  numbers  as  arguments  n  and  k  and  returns  true  if  the  configuratio""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
