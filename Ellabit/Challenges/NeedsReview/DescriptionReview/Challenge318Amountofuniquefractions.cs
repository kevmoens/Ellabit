namespace Ellabit.Challenges
{
    public class Challenge318Amountofuniquefractions : IChallenge
    {
        public string? Header { get; set; } = "Amount of unique fractions";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  double UniqueFract()
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
        double sumResult;
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
        double sumResult;
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
        double sumResult;
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
        public string? Description { get; set; } = @"Create content  a  function  double  uniquefract(),  which  should  sum  all  irreducible  regular  fractions  between  0  and  1,  in  the  numerator  and  denominator  of  which  there  are  only  single-digit  numbers:  1/2,  1/3,  1/4,  ...  2/3,  2/4,  ...  8/9.

task
uniquefract()  ➞  sum

notes
of  the  fractions  1/2  2/4  3/6  4/8,  only  1/2  is  included  in  the  sum.
don't  include  any";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
