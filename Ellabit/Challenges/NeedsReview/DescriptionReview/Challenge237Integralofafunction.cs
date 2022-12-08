namespace Ellabit.Challenges
{
    public class Challenge237Integralofafunction : IChallenge
    {
        public string? Header { get; set; } = "Integral of a function";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  int Integral(int b, int m, int n) {
		
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
            sumResult = tmp.integral(0,  2,  5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   3

,  $""returned: {sumResult}  expected: 3"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.integral(2,  4,  7)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   279

,   $""returned: {sumResult}  expected: 279"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.integral(5,  9,  3)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   -530712

,   $""returned: {sumResult}  expected: -530712"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  numbers  b,  m,  and  n  as  arguments  and  returns  the  definite  integral  of  the  function (b+1)*x^b f(x)  with  respect  to  x  from m x  to n, x  where  b,  m,  and  n  are  constants.

examples
integral(0,  2,  5)  ➞  3

integral(2,  4,  7)  ➞  279

integral(5,  9,  3)  ➞  -530712

notes
^  in  the  context  of  this  challenge  means  "" to the power of"", also known as""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
