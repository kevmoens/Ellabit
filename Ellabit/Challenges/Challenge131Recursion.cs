namespace Ellabit.Challenges
{
    public class Challenge131Recursion : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Recursion: Sum";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public int Sum(int n) 
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
        int sumResult;
        try 
        {
            sumResult = tmp.Sum(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 15,  $""returned: {sumResult}  expected: 15"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Sum(1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,  $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Sum(12);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 78,  $""returned: {sumResult}  expected: 78"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that recursively finds the sum of the first n natural numbers.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Sum(5) ➞ 15
// 1 + 2 + 3 + 4 + 5 = 15

Sum(1) ➞ 1

Sum(12) ➞ 78
            </p>
        </code>
Notes
Assume the input number is always positive.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Convert.ToInt32()" }, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
