namespace Ellabit.Challenges
{
    public class Challenge035Isittimeformilkandcookies : IChallenge
    {
        public string? Header { get; set; } = "Is it time for milk and cookies?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool TimeForMilkAndCookies(int year, int month, int day)
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
            sumResult = tmp.TimeForMilkAndCookies( 2013, 12, 24 ) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.TimeForMilkAndCookies( 2013, 0, 23 ) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.TimeForMilkAndCookies( 3000, 12, 24 ) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
}
";
        public string? Description { get; set; } = @"Christmas eve is almost upon us, so naturally we need to prepare some milk and cookies for santa! create a function that accepts a date object and returns true if it's christmas eve (december 24th) and false otherwise.

examples
TimeForMilkAndCookies( 2013, 12, 24 ) ➞ true

TimeForMilkAndCookies( 2013, 0, 23 ) ➞ false

TimeForMilkAndCookies( 3000, 12, 24 ) ➞ true

notes
all test cases contain valid dates.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
