namespace Ellabit.Challenges
{
    public class Challenge306Completetheword : IChallenge
    {
        public string? Header { get; set; } = "Complete the word";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool CanComplete(string initial, string word) 
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
        public string? Description { get; set; } = @"An input string can be completed if additional letters can be added and no letters need to be taken away to match the word. Furthermore, the order of the letters in the input string must be the same as the order of letters in the final word.

Create a function that, given an input string, determines if the word can be completed.

Examples
CanComplete(""butl"", ""beautiful"") ➞ true
// We can add ""ea"" between ""b"" and ""u"", and ""ifu"" between ""t"" and ""l"".

CanComplete(""butlz"", ""beautiful"") ➞ false
// ""z"" does not exist in the word beautiful.

CanComplete(""tulb"", ""beautiful"") ➞ false
// Although ""t"", ""u"", ""l"" and ""b"" all exist in ""beautiful"", they are incorrectly ordered.

CanComplete(""bbutl"", ""beautiful"") ➞ false
// Too many ""b""s, beautiful has only 1.
Notes
Both string input and word will be lowercased.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
