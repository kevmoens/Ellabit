namespace Ellabit.Challenges
{
    public class Challenge112Howmanyvowels : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "How many vowels?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  int CountVowels(string str) 
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
            sumResult = tmp.CountVowels(""Celebration"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 5,  $""returned: {sumResult}  expected: 5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountVowels(""Palm"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,   $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountVowels(""Prediction"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 4,   $""returned: {sumResult}  expected: 4"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string and returns the number (count) of vowels contained within it.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
CountVowels(""Celebration"") ➞ 5

CountVowels(""Palm"") ➞ 1

CountVowels(""Prediction"") ➞ 4
            </p>
        </code>
Notes
a, e, i, o, u are considered vowels(not y).
All test cases are one word and only contain letters.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"Expression", "Lambda" },{ "Loop", "For" },{ "String", "Containing" }, {"Level", "Two" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
<<<<<<< Updated upstream
=======
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
>>>>>>> Stashed changes
    }
}
