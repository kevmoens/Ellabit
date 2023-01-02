namespace Ellabit.Challenges
{
    public class Challenge214Istheinputfactorialofaninteger : IChallenge
    {
        public string? Header { get; set; } = "Is the input factorial of an integer?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool isFactorial(int n) 
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
        bool sumResult;
        try 
        {
            sumResult = tmp.isfactorial(2)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true
// 2 2  * 2!

isFactorial(27) 1  ➞  false

,  $""returned: {sumResult}  expected: true
// 2 2  * 2!

isFactorial(27) 1  ➞  false"");
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
        public string? Description { get; set; } = @"Create a function that checks if a given integer is exactly the factorial of an integer or not. true if it is, false otherwise.

Examples
isFactorial(2) ➞ true
// 2 = 2 * 1 = 2!

isFactorial(27) ➞ false

isFactorial(24) ➞ true
// 24 = 4 * 3 * 2 * 1 = 4!
Notes
No error handling is necessary. Inputs are all positive integers.
Alternatively, you can solve this with a recursive approach.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
