namespace Ellabit.Challenges
{
    public class Challenge014Sumofpolygonangles : IChallenge
    {
        public string? Header { get; set; } = "Sum of polygon angles";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
	public  int SumPolygon(int num) {
		
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
            sumResult = tmp.SumPolygon(3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  180,  $""returned: {sumResult}  expected:  180"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.SumPolygon(4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  360,   $""returned: {sumResult}  expected:  360"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.SumPolygon(6) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  720,   $""returned: {sumResult}  expected:  720"");
    }
}
";
        public string? Description { get; set; } = @"Given an n-sided regular polygon n, return the total sum of internal angles (in degrees).

examples
sumpolygon(3) ➞ 180

sumpolygon(4) ➞ 360

sumpolygon(6) ➞ 720

notes
n will always be greater than 2.
the formula (n - 2) x 180 gives the sum of all the measures of the angles of an n-sided polygon.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
