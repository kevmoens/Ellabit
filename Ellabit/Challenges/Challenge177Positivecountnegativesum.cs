namespace Ellabit.Challenges
{
    public class Challenge177Positivecountnegativesum : IChallenge
    {
        public string? Header { get; set; } = "Positive count negative sum";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge 
    {
        public  int[] CountPosSumNeg(double[] arr) 
        {
      
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit
{
    public class TestChallenge
    {
        public (bool pass, string message) Test1()
        {
            var tmp = new Challenge();
            int[] sumResult;
            try 
            {
                sumResult = tmp.CountPosSumNeg(new double[] {92, 6, 73, -77, 81, -90, 99, 8, -85, 34});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new int[] {7, -252}),   $""returned: {string.Join("", "", sumResult)}  expected: [7, -252]"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            int[] sumResult;
            try 
            {
                sumResult = tmp.CountPosSumNeg(new double[] {91, -4, 80, -73, -28});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new int[] {2, -105}),   $""returned: {string.Join("", "", sumResult)}  expected: [2, -105]"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            int[] sumResult;
            try 
            {
                sumResult = tmp.CountPosSumNeg(new double[] {});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult.SequenceEqual(new int[] {}),   $""returned: {string.Join("", "", sumResult)}  expected: []"");
        }
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an array of positive and negative numbers. Return an array where the first element is the count of positive numbers and the second element is the sum of negative numbers.

Examples
CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
// There are a total of 10 positive numbers.
// The sum of all negative numbers equals -65.

        <h5>Examples</h5>
        <code>
CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]

CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]

CountPosSumNeg([]) ➞ []
            </p>
        </code>
Notes
If given an empty array, return an empty array: []
Cast sum to int, don't mind the remaining decimal places.
0 is not positive.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"Array","Sort" }, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
