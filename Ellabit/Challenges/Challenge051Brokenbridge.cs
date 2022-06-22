namespace Ellabit.Challenges
{
    public class Challenge051Brokenbridge : IChallenge
    {
        public string? Header { get; set; } = "Broken bridge";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  bool IsSafeBridge(string str)
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
            sumResult = tmp.IsSafeBridge(""####"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSafeBridge(""## ####"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSafeBridge(""#"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
";
        public string? Description { get; set; } = @"Create a function which validates whether a bridge is safe to walk on (i.e. has no gaps in it to fall through).

Examples
IsSafeBridge(""####"") ➞ true

IsSafeBridge(""## ####"") ➞ false

IsSafeBridge(""#"") ➞ true

Notes
You can expect the bridge's ends connecting it to its surrounding.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
