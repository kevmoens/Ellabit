namespace Ellabit.Challenges
{
    public class Challenge288Consecutivenumbers : IChallenge
    {
        public string? Header { get; set; } = "Consecutive numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  bool IsThereConsecutive(int[] arr, int n, int times)
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
        public string? Description { get; set; } = @"Given an array of random digits of any length, return true if the number n appears times times in a row, and false otherwise.

Worked Example
IsThereConsecutive(new int[] { 1, 3, 5, 5, 3, 3, 1 }, 3, 2) ➞ true
// Second parameter is the number to look out for (3).
// Third parameter means you need to find the number 3 twice in a row.
// Return true if it can be found.
Examples
IsThereConsecutive(new int[] { 1, 2, 3, 4, 5 }, 1, 1) ➞ true

IsThereConsecutive(new int[] { 3 }, 1, 0) ➞ true

IsThereConsecutive(new int[] { 2, 2, 3, 2, 2, 2, 2, 3, 4, 1, 5 }, 3, 2) ➞ false

IsThereConsecutive(new int[] { 5, 5, 5, 5, 5 }, 5, 7) ➞ false
Notes
Arrays will only contain positive single digit numbers.
Expect all parameters to be valid.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
