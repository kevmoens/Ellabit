namespace Ellabit.Challenges
{
    public class Challenge044Freecoffeecups : IChallenge
    {
        public string? Header { get; set; } = "Free coffee cups";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  int TotalCups(int n)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.TotalCups(6) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  7,  $""returned: {sumResult}  expected:  7"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.TotalCups(12) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  14,   $""returned: {sumResult}  expected:  14"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.TotalCups(213) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  248,   $""returned: {sumResult}  expected:  248"");
    }
}
";
        public string? Description { get; set; } = @"For each of the 6 coffee cups i buy, i get a 7th cup free. in total, i get 7 cups. create a function that takes n cups bought and return the total number of cups i would get.

examples
totalcups(6) ➞ 7

totalcups(12) ➞ 14

totalcups(213) ➞ 248

notes
number of cups i bought + number of cups i got for free.
only valid inputs will be given.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
