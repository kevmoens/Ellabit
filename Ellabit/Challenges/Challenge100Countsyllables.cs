namespace Ellabit.Challenges
{
    public class Challenge100Countsyllables : IChallenge
    {
        public string? Header { get; set; } = "Count syllables";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  int NumberSyllables(string word)
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
            sumResult = tmp.NumberSyllables(""buf-fet"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 2,   $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.NumberSyllables(""beau-ti-ful"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 3,   $""returned: {sumResult}  expected: 3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.NumberSyllables(""mon-u-men-tal"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 4,   $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.NumberSyllables(""on-o-mat-o-poe-ia"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 6,   $""returned: {sumResult}  expected: 6"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that counts the number of syllables a word has. Each syllable is separated with a dash -.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
NumberSyllables(""buf-fet"") ➞ 2

NumberSyllables(""beau-ti-ful"") ➞ 3

NumberSyllables(""mon-u-men-tal"") ➞ 4

NumberSyllables(""on-o-mat-o-poe-ia"") ➞ 6
            </p>
        </code>
Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
