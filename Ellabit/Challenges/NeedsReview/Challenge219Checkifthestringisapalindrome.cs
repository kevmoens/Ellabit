namespace Ellabit.Challenges
{
    public class Challenge219Checkifthestringisapalindrome : IChallenge
    {
        public string? Header { get; set; } = "Check if the string is a palindrome";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool IsPalindrome(string str) 
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
            sumResult = tmp.ispalindrome("" neuquen"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
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
        public string? Description { get; set; } = @"A palindrome is a word, phrase, number or other sequence of characters which reads the same backward or forward, such as madam or kayak.

Write a function that takes a string and determines whether it's a palindrome or not. The function should return a boolean (true or false value).

Examples
IsPalindrome(""Neuquen"") ➞ true

IsPalindrome(""Not a palindrome"") ➞ false

IsPalindrome(""A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!"") ➞ true
Notes
Should be case insensitive.
Special characters (punctuation or spaces) should be ignored.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
