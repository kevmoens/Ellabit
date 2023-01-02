namespace Ellabit.Challenges
{
    public class Challenge206Noyelling : IChallenge
    {
        public string? Header { get; set; } = "No yelling";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string NoYelling(string phrase) 
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
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3>"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that transforms sentences ending with multiple question marks ? or exclamation marks ! into a sentence only ending with one without changing punctuation in the middle of the sentences.

Examples
NoYelling(""What went wrong?????????"") ➞ ""What went wrong?""

NoYelling(""Oh my goodness!!!"") ➞ ""Oh my goodness!""

NoYelling(""I just!!! can!!! not!!! believe!!! it!!!"") ➞ ""I just!!! can!!! not!!! believe!!! it!""
// Only change repeating punctuation at the end of the sentence.

NoYelling(""Oh my goodness!"") ➞ ""Oh my goodness!""
// Do not change sentences where there exists only one or zero exclamation marks/question marks.

NoYelling(""I just cannot believe it."") ➞ ""I just cannot believe it.""
Notes
Only change ending punctuation - keep the exclamation marks or question marks in the middle of the sentence the same (see third example).
Don't worry about mixed punctuation (no cases that end in something like ?!??!).
Keep sentences that do not have question/exclamation marks the same.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
