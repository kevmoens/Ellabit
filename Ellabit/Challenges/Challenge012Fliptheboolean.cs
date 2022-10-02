namespace Ellabit.Challenges
{
    public class Challenge012Fliptheboolean : IChallenge
    {
        public string? Header { get; set; } = "Flip the boolean";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  bool Reverse(bool boolean)
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
            sumResult = tmp.Reverse(true) ;
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
            sumResult = tmp.Reverse(false) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that reverses a boolean value.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
reverse(true) ➞ false

reverse(false) ➞ true
            </p>
        </code>
notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Boolean", "Unary" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
