namespace Ellabit.Challenges
{
    public class Challenge200LargestGap : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Largest gap";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{


using System;

public class Challenge
{
    public  int LargestGap(int[] arr) {
	  	
	}	
}


}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
    {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
                sumResult = tmp.LargestGap(new int[] new int{});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == 11,  $""returned: {sumResult}  expected: 11"");
    }

        public (bool pass, string message) <rep.test.testname>()
    {
        var tmp = new Challenge();
            <rep.test.returnType> sumResult;
        try 
        {
                sumResult = tmp.<rep.test>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (<rep.test.resultCheck>,  $""returned: <rep.test.resultDisplay>  expected: <rep.test.resultVal>"");
    }
    }
}
";
        public string? Description { get; set; } = @"<div><p><span>Given an array of integers, return the largest gap between elements of the sorted version of that array.</span></p><p><span>Here's an illustrative example. Consider the array:</span></p><pre><code>[9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5]</code></pre><p><span>... which, after sorting, becomes the array:</span></p><pre><code>[0, 0, 4, 5, 5, 6, 9, 20, 25, 26, 26]</code></pre><p><span>... so that we now see that the largest gap in the array is the gap of </span><code>11</code><span> between 9 and 20.</span></p><h3><span>Examples</span></h3><pre><code>LargestGap(new int[] { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 }) âžž 11
// After sorting get { 0, 0, 4, 5, 5, 6, 9, 20, 25, 26, 26 }
// Largest gap of 11 between 9 and 20

LargestGap(new int[] { 14, 13, 7, 1, 4, 12, 3, 7, 7, 12, 11, 5, 7 }) ➞ 4
// After sorting get { 1, 3, 4, 5, 7, 7, 7, 7, 11, 12, 12, 13, 14 }
// Largest gap of 4 between 7 and 11

LargestGap(new int[] { 13, 3, 8, 5, 5, 2, 13, 6, 14, 2, 11, 4, 10, 8, 1, 9 }) ➞ 2
// After sorting get { 1, 2, 2, 3, 4, 5, 5, 6, 8, 8, 9, 10, 11, 13, 13, 14 }
// Largest gap of 2 between 6 and 8</code></pre><h3><span>Notes</span></h3><p><span>N/A</span></p></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
