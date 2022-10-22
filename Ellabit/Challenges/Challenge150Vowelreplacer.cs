namespace Ellabit.Challenges
{
    public class Challenge150Vowelreplacer : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Vowel replacer";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  string ReplaceVowels(string str, string ch)
    {
        
    }
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ReplaceVowels(""the aardvark"", ""#"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""th# ##rdv#rk"" ,  $""returned: {sumResult}  expected: th# ##rdv#rk"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ReplaceVowels(""minnie mouse"", ""?"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""m?nn?? m??s?"" ,   $""returned: {sumResult}  expected: m?nn?? m??s?"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ReplaceVowels(""shakespeare"", """");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""shkspr"",   $""returned: {sumResult}  expected: shkspr"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  replaces  all  the  vowels  in  a  string  with  a  specified  character.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
replacevowels(""the aardvark"", ""#"") ➞ ""th# ##rdv#rk"" 
replacevowels(""minnie mouse"", ""?"") ""m?nn?? m??s?"" 
replacevowels(""shakespeare"", """") ""shkspr""
            </p>
        </code>

notes all characters will be in lower case.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "Comparison" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
