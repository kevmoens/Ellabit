namespace Ellabit.Challenges
{
    public class Challenge119Raucousapplause : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Raucous applause";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  int CountClaps(string txt)
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
            sumResult = tmp.CountClaps(""ClaClaClaClap!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 4,  $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountClaps(""ClClClaClaClaClap!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 6,   $""returned: {sumResult}  expected: 6"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountClaps(""CCClaClClap!Clap!ClClClap!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 9,   $""returned: {sumResult}  expected: 9"");
    }
}
}";
        public string? Description { get; set; } = @"After an amazing performance, the crowd goes wild! People clap enthusiastically and most claps overlap with each other to create one homogeneous sound.

An overlapped clap is a clap which starts but doesn't finish, as in ""ClaClap"" (the first clap is cut short and there are overall 2 claps).

Given a string of what the overlapping claps sounded like, return how many claps were made in total.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
CountClaps(""ClaClaClaClap!"") ➞ 4

CountClaps(""ClClClaClaClaClap!"") ➞ 6

CountClaps(""CCClaClClap!Clap!ClClClap!"") ➞ 9
            </p>
        </code>
Notes
Each clap starts with a capital ""C"".";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"String", "Substring" }, {"Int", "Logic" }, {"Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
