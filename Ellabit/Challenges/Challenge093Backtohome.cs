namespace Ellabit.Challenges
{
    public class Challenge093Backtohome : IChallenge
    {
        public string? Header { get; set; } = "Back to home?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool BackToHome(string d)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.BackToHome(""NEWE"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.BackToHome(""NENESSWW"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.BackToHome(""NEESSW"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"Mubashir has started his journey from home. given a string of directions North, West, South, East), he will walk for one minute in each direction. determine whether a set of directions will lead him back to the starting position or not.

Examples
BackToHome(""NEWE"") ➞ false

BackToHome(""NENESSWW"") ➞ true

BackToHome(""NEESSW"") ➞ false";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
