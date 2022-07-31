namespace Ellabit.Challenges
{
    public class Challenge113Sortnumbersinascendingorder : IChallenge
    {
        public string? Header { get; set; } = "Sort numbers in ascending order";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

using System.Linq;
public class Challenge
{
    public  int[] SortNumsAscending(int[] arr)
    {
        
    }
}

}";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.SortNumsAscending(new int[] {1, 2, 10, 50, 5}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1, 2, 5, 10, 50}),   $""returned: {sumResult}  expected: [1, 2, 5, 10, 50]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.SortNumsAscending(new int[] {80, 29, 4, -95, -24, 85});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {-95, -24, 4, 29, 80, 85}),   $""returned: {sumResult}  expected: [-95, -24, 4, 29, 80, 85]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.SortNumsAscending(null);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {}),   $""returned: {sumResult}  expected: []"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.SortNumsAscending(new int[] {});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {}),   $""returned: {sumResult}  expected: []"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes an array of numbers and returns a new array, sorted in ascending order (smallest to biggest).

Sort the numbers array in ascending order.
If the function's argument is null, an empty array, or undefined; return an empty array.
Return a new array of sorted numbers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
SortNumsAscending([1, 2, 10, 50, 5]) ➞ [1, 2, 5, 10, 50]

SortNumsAscending([80, 29, 4, -95, -24, 85]) ➞ [-95, -24, 4, 29, 80, 85]

SortNumsAscending(null) ➞ []

SortNumsAscending([]) ➞ []
            </p>
        </code>
Notes
Test input can be positive or negative.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
