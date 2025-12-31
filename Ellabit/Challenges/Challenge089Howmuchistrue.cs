namespace Ellabit.Challenges
{
    public class Challenge089Howmuchistrue : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "How much is true?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  int CountTrue(bool[] arr) 
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
            sumResult = tmp.CountTrue(new bool[] {true, false, false, true, false}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2,  $""returned: {sumResult}  expected:  2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountTrue(new bool[] {false, false, false, false}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  0,   $""returned: {sumResult}  expected:  0"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountTrue(new bool[] {}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  0,   $""returned: {sumResult}  expected:  0"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function which returns the number of true values there are in an array.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
counttrue([true, false, false, true, false]) ➞ 2

counttrue([false, false, false, false]) ➞ 0

counttrue([]) ➞ 0

notes
return 0 if given an empty array.
all array items are of the type bool (true or false).
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Arrays", "Index" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
