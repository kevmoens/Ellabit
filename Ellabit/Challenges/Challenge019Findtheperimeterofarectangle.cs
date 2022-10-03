namespace Ellabit.Challenges
{
    public class Challenge019Findtheperimeterofarectangle : IChallenge
    {
        public string? Header { get; set; } = "Find the perimeter of a rectangle";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
    public  int FindPerimeter(int length, int width) 
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
            sumResult = tmp.FindPerimeter(6, 7) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  26,  $""returned: {sumResult}  expected:  26"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindPerimeter(20, 10) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  60,   $""returned: {sumResult}  expected:  60"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindPerimeter(2, 9) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  22,   $""returned: {sumResult}  expected:  22"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes length and width and finds the perimeter of a rectangle.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
findperimeter(6, 7) ➞ 26

findperimeter(20, 10) ➞ 60

findperimeter(2, 9) ➞ 22
            </p>
        </code>

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
    }
}
