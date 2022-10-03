namespace Ellabit.Challenges
{
    public class Challenge050Recreatingtheabsfunction : IChallenge
    {
        public string? Header { get; set; } = "Recreating the abs() function";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  int absolute(int num) 
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
            sumResult = tmp.absolute(-3) ;
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
            sumResult = tmp.absolute(250) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  250,   $""returned: {sumResult}  expected:  250"");
    }
}
}";
        public string? Description { get; set; } = @"The math.abs() function returns the absolute value of a number. this means that it returns a number's positive value. you can think of it as the distance away from zero.

create a function that recreates this functionality.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
absolute(-3) ➞ 3

absolute(250) ➞ 250
            </p>
        </code>

notes
tests will only include valid numbers.
don't use the math.abs()";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
