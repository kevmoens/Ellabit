namespace Ellabit.Challenges
{
    public class Challenge215Themuseumofincrediblydullthings : IChallenge
    {
        public string? Header { get; set; } = "  \"The museum of incredibly dull things\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;
using System.Collections.Generic;
public class Challenge 
{
    public  int[] RemoveSmallest(int[] values) 
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
        int[] sumResult;
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
        int[] sumResult;
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
        int[] sumResult;
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
        public string? Description { get; set; } = @"A museum wants to get rid of some exhibitions. Katya, the interior architect, comes up with a plan to remove the most boring exhibitions. She gives them a rating, and removes the one with the lowest rating. Just as she finishes rating the exhibitions, she's called off to an important meeting. She asks you to write a program that tells her the ratings of the items after the lowest one is removed.

Create a function that takes an array of integers and removes the smallest value.

Examples
RemoveSmallest([1, 2, 3, 4, 5] ) ➞ [2, 3, 4, 5]

RemoveSmallest([5, 3, 2, 1, 4]) ➞ [5, 3, 2, 4]

RemoveSmallest([2, 2, 1, 2, 1]) ➞ [2, 2, 2, 1]
Notes
Don't change the order of the left over items.
If you get an empty array, return an empty array: [] ➞ []
If there are multiple items with the same value, remove item with lower index (3rd example).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
