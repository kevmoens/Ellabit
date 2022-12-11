namespace Ellabit.Challenges
{
    public class Challenge256Countthenumberofduplicatecharacters : IChallenge
    {
        public string? Header { get; set; } = "Count the number of duplicate characters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  int DuplicateCount(string str)
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
        int sumResult;
        try 
        {
            sumResult = tmp.duplicatecount("" abcde"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  0 ,  $""returned: {sumResult}  expected: 0"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.duplicatecount(""aabbcde"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2 ,   $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.duplicatecount(""indivisibilities"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ,   $""returned: {sumResult}  expected: "");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a string and returns the number of alphanumeric characters that occur more than once.

Examples
DuplicateCount(""abcde"") ➞ 0

DuplicateCount(""aabbcde"") ➞ 2

DuplicateCount(""Indivisibilities"") ➞ 2

DuplicateCount(""Aa"") ➞ 0
// Case sensitive
Notes
Duplicate characters are case sensitive.
The input string will contain only alphanumeric characters.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
