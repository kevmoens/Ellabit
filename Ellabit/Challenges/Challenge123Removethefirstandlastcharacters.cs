namespace Ellabit.Challenges
{
    public class Challenge123Removethefirstandlastcharacters : IChallenge
    {
        public string? Header { get; set; } = "Remove the first and last characters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  string RemoveFirstLast(string str)
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
            sumResult = tmp.RemoveFirstLast(""hello"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""ell"",  $""returned: {sumResult}  expected: ell"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.RemoveFirstLast(""maybe"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""ayb"",   $""returned: {sumResult}  expected: ayb"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.RemoveFirstLast(""benefit"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""enefi"",   $""returned: {sumResult}  expected: enefi"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.RemoveFirstLast(""a"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""a"",   $""returned: {sumResult}  expected: a"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that removes the first and last characters from a string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
RemoveFirstLast(""hello"") ➞ ""ell""

RemoveFirstLast(""maybe"") ➞ ""ayb""

RemoveFirstLast(""benefit"") ➞ ""enefi""

RemoveFirstLast(""a"") ➞ ""a""
            </p>
        </code>
Notes
If the string is 2 or fewer characters long, return the string itself(See example #4).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
