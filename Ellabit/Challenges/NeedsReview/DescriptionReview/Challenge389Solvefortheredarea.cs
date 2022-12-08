using static MudBlazor.CategoryTypes;

namespace Ellabit.Challenges
{
    public class Challenge389Solvefortheredarea : IChallenge
    {
        public string? Header { get; set; } = "Solve for the red area";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  double RedArea(int r)
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
            sumResult = tmp.redarea(0) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  0,  $""returned: {sumResult}  expected:  0"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.redarea(4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1.252,   $""returned: {sumResult}  expected:  1.252"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.redarea(25) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  48,   $""returned: {sumResult}  expected:  48"");
    }
}
";
        public string? Description { get; set; } = @"This problem went viral in china, spreading on weibo. the problem is to solve for the area shown in red between the semicircle and the rectangle’s diagonal.

create a function that takes a number r as an the length of the side and returns the area rounded to the nearest thousandth.

the shaded part

examples
redarea(0) ➞ 0

redarea(4) ➞ 1.252

redarea(25) ➞ 48";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
