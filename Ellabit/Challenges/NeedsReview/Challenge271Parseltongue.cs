namespace Ellabit.Challenges
{
    public class Challenge271Parseltongue : IChallenge
    {
        public string? Header { get; set; } = "Parseltongue";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool IsParselTongue(string sentence)
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
        public string? Description { get; set; } = @"Hermione has come up with a precise formula for determining whether or not a phrase was ssspoken by a parssseltongue (a reference from the Harry Potter universe; the language of ssserpents and those who can converse with them).

Each word in a sssentence must contain either:

Two or more consecutive instances of the letter ""s"" (i.e. must be together ss..), or...
Zero instances of the letter ""s"" by itself.
Examples
IsParselTongue(""Sshe ssselects to eat that apple. "") ➞ true

IsParselTongue(""She ssselects to eat that apple. "") ➞ false
// ""She"" only contains one ""s"".

IsParselTongue(""Beatrice samples lemonade"") ➞ false
// While ""samples"" has 2 instances of ""s"", they are not together.

IsParselTongue(""You ssseldom sssspeak sso boldly, ssso messmerizingly."") ➞ true
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
