namespace Ellabit.Challenges
{
    public class Challenge083Edaaaaabit : IChallenge
    {
        public string? Header { get; set; } = "Ellaaaaabit";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string Ellaabit(int n)
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
        string sumResult;
        try 
        {
            sumResult = tmp.Ellaabit(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Ellaaaaabit"",   $""returned: {sumResult}  expected: Ellaaaaabit"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Ellaabit(0);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Ellbit"",   $""returned: {sumResult}  expected: Ellbit"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Ellaabit(-3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == """",   $""returned: {sumResult}  expected: ''"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Ellaabit(12);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Ellaaaaaaaaaaaabit"",   $""returned: {sumResult}  expected: Ellaaaaaaaaaaaabit"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function that takes an integer and returns a string with the given number of 'a's in Ellabit.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Ellaabit(5) ➞ ""Ellaaaaabit""

Ellaabit(0) ➞ ""Ellbit""

Ellaabit(-3) ➞ """"

Ellaabit(12) ➞ ""Ellaaaaaaaaaaaabit""
            </p>
        </code>

Notes
You'll only be given integers as test input.
The test will also contains negative values, in this case you should return an empty string";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
