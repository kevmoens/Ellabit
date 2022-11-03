namespace Ellabit.Challenges
{
    public class Challenge101Hurdlejump : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Hurdle jump";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  bool hurdleJump(int[] hurdles, int jumpHeight)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.hurdleJump(new int[] {1, 2, 3, 4, 5}, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.hurdleJump(new int[] {5, 5, 3, 4, 5}, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.hurdleJump(new int[] {5, 4, 5, 6}, 10) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.hurdleJump(new int[] {1, 2, 1}, 1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes an array of hurdle heights and a jumper's jump height, and determine whether or not the hurdler can clear all the hurdles.

a hurdler can clear a hurdle if their jump height is greater than or equal to the hurdle height.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
hurdleJump([1, 2, 3, 4, 5], 5) ➞ true

hurdleJump([5, 5, 3, 4, 5], 3) ➞ false

hurdleJump([5, 4, 5, 6], 10) ➞ true

hurdleJump([1, 2, 1], 1) ➞ false
            </p>
        </code>

Notes
Return true for the edge case of an empty array of hurdles. (Zero hurdles means that any jump height can clear them).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Array", "Index" }, { "Logic", ">or<" }, { "Boolean", "Expression" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
