namespace Ellabit.Challenges
{
    public class Challenge064Calculateusingstringoperation : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Calculate using string operation";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  int Calculate(int num1, int num2, string operation)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Calculate(4, 9, ""+"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 13,  $""returned: {sumResult}  expected: 13"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Calculate(12, 5, ""-"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 7,   $""returned: {sumResult}  expected: 7"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Calculate(6, 3, ""*"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 18,   $""returned: {sumResult}  expected: 18"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Calculate(14, 3, ""%"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 2,   $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Calculate(6, 3, ""/"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 2,   $""returned: {sumResult}  expected: 2"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes two numbers and a mathematical operator and returns the result.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Calculate(4, 9, ""+"") ➞ 13

Calculate(12, 5, ""-"") ➞ 7

Calculate(6, 3, ""*"") ➞ 18

Calculate(14, 3, ""%"") ➞ 2

Calculate(6, 3, ""/"") ➞ 2
            </p>
        </code>

Notes
Numbers can be negative.
The only operations used are those in the examples above.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
