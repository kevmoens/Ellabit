namespace Ellabit.Challenges
{
    public class Challenge213Solvetheequation : IChallenge
    {
        public string? Header { get; set; } = "Solve the equation";
        public string? Code { get; set; } = @"
using System;
using System.Data;

namespace Ellabit
{

    public class Challenge
    {
	    public  int Equation(string s) 
	    {
		    
	    }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.equation(""1+1"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2 ,  $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.equation(""7*4-2"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  26 ,   $""returned: {sumResult}  expected: 26"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.equation(""1+1+1+1+1"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  5 ,   $""returned: {sumResult}  expected: 5"");
    }
}
}
";
        public string? Description { get; set; } = @"Create a function that takes an equation (e.g. ""1+1""), and returns the answer.

Examples
Equation(""1+1"") ➞ 2

Equation(""7*4-2"") ➞ 26

Equation(""1+1+1+1+1"") ➞ 5
Notes
Supported operators are +, -, and *.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
