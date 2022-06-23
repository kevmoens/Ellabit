namespace Ellabit.Challenges
{
    public class Challenge088Concatenatingtwointegerarrays : IChallenge
    {
        public string? Header { get; set; } = "Concatenating two integer arrays";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  int[] ConcatArrays(int[] arr1, int[] arr2) 
    {
		
	}
}

";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.ConcatArrays(new int[] {1, 3, 5}, new int [] {2, 6, 8}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1, 3, 5, 2, 6, 8}),  $""returned: {sumResult}  expected:  [1, 3, 5, 2, 6, 8]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.ConcatArrays(new int[] {7, 8}, new int[] {10, 9, 1, 1, 2}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {7, 8, 10, 9, 1, 1, 2}),   $""returned: {sumResult}  expected:  [7, 8, 10, 9, 1, 1, 2]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.ConcatArrays(new int[] {4, 5, 1}, new int[] {3, 3, 3, 3, 3}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {4, 5, 1, 3, 3, 3, 3, 3}),   $""returned: {sumResult}  expected:  [4, 5, 1, 3, 3, 3, 3, 3]"");
    }
}
";
        public string? Description { get; set; } = @"Create a function to concatenate two integer arrays.

examples
concat([1, 3, 5], [2, 6, 8]) ➞ [1, 3, 5, 2, 6, 8]

concat([7, 8], [10, 9, 1, 1, 2]) ➞ [7, 8, 10, 9, 1, 1, 2]

concat([4, 5, 1], [3, 3, 3, 3, 3]) ➞ [4, 5, 1, 3, 3, 3, 3, 3]

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
