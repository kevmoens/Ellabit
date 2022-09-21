namespace Ellabit.Challenges
{
    public class Challenge037Areaofarectangle : IChallenge
    {
        public string? Header { get; set; } = "Area of a rectangle";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  int area(int h, int w)
	{
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.area(3, 4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  12,  $""returned: {sumResult}  expected:  12"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.area(10, 11) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  110,   $""returned: {sumResult}  expected:  110"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.area(-1, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  -1,   $""returned: {sumResult}  expected:  -1"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.area(0, 2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  -1,   $""returned: {sumResult}  expected:  -1"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that calculates the area of a rectangle. if the arguments are invalid, your function must return -1.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
area(3, 4) ➞ 12

area(10, 11) ➞ 110

area(-1, 5) ➞ -1

area(0, 2) ➞ -1
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
