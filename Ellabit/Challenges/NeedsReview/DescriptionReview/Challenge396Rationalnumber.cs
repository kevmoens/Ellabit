namespace Ellabit.Challenges
{
    public class Challenge396Rationalnumber : IChallenge
    {
        public string? Header { get; set; } = "Rational number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  string Rational(int a,int b)
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
        string sumResult;
        try 
        {
            sumResult = tmp.rational(2,  5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   "" 0.4"" ,  $""returned: {sumResult}  expected:  0.4"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
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
        string sumResult;
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
        public string? Description { get; set; } = @"Declare content  a  rational()  function  that  gets  two  natural  numbers  (a,  b)  and  return  a  string  containing  a  record  of  the  rational  number  a  b  in  the  form  of  a  decimal  fraction,  possibly  periodic.

examples
rational(2,  5)  ➞  "" 0.4"" rational(1, 6) ➞ ""0.1(6)"" 3) ""0.(3)"" 7) ""0.(142857)"" 77) ""0.(012987)"" notes always a < b. t""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
