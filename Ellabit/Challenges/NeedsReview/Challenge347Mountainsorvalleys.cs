namespace Ellabit.Challenges
{
    public class Challenge347Mountainsorvalleys : IChallenge
    {
        public string? Header { get; set; } = "Mountains or valleys";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string LandscapeType(int[] arr) 
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
        public string? Description { get; set; } = @"A mountain is an array with exactly one peak.

All numbers to the left of the peak are increasing.
All numbers to the right of the peak are decreasing.
The peak CANNOT be on the boundary.
A valley is an array with exactly one trough.

All numbers to the left of the trough are decreasing.
All numbers to the right of the trough are increasing.
The trough CANNOT be on the boundary.
Some examples of mountains and valleys:

Mountain A:  [1, 3, 5, 4, 3, 2]   // 5 is the peak
Mountain B:  [-1, 0, -1]   // 0 is the peak
Mountain B:  [-1, -1, 0, -1, -1]   // 0 is the peak (plateau on both sides is okay)

Valley A: [10, 9, 8, 7, 2, 3, 4, 5]   // 2 is the trough
Valley B: [350, 100, 200, 400, 700]  // 100 is the trough
Neither mountains nor valleys:

Landscape A: [1, 2, 3, 2, 4, 1]  // 2 peaks (3, 4), not 1
Landscape B: [5, 4, 3, 2, 1]  // Peak cannot be a boundary element
Landscape B: [0, -1, -1, 0, -1, -1]  // 2 peaks (0)
Based on the rules above, write a function that takes in an array and returns either ""mountain"", ""valley"", or ""neither"".

Examples
landscapeType([3, 4, 5, 4, 3]) ➞ ""mountain""

landscapeType([9, 7, 3, 1, 2, 4]) ➞ ""valley""

landscapeType([9, 8, 9]) ➞ ""valley""

landscapeType([9, 8, 9, 8]) ➞ ""neither""
Notes
A peak is not exactly the same as the max of an array. The max is a unique number, but an array may have multiple peaks. However, if there exists only one peak in an array, then it is true that the peak = max.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
