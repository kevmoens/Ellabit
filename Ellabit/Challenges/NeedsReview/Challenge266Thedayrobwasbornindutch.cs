namespace Ellabit.Challenges
{
    public class Challenge266Thedayrobwasbornindutch : IChallenge
    {
        public string? Header { get; set; } = "The day rob was born in dutch";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Globalization;

public class Challenge 
{
	public  string WeekdayRobWasBornInDutch(int year, int month, int day)
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
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
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
        public string? Description { get; set; } = @"I was born on the 21st of September in the year of 1970. That was a Monday. Where I was born that weekday is called måndag.

Write a method that when passed a date as year/month/ day and returns the date's weekday name in the Dutch culture. The culture identifier to use is ""nl-NL"". Not ""nl-BE"".
You can assume the specified date is valid.
Looking at the tests and doing a switch statement or similar is considered cheating.
System.Globalization.CultureInfo should be used.
The method may be used to get the name of the Dutch weekday of other memorable days too, like in the examples below:
Examples
WeekdayRobWasBornInDutch(1970, 9, 21)) ➞ ""maandag""

WeekdayRobWasBornInDutch(1945, 9, 2)) ➞ ""zondag""

WeekdayRobWasBornInDutch(2001, 9, 11)) ➞ ""dinsdag""
Notes
Check the Resources tab for help.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
