namespace Ellabit.Challenges
{
    public class Challenge154Howmanysolutionsdoesthisquadratichave : IChallenge
    {
        public string? Header { get; set; } = "How many solutions does this quadratic have?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  int solutions(int a, int b, int c) {
		
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
            sumResult = tmp.solutions(1, 0, -1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2,  $""returned: {sumResult}  expected:  2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.solutions(1, 0, 0);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,  $""returned: {sumResult}  expected:  1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.solutions(1, 0, 1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  0,  $""returned: {sumResult}  expected:  0"");
    }
}
}";
        public string? Description { get; set; } = @"A quadratic equation a x² + b x + c = 0 has either 0, 1, or 2 distinct solutions for real values of x. given a, b and c, you should return the number of solutions to the equation.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
solutions(1, 0, -1) ➞ 2
// x² - 1 = 0 has two solutions (x = 1 and x = -1).

solutions(1, 0, 0) ➞ 1
// x² = 0 has one solution (x = 0).

solutions(1, 0, 1) ➞ 0
// x² + 1 = 0 has no real solutions.
            </p>
        </code>
Notes
You do not have to calculate the solutions, just return how many there are.
a will always be non-zero.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
