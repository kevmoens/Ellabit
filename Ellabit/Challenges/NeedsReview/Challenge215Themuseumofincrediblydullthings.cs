namespace Ellabit.Challenges
{
    public class Challenge215Themuseumofincrediblydullthings : IChallenge
    {
        public string? Header { get; set; } = "  \"The museum of incredibly dull things\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;
using System.Collections.Generic;
public class Challenge 
{
    public  int[] RemoveSmallest(int[] values) 
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
        int[] sumResult;
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
        public string? Description { get; set; } = @"A content  museum  wants  to  get  rid  of  some  exhibitions.  katya,  the  interior  architect,  comes  up  with  a  plan  to  remove  the  most  boring  exhibitions.  she  gives  them  a  rating,  and  removes  the  one  with  the  lowest  rating.  just  as  she  finishes  rating  the  exhibitions,  she's  called  off  to  an  important  meeting.  she  asks  you  to  write  a  program  that  tells  her  the  ratings  of  the  it""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
