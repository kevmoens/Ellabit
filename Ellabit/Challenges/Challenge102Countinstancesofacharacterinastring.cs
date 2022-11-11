namespace Ellabit.Challenges
{
    public class Challenge102Countinstancesofacharacterinastring : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Count instances of a character in a string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  int CharCount(char myChar, string str) 
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CharCount('a', ""ellabit"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,  $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CharCount('c', ""Chamber of secrets"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,  $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CharCount('b', ""big fat bubble"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 4,  $""returned: {sumResult}  expected: 4"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a character and a string as arguments and returns the number of times the character is found in the string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
CharCount('a', ""ellabit"") ➞ 1

CharCount('c', ""Chamber of secrets"") ➞ 1

CharCount('b', ""big fat bubble"") ➞ 4
Notes
Your output must be case-sensitive(see second example).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Character" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
