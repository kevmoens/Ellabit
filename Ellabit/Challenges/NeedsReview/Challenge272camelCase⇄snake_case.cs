namespace Ellabit.Challenges
{
    public class Challenge272camelCasesnake_case : IChallenge
    {
        public string? Header { get; set; } = "camelCase ⇄ snake_case";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string ToSnakeCase(string str) 
    {
    }
    public  string ToCamelCase(string str) 
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
            sumResult = tmp.tocamelcase("" hello_ellabit"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""helloellabit"" tosnakecase(""helloellabit"") ""hello_ellabit"" ,  $""returned: {sumResult}  expected: helloellabit tosnakecase('helloellabit') hello_ellabit"");
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
        public string? Description { get; set; } = @"Create two functions ToCamelCase() and ToSnakeCase() that each take a single string and convert it into either camelCase or snake_case. If you're not sure what these terms mean, check the Resources tab above.

Examples
ToCamelCase(""hello_edabit"") ➞ ""helloEdabit""

ToSnakeCase(""helloEdabit"") ➞ ""hello_edabit""

ToCamelCase(""is_modal_open"") ➞ ""isModalOpen""

ToSnakeCase(""getColor"") ➞ ""get_color""
Notes
Test input will always be appropriately formatted as either camelCase or snake_case, depending on the function being called.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
