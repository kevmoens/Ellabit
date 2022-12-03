namespace Ellabit.Challenges
{
    public class Challenge372Englishtopiglatintranslator : IChallenge
    {
        public string? Header { get; set; } = "English to pig latin translator";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Challenge 
{
    public  string TranslateWord(string word) 
    {
			return """";
    }

  	public  string TranslateSentence(string sentence)
    {
      return """";
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
        public string? Description { get; set; } = @"Pig content  latin  has  two  very  simple  rules:

if  a  word  starts  with  a  consonant  move  the  first  letter(s)  of  the  word,  till  you  reach  a  vowel,  to  the  end  of  the  word  and  add  "" ay"" to the end. have ➞ avehay cram amcray take aketay cat atcay shrimp impshray trebuchet ebuchettray if a word starts with vowel add ""yay"" end of word.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
