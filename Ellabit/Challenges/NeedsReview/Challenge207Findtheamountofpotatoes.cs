namespace Ellabit.Challenges
{
    public class Challenge207Findtheamountofpotatoes : IChallenge
    {
        public string? Header { get; set; } = "Find the amount of potatoes";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  int Potatoes(string potato)
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
        int sumResult;
        try 
        {
            sumResult = tmp.potatoes("" potato"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1 ,  $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.potatoes(""potatopotato"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2 ,   $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Create a function to return the amount of potatoes there are in a string.

Examples
Potatoes(""potato"") ➞ 1

Potatoes(""potatopotato"") ➞ 2

Potatoes(""potatoapple"") ➞ 1
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
