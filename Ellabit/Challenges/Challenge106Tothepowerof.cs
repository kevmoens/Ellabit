namespace Ellabit.Challenges
{
    public class Challenge106Tothepowerof : IChallenge
    {
        public string? Header { get; set; } = "To the power of _____";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  long CalculateExponent(long number, long exponent) 
    {
    }
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        long sumResult = 0;
        try 
        {
            sumResult = tmp.CalculateExponent(5, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  3125,  $""returned: {sumResult}  expected:  3125"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        long sumResult = 0;
        try 
        {
            sumResult = tmp.CalculateExponent(10, 10) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  10000000000,   $""returned: {sumResult}  expected:  10000000000"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        long sumResult = 0;
        try 
        {
            sumResult = tmp.CalculateExponent(3, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  27,   $""returned: {sumResult}  expected:  27"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a base number and an exponent number and returns the calculation.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
сalculateexponent(5, 5) ➞ 3125

сalculateexponent(10, 10) ➞ 10000000000

сalculateexponent(3, 3) ➞ 27
            </p>
        </code>

notes
all test inputs will be positive integers.
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
