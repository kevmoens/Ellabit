namespace Ellabit.Challenges
{
    public class Challenge244Smoothsentences : IChallenge
    {
        public string? Header { get; set; } = "Smooth sentences";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool IsSmooth(string sentence) 
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
        public string? Description { get; set; } = @"Carlos is a huge fan of something he calls smooth sentences.

A smooth sentence is one where the last letter of each word is identical to the first letter the following word (and not case sensitive, so ""A"" would be the same as ""a"").

The following would be a smooth sentence ""Carlos swam masterfully"" because ""Carlos"" ends with an ""s"" and swam begins with an ""s"" and swam ends with an ""m"" and masterfully begins with an ""m"".

Create a function that determines whether the input sentence is a smooth sentence, returning a boolean value true if it is, false if it is not.

Examples
IsSmooth(""Marta appreciated deep perpendicular right trapezoids"") ➞ true

IsSmooth(""Someone is outside the doorway"") ➞ false

IsSmooth(""She eats super righteously"") ➞ true
Notes
The last and first letters are case insensitive.
There will be no punctuation in each sentence.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
