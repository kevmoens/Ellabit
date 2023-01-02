namespace Ellabit.Challenges
{
    public class Challenge302Smallestmissingpositiveinteger : IChallenge
    {
        public string? Header { get; set; } = "Smallest missing positive integer";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int MinMissPos(int[] arr) {
			
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
        public string? Description { get; set; } = @"Given an array of integers, return the smallest positive integer not present in the array.

Here is a representative example. Consider the array:

{ -2, 6, 4, 5, 7, -1, 7, 1, 3, 6, 6, -2, 9, 10, 2, 2 }
After reordering, the array becomes:

{ -2, -2, -1, 1, 2, 2, 3, 4, 5, 6, 6, 6, 7, 7, 9, 10 }
... from which we see that the smallest missing positive integer is 8.

Examples
MinMissPos({ -2, 6, 4, 5, 7, -1, 1, 3, 6, -2, 9, 10, 2, 2 }) ➞ 8
// After sorting, the array becomes { -2, -2, -1, 1, 2, 2, 3, 4, 5, 6, 6, 7, 9, 10 }
// So the smallest missing positive integer is 8

MinMissPos({ 5, 9, -2, 0, 1, 3, 9, 3, 8, 9 }) ➞ 2
// After sorting, the array becomes [-2, 0, 1, 3, 3, 5, 8, 9, 9, 9 }
// So the smallest missing positive integer is 2

MinMissPos({ 0, 4, 4, -1, 9, 4, 5, 2, 10, 7, 6, 3, 10, 9 }) ➞ 1
// After sorting, the array becomes { -1, 0, 2, 3, 4, 4, 4, 5, 6, 7, 9, 9, 10, 10 }
// So the smallest missing positive integer is 1
Notes
For the sake of clarity, recall that 0 is not considered to be a positive number.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
