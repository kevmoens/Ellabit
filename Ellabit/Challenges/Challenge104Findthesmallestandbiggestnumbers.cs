namespace Ellabit.Challenges
{
    public class Challenge104Findthesmallestandbiggestnumbers : IChallenge
    {
        public string? Header { get; set; } = "Find the smallest and biggest numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;
public class Challenge 
{
    public  double[] FindMinMax(double[] values) 
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
        double[] sumResult;
        try 
        {
            sumResult = tmp.FindMinMax(new double[] {1, 2, 3, 4, 5}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double[] {1, 5}),  $""returned: {sumResult}  expected:  [1, 5]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.FindMinMax(new double[] {2334454, 5}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double[] {5, 2334454}),   $""returned: {sumResult}  expected:  [5, 2334454]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.FindMinMax(new double[] {1}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double[] {1, 1}),   $""returned: {sumResult}  expected:  [1, 1]"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an array of numbers and return both the minimum and maximum numbers, in that order.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
findminmax([1, 2, 3, 4, 5]) ➞ [1, 5]

findminmax([2334454, 5]) ➞ [5, 2334454]

findminmax([1]) ➞ [1, 1]
            </p>
        </code>

notes
all test arrays will have at least one element and are valid.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
