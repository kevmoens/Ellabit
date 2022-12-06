namespace Ellabit.Challenges
{
    public class Challenge401Rationalnumberclasspart3 : IChallenge
    {
        public string? Header { get; set; } = "Rational number class (part 3)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

namespace Program
{
    public struct Rational
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
        public string? Description { get; set; } = @"In content  parts  1  and  2  of  this  3  part  challenge,  you  were  asked  to  develop  a  rational  number  struct.  a  rational  number,  as  the  name  suggests,  is  a  ratio  between  two  natural  numbers  and  is  usually  represented  as  a  fraction  in  the  form  1/2,  5/4,  -79/13,  etc.

in  part  1,  the  task  was  to  create  a  c#  struct  with:
a  constructor  which  takes  two  integer  parameters,
two  read""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
