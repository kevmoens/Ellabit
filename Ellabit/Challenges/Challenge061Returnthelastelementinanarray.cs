namespace Ellabit.Challenges
{
    public class Challenge061Returnthelastelementinanarray : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Return the last element in an array";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
	public  object GetLastItem(object[] arr) 
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
        object sumResult;
        try 
        {
            sumResult = tmp.GetLastItem(new object[] {1, 2, 3}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return ((int)sumResult ==  3,  $""returned: {sumResult}  expected:  3"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        object sumResult;
        try 
        {
            sumResult = tmp.GetLastItem(new object[] {""cat"", ""dog"", ""duck""});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return ((string)sumResult == ""duck"",   $""returned: {sumResult}  expected: duck"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        object sumResult;
        try 
        {
            sumResult = tmp.GetLastItem(new object[] {true, false, true});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return ((bool)sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that accepts an array and returns the last item in the array. the array can contain any of javascript's five primitive data types.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
GetLastItem([1, 2, 3]) ➞ 3

GetLastItem([""cat"", ""dog"", ""duck""]) ➞ ""duck""

GetLastItem([true, false, true]) ➞ true
            </p>
        </code>

Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
