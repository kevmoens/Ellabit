namespace Ellabit.Challenges
{
    public class Challenge262Nthfibonaccinumber : IChallenge
    {
        public string? Header { get; set; } = "Nth fibonacci number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
    public  string Fibonacci(int n)
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
            sumResult = tmp.fibonacci(10)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   "" 55"" ,  $""returned: {sumResult}  expected:  55"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.fibonacci(20) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""6765"" ,   $""returned: {sumResult}  expected: 6765"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.fibonacci(30);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""832040"" ,   $""returned: {sumResult}  expected: 832040"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  to  return  the  nth  number  in  the  fibonacci  sequence  as  a  string.

examples
fibonacci(10)  ➞  "" 55"" fibonacci(20) ➞ ""6765"" fibonacci(30) ""832040"" fibonacci(40) ""102334155"" fibonacci(50) ""12586269025"" fibonacci(60) ""1548008755920"" notes your function is expected to calculate numbers greater than uint64.maxvalue where n can be as large""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
