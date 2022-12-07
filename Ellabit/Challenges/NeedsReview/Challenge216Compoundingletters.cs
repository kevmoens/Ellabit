namespace Ellabit.Challenges
{
    public class Challenge216Compoundingletters : IChallenge
    {
        public string? Header { get; set; } = "Compounding letters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string Accum(string str) 
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
        string sumResult;
        try 
        {
            sumResult = tmp.accum("" abcd"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""a-bb-ccc-dddd"" ,  $""returned: {sumResult}  expected: a-bb-ccc-dddd"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.accum(""rqaezty"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""r-qq-aaa-eeee-zzzzz-tttttt-yyyyyyy"" ,   $""returned: {sumResult}  expected: r-qq-aaa-eeee-zzzzz-tttttt-yyyyyyy"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
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
        public string? Description { get; set; } = @"Create a function that takes a string and returns a new string with each new character accumulating by +1. Separate each set with a dash.

Examples
Accum(""abcd"") ➞ ""A-Bb-Ccc-Dddd""

Accum(""RqaEzty"") ➞ ""R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy""

Accum(""cwAt"") ➞ ""C-Ww-Aaa-Tttt""
Notes
Capitalize the first letter of each set.
All tests contain valid strings with alphabetic characters (a-z, A-Z).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
