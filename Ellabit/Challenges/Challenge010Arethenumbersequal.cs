namespace Ellabit.Challenges
{
    public class Challenge010Arethenumbersequal : IChallenge
    {
        public string? Header { get; set; } = "Are the numbers equal?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
	public  bool IsEqual(int num1, int num2)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.IsEqual(5, 6) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,  $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsEqual(1, 1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsEqual(36, 35) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes two integers and checks if they are equal.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >

IsEqual(5, 6) ➞ false

IsEqual(1, 1) ➞ true

IsEqual(36, 35) ➞ false
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Expression", "==" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
