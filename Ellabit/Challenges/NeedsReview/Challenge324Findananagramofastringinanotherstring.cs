namespace Ellabit.Challenges
{
    public class Challenge324Findananagramofastringinanotherstring : IChallenge
    {
        public string? Header { get; set; } = "Find an anagram of a string in another string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool AnagramStrStr(string needle, string haystack)
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
        public string? Description { get; set; } = @"Create a function that takes two strings and determines if an anagram of the first string is in the second string. Anagrams of ""bag"" are ""bag"", ""bga"", ""abg"", ""agb"", ""gab"", ""gba"". Since none of those anagrams are in ""grab"", the answer is false. A ""g"", ""a"", and ""b"" are in the string ""grab"", but they're split up by the ""r"".

Examples
AnagramStrStr(""car"", ""race"") ➞ true

AnagramStrStr(""nod"", ""done"") ➞ true

AnagramStrStr(""bag"", ""grab"") ➞ false
Notes
Inputs will be valid strings in all lowercase letters.
There exists a linear time algorithm for this.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
