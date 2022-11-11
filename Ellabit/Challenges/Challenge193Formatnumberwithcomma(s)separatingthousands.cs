namespace Ellabit.Challenges
{
    public class Challenge193Formatnumberwithcommaseparatingthousands : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Format number with comma(s) separating thousands";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
        public  string FormatNum(int num)
        {
			
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FormatNum(1000)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   ""1,000"" ,  $""returned: {sumResult}  expected:  1,000"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FormatNum(100000) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""100,000"" ,   $""returned: {sumResult}  expected: 100,000"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FormatNum(20);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""20"",   $""returned: {sumResult}  expected: 20"");
    }
}
}
";
        public string? Description { get; set; } = @"Create a function that takes a number as an argument and returns a string formatted to separate thousands.

        <h5>Examples</h5>
        <code>
FormatNum(1000) ➞ ""1,000""

FormatNum(100000) ➞ ""100,000""

FormatNum(20) ➞ ""20""
            </p>
        </code>
Notes
You can expect a valid number for all test cases.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
