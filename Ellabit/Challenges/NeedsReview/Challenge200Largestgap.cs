namespace Ellabit.Challenges
{
    public class Challenge200Largestgap : IChallenge
    {
        public string? Header { get; set; } = "Largest gap";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int LargestGap(int[] arr) {
	  	
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
        public string? Description { get; set; } = @"Given an array of integers, return the largest gap between elements of the sorted version of that array.

Here's an illustrative example. Consider the array:

[9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5]
... which, after sorting, becomes the array:

[0, 0, 4, 5, 5, 6, 9, 20, 25, 26, 26]
... so that we now see that the largest gap in the array is the gap of 11 between 9 and 20.

Examples
LargestGap(new int[] { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 }) ➞ 11
// After sorting get { 0, 0, 4, 5, 5, 6, 9, 20, 25, 26, 26 }
// Largest gap of 11 between 9 and 20

LargestGap(new int[] { 14, 13, 7, 1, 4, 12, 3, 7, 7, 12, 11, 5, 7 }) ➞ 4
// After sorting get { 1, 3, 4, 5, 7, 7, 7, 7, 11, 12, 12, 13, 14 }
// Largest gap of 4 between 7 and 11

LargestGap(new int[] { 13, 3, 8, 5, 5, 2, 13, 6, 14, 2, 11, 4, 10, 8, 1, 9 }) ➞ 2
// After sorting get { 1, 2, 2, 3, 4, 5, 5, 6, 8, 8, 9, 10, 11, 13, 13, 14 }
// Largest gap of 2 between 6 and 8
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
