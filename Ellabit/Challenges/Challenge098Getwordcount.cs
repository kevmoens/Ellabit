namespace Ellabit.Challenges
{
    public class Challenge098Getwordcount : IChallenge
    {
        public string? Header { get; set; } = "Get word count";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
    {
        public  int CountWords(string str)
        {
            
        }
    }

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountWords(""Just an example here move along"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 6,   $""returned: {sumResult}  expected: 6"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountWords(""This is a test"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 4,   $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CountWords(""What an easy task, right"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 5,   $""returned: {sumResult}  expected: 5"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a string and returns the word count. The string will be a sentence.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
countWords(""Just an example here move along"") ➞ 6

countWords(""This is a test"") ➞ 4

countWords(""What an easy task, right"") ➞ 5
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
