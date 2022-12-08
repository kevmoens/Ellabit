namespace Ellabit.Challenges
{
    public class Challenge317Rationalnumberclasspart1 : IChallenge
    {
        public string? Header { get; set; } = "Rational number class (part 1)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

namespace Program
{
    /* This is a series of progressive challenges to create a fully-featured
			 numeric struct called Rational which defines a rational number in the
			 form Numerator/Denominator.  The series starts with defining a simple
			 struct, which is created with 2 parameters representing the numerator
			 and the denominator, and providing readonly properties Numerator and
			 Denominator and an overriden ToString() method. 
			 
     	 Subsequent challenges in the series will explore operator overloading
			 and implicit and explicit type conversion. */
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
        public string? Description { get; set; } = @"C# content  has  several  numeric  types,  including  natural,  real,  and  irrational  numbers.  one  numeric  type  that's  missing  is  a  rational  number.  a  rational  number,  as  the  name  suggests  is  a  ratio  between  2  natural  numbers  and  is  usually  represented  as  a  fraction  in  the  form  1/2,  5/4,  -79/13,  etc.

create  a  c#  struct  with  a  constructor  that  takes  two  integer  parameters,  ei""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
