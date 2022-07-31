namespace Ellabit.Challenges
{
    public class Challenge067Concatenatingfirstandlastcharacterofastring : IChallenge
    {
        public string? Header { get; set; } = "Concatenating first and last character of a string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string FirstLast(string str)
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
            sumResult = tmp.FirstLast(""forza"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""fa"",  $""returned: {sumResult}  expected: fa"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FirstLast(""kali"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""ki"",   $""returned: {sumResult}  expected: ki"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FirstLast(""always"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""as"",   $""returned: {sumResult}  expected: as"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FirstLast(""love"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""le"",   $""returned: {sumResult}  expected: le"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.FirstLast(""ellabit"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""et"",   $""returned: {sumResult}  expected: et"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string and returns the concatenated first and last character.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
FirstLast(""forza"") ➞ ""fa""

FirstLast(""kali"") ➞ ""ki""

FirstLast(""always"") ➞ ""as""

FirstLast(""love"") ➞ ""le""

FirstLast(""ellabit"") ➞ ""et""
            </p>
        </code>

Notes
There is no empty string.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
