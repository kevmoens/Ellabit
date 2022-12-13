namespace Ellabit.Challenges
{
    public class Challenge275Validjavascriptcomments : IChallenge
    {
        public string? Header { get; set; } = "Valid javascript comments";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool CommentsCorrect(string str) 
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
        bool sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"In JavaScript, there are two types of comments:

Single-line comments start with //
Multi-line or inline comments start with /* and end with */
The input will be a sequence of //, /* and */. Every /* must have a */ that immediately follows it. To add, there can be no single-line comments in between multi-line comments in between the /* and */.

Create a function that returns true if comments are properly formatted, and false otherwise.

Examples
CommentsCorrect(""//////"") ➞ true
// 3 single-line comments: [""//"", ""//"", ""//""]

CommentsCorrect(""/**//**////**/"") ➞ true
// 3 multi-line comments + 1 single-line comment:
// [""/*"", ""*/"", ""/*"", ""*/"", ""//"", ""/*"", ""*/""]

CommentsCorrect(""///*/**/"") ➞ false
// The first /* is missing a */

CommentsCorrect(""/////"") ➞ false
// The 5th / is single, not a double //";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
