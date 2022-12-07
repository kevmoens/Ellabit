namespace Ellabit.Challenges
{
    public class Challenge198Findingnemo : IChallenge
    {
        public string? Header { get; set; } = "Finding nemo";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
class Program
{
	public  string FindNemo(string sentence)
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
        string sumResult;
        try 
        {
            sumResult = tmp.findnemo(""i am finding !"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  4!"" ,  $""returned: {sumResult}  expected: 4!"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
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
        public string? Description { get; set; } = @"You're given a string of words. You need to find the word ""Nemo"", and return a string like this: ""I found Nemo at [the order of the word you find Nemo]!"".

If you can't find Nemo, return ""I can't find Nemo :("".

Examples
FindNemo(""I am finding Nemo !"") ➞ ""I found Nemo at 4!""

FindNemo(""Nemo is me"") ➞ ""I found Nemo at 1!""

FindNemo(""I Nemo am"") ➞ ""I found Nemo at 2!""
Notes
! , ? . are always separated from the last word.
Nemo will always look like Nemo, and not NeMo or other capital variations.
Nemo's, or anything that says Nemo with something behind it, doesn't count as Finding Nemo.
If there are multiple Nemo's in the sentence, only return the first one.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
