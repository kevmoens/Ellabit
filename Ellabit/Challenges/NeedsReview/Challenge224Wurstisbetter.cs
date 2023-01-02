namespace Ellabit.Challenges
{
    public class Challenge224Wurstisbetter : IChallenge
    {
        public string? Header { get; set; } = "Wurst is better";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string WurstIsBetter(string str) 
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
        string sumResult;
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
        public string? Description { get; set; } = @"Wurst is the best. Create a function that takes a string and replaces every mention of any type of sausage with the German word ""Wurst,"" unless—of course—the sausage is already a type of German ""Wurst"" (i.e. ""Bratwurst"", see below), then leave the sausage name unchanged.
<table>
<tr><th><b>German Wursts</b></th>	<th><b>Convert to Wurst</b></th></tr>
<tr><td>Bratwurst</td><td>Kielbasa</td></tr>
<tr><td>Kochwurst</td><td>Chorizo</td></tr>
<tr><td>Leberwurst</td><td>Moronga</td></tr>
<tr><td>Mettwurst</td><td>Salami</td></tr>
<tr><td>Rostbratwurst</td><td>Sausage</td></tr>
<tr><td>~</td><td>Andouille</td></tr>
<tr><td>~</td><td>Naem</td></tr>
<tr><td>~</td><td>Merguez</td></tr>
<tr><td>~</td><td>Gurka</td></tr>
<tr><td>~</td><td>Snorkers</td></tr>
<tr><td>~</td><td>Pepperoni</td></tr>
</table>
Rules
Append sausages from the ""Convert to Wurst"" column with ""wurst"".
Do not replace any German sausage with the word ""Wurst"".
The word ""Wurst"" must be title case.
Examples
WurstIsBetter(""I like chorizos, but not sausages"") ➞ ""I like Wursts, but not Wursts""

WurstIsBetter(""sich die Wurst vom Brot nehmen lassen"") ➞ ""sich die Wurst vom Brot nehmen lassen""

WurstIsBetter(""Bratwurst and Rostbratwurst are sausages"") ➞ ""Bratwurst and Rostbratwurst are Wursts""
Notes
All German sausage names contain the word ""wurst"".";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
