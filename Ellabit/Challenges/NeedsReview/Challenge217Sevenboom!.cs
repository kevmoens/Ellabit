namespace Ellabit.Challenges
{
    public class Challenge217Sevenboom : IChallenge
    {
        public string? Header { get; set; } = "Seven boom!";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  string SevenBoom(int[] arr)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3>"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a list of numbers and return ""Boom!"" if the digit 7 appears in the array. Otherwise, return ""there is no 7 in the array"".

Examples
SevenBoom([1, 2, 3, 4, 5, 6, 7]) ➞ ""Boom!""
// 7 contains the number seven.

SevenBoom([8, 6, 33, 100]) ➞ ""there is no 7 in the array""
// None of the items contain 7 within them.

SevenBoom([2, 55, 60, 97, 86]) ➞ ""Boom!""
// 97 contains the number seven.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
