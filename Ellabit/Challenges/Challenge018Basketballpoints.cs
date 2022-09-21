namespace Ellabit.Challenges
{
    public class Challenge018Basketballpoints : IChallenge
    {
        public string? Header { get; set; } = "Basketball Points";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

    public class Challenge 
    {
        public  int Points(int twoPointers, int threePointers) 
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
            sumResult = tmp.Points(1, 1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  5,  $""returned: {sumResult}  expected:  5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Points(7, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  29,   $""returned: {sumResult}  expected:  29"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Points(38, 8) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  100,   $""returned: {sumResult}  expected:  100"");
    }
}
}";
        public string? Description { get; set; } = @"You are counting points for a basketball game, given the amount of 3-pointers scored and 2-pointers scored, find the final points for the team and return that value
(\\[2 -pointers scored, 3-pointers scored]).

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Points(1, 1) ➞ 5

Points(7, 5) ➞ 29

Points(38, 8) ➞ 100
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
