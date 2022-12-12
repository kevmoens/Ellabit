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
        public string? Description { get; set; } = @"Create a function to return the Nth number in the Fibonacci sequence as a string.

Examples
Fibonacci(10) ➞ ""55""

Fibonacci(20) ➞ ""6765""

Fibonacci(30) ➞ ""832040""

Fibonacci(40) ➞ ""102334155""

Fibonacci(50) ➞ ""12586269025""

Fibonacci(60) ➞ ""1548008755920""
Notes
Your function is expected to calculate numbers greater than UInt64.MaxValue where n can be as large as but not greater than 200.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
