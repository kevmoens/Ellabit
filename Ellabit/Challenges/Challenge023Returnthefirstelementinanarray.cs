namespace Ellabit.Challenges
{
    public class Challenge023Returnthefirstelementinanarray : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "  \"Return the first element in an array\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  object GetFirstValue(object[] arr) 
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
            sumResult = tmp.GetFirstValue(new object[] {5, 6, 7});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.Equals(5),  $""returned: {sumResult}  expected:  5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        object sumResult;
        try 
        {
            sumResult = tmp.GetFirstValue(new object[] {""Semiramis"", ""Gaia"", ""Hypatia""});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.Equals(""Semiramis""),   $""returned: {sumResult}  expected: Semiramis"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        object sumResult;
        try 
        {
            sumResult = tmp.GetFirstValue(new object[] {true, false, true});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.Equals(true),   $""returned: {sumResult}  expected: true"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes an array containing only numbers and return the first element.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
getfirstvalue([5, 6, 7]) ➞ 5

GetFirstValue([""Semiramis"", ""Gaia"", ""Hypatia""]) ➞ ""Semiramis""

GetFirstValue([true, false, true]) ➞ true
            </p>
        </code>
Notes
The first element in an array always has an index of 0.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Array", "Index" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
