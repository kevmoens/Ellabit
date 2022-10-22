namespace Ellabit.Challenges
{
    public class Challenge107Multiplybylength : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Multiply by length";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class Challenge
{
	public  int[] MultiplyByLength(int[] arr)
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
            sumResult = tmp.MultiplyByLength(new int[] {2, 3, 1, 0}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {8, 12, 4, 0}),  $""returned: {sumResult}  expected:  [8, 12, 4, 0]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.MultiplyByLength(new int[] {4, 1, 1}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {12, 3, 3}),   $""returned: {sumResult}  expected:  ([12, 3, 3])"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.MultiplyByLength(new int[] {1, 0, 3, 3, 7, 2, 1}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {7, 0, 21, 21, 49, 14, 7}),   $""returned: {sumResult}  expected:  [7, 0, 21, 21, 49, 14, 7]"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.MultiplyByLength(new int[] {0}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {0}),   $""returned: {sumResult}  expected:  [0]"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function to multiply all of the values in an array by the amount of values in the given array.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
multiplybylength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]

multiplybylength([4, 1, 1]) ➞ ([12, 3, 3])

multiplybylength([1, 0, 3, 3, 7, 2, 1]) ➞ [7, 0, 21, 21, 49, 14, 7]

multiplybylength([0]) ➞ ([0])
            </p>
        </code>

notes
All of the values given are numbers.
All arrays will have at least one element.
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
