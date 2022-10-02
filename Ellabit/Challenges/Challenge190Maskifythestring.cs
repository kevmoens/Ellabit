using ICSharpCode.Decompiler.Util;
using static Humanizer.In;

namespace Ellabit.Challenges
{
    public class Challenge190Maskifythestring : IChallenge
    {
        public string? Header { get; set; } = "Maskify the string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge 
    {
        public  string Maskify(string str) 
        {
      
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Maskify(""4556364607935616"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""############5616"",  $""returned: {sumResult}  expected: ############5616"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Maskify(""64607935616"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""#######5616"",   $""returned: {sumResult}  expected: #######5616"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Maskify(""1"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""1"",   $""returned: {sumResult}  expected: '1'"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Maskify("""");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == """",   $""returned: {sumResult}  expected: ''"");
    }
}
}
";
        public string? Description { get; set; } = @"Usually when you sign up for an account to buy something, your credit card number, phone number or answer to a secret question is partially obscured in some way. Since someone could look over your shoulder, you don't want that shown on your screen. Hence, the website masks these strings.

Your task is to create a function that takes a string, transforms all but the last four characters into ""#"" and returns the new masked string.

        <h5>Examples</h5>
        <code>
Maskify(""4556364607935616"") ➞ ""############5616""

Maskify(""64607935616"") ➞ ""#######5616""

Maskify(""1"") ➞ ""1""

Maskify("""") ➞ """"
            </p>
        </code>

Notes
        The maskify function must accept a string of any length.
An empty string should return an empty string (fourth example above).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
