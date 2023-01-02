namespace Ellabit.Challenges
{
    public class Challenge203Getthecentury : IChallenge
    {
        public string? Header { get; set; } = "Get the century";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  string Century(int year)
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
            sumResult = tmp.century(1756)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   "" 18th ,  $""returned: {sumResult}  expected:  18th"");
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
        public string? Description { get; set; } = @"Create a function that takes in a year and returns the correct century.

Examples
Century(1756) ➞ ""18th century""

Century(1555) ➞ ""16th century""

Century(1000) ➞ ""10th century""

Century(1001) ➞ ""11th century""

Century(2005) ➞ ""21st century""
Notes
All years will be between 1000 and 2010.
The 11th century is between 1001 and 1100.
The 18th century is between 1701-1800.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
