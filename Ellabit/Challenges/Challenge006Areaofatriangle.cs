namespace Ellabit.Challenges
{
    public class Challenge006Areaofatriangle : IChallenge
    {
        public string? Header { get; set; } = "Area of a triangle";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  int triArea(int b, int h)
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
            sumResult = tmp.triArea(3, 2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  3,  $""returned: {sumResult}  expected:  3"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.triArea(7, 4) ;
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
            sumResult = tmp.triArea(10, 10) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  50,   $""returned: {sumResult}  expected:  50"");
    }
}
";
        public string? Description { get; set; } = @"Write a function that takes the base and height of a triangle and return its area.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
triarea(3, 2) ➞ 3

triarea(7, 4) ➞ 14

triarea(10, 10) ➞ 50
            </p>
        </code>
notes
the area of a triangle is: (base * height) / 2
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
