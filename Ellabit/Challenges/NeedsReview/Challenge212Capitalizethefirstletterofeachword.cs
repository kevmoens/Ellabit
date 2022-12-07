namespace Ellabit.Challenges
{
    public class Challenge212Capitalizethefirstletterofeachword : IChallenge
    {
        public string? Header { get; set; } = "Capitalize the first letter of each word";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;
public class Challenge 
{
    public  string MakeTitle(string str) 
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
            sumResult = tmp.maketitle("" this is a title"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""this title"" ,  $""returned: {sumResult}  expected: this title"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.maketitle(""capitalize every word"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""capitalize word"" ,   $""returned: {sumResult}  expected: capitalize word"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.maketitle(""i like pizza"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""i pizza"" ,   $""returned: {sumResult}  expected: i pizza"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a string as an argument and converts the first character of each word to uppercase. Return the newly formatted string.

Examples
MakeTitle(""This is a title"") ➞ ""This Is A Title""

MakeTitle(""capitalize every word"") ➞ ""Capitalize Every Word""

MakeTitle(""I Like Pizza"") ➞ ""I Like Pizza""

MakeTitle(""PIZZA PIZZA PIZZA"") ➞ ""PIZZA PIZZA PIZZA""
Notes
You can expect a valid string for each test case.
Some words may contain more than one uppercase letter (see example #4).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
