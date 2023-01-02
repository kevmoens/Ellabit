namespace Ellabit.Challenges
{
    public class Challenge292Manglethestring : IChallenge
    {
        public string? Header { get; set; } = "Mangle the string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  string Mangle(string str)
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
        public string? Description { get; set; } = @"Create a function that takes a string and replaces every letter with the letter following it in the alphabet (""c"" becomes ""d"", ""z"" becomes ""a"", ""b"" becomes ""c"", etc). Then capitalize every vowel (a, e, i, o, u) and return the new modified string.

Examples
Mangle(""Fun times!"") ➞ ""GvO Ujnft!""

Mangle(""The quick brown fox."") ➞ ""UIf rvjdl cspxO gpy.""

Mangle(""Omega"") ➞ ""Pnfhb""
Notes
If a letter is already uppercase, return it as uppercase (regardless of being a vowel).
""y"" is not considered a vowel.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
