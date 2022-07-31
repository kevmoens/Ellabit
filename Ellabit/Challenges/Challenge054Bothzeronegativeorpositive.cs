namespace Ellabit.Challenges
{
    public class Challenge054Bothzeronegativeorpositive : IChallenge
    {
        public string? Header { get; set; } = "Both zero, negative or positive";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  bool Both(int n1, int n2)
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
            sumResult = tmp.Both(6, 2) ;
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
            sumResult = tmp.Both(0, 0) ;
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
            sumResult = tmp.Both(-1, 2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.Both(0, 2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that returns true if both numbers are:

smaller than 0, or ...
greater than 0, or ...
exactly 0

otherwise, return false.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
both(6, 2) ➞ true

both(0, 0) ➞ true

both(-1, 2) ➞ false

both(0, 2) ➞ false
            </p>
        </code>

notes
inputs will always be two numbers.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
