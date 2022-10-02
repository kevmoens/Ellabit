namespace Ellabit.Challenges
{
    public class Challenge109Shufflethename : IChallenge
    {
        public string? Header { get; set; } = "Shuffle the name";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
    {
        public  string NameShuffle(string str)
        {
            return """";
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
            sumResult = tmp.NameShuffle(""Donald Trump"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Trump Donald"",  $""returned: {sumResult}  expected: Trump Donald"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.NameShuffle(""Rosie O'Donnell"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""O'Donnell Rosie"",   $""returned: {sumResult}  expected: O'Donnell Rosie"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.NameShuffle(""Seymour Butts"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Butts Seymour"",   $""returned: {sumResult}  expected: Butts Seymour"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that accepts a string (of a person's first and last name) and returns a string with the first and last name swapped.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
NameShuffle(""Donald Trump"") ➞ ""Trump Donald""

NameShuffle(""Rosie O'Donnell"") ➞ ""O'Donnell Rosie""

NameShuffle(""Seymour Butts"") ➞ ""Butts Seymour""
            </p>
        </code>
Notes
There will be exactly one space between the first and last name.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
