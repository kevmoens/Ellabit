namespace Ellabit.Challenges
{
    public class Challenge129Repeatingletters : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Repeating letters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  string DoubleChar(string str) 
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
            sumResult = tmp.DoubleChar(""String"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""SSttrriinngg"",  $""returned: {sumResult}  expected: 'SSttrriinngg'"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.DoubleChar(""Hello World!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""HHeelllloo  WWoorrlldd!!"",   $""returned: {sumResult}  expected: 'HHeelllloo  WWoorrlldd!!'"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.DoubleChar(""1234!_ "");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""11223344!!__  "",   $""returned: {sumResult}  expected: '11223344!!__  '"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string and returns a string in which each character is repeated once.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
DoubleChar(""String"") ➞ ""SSttrriinngg""

DoubleChar(""Hello World!"") ➞ ""HHeelllloo  WWoorrlldd!!""

DoubleChar(""1234!_ "") ➞ ""11223344!!__  ""
            </p>
        </code>
Notes
All test cases contain valid strings.Don't worry about spaces, special characters or numbers. They're all considered valid characters.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "string", "Duplication" }, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
