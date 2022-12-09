namespace Ellabit.Challenges
{
    public class Challenge235Capitalizethenames : IChallenge
    {
        public string? Header { get; set; } = "Capitalize the names";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string[] CapMe(string[] arr) 
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
        string[] sumResult;
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
        string[] sumResult;
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
        string[] sumResult;
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
        public string? Description { get; set; } = @"Create a function that takes an array of names and returns an array where only the first letter of each name is capitalized.

Examples
CapMe([""mavis"", ""senaida"", ""letty""]) ➞ [""Mavis"", ""Senaida"", ""Letty""]

CapMe([""samuel"", ""MABELLE"", ""letitia"", ""meridith""]) ➞ [""Samuel"", ""Mabelle"", ""Letitia"", ""Meridith""]

CapMe([""Slyvia"", ""Kristal"", ""Sharilyn"", ""Calista""]) ➞ [""Slyvia"", ""Kristal"", ""Sharilyn"", ""Calista""]
Notes
Don't change the order of the original array.
Notice in the second example above, ""MABELLE"" is returned as ""Mabelle"".";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
