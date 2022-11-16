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
        public string? Description { get; set; } = @"You're content  given  a  string  of  words.  you  need  to  find  the  word  "" nemo"", and return a string like this: ""i found nemo at [the order of the word you find nemo]!"". if can't nemo, :("". examples findnemo(""i am finding !"") ➞ 4!"" findnemo(""nemo is me"") 1!"" am"") nemo""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
