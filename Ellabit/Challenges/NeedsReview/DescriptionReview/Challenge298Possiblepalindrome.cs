namespace Ellabit.Challenges
{
    public class Challenge298Possiblepalindrome : IChallenge
    {
        public string? Header { get; set; } = "Possible palindrome";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool PossiblePalindrome(string str) 
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
            sumResult = tmp.possiblepalindrome("" acabbaa"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true can make the following palindrome: ""aabcbaa"" ,  $""returned: {sumResult}  expected: true can make the following palindrome: aabcbaa"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.possiblepalindrome(""aacbdbc"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""abcdcba"" ,   $""returned: {sumResult}  expected: abcdcba"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.possiblepalindrome(""aacbdb"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  determines  whether  it  is  possible  to  build  a  palindrome  from  the  characters  in  a  string.

examples
possiblepalindrome("" acabbaa"") ➞ true can make the following palindrome: ""aabcbaa"" possiblepalindrome(""aacbdbc"") ""abcdcba"" possiblepalindrome(""aacbdb"") false possiblepalindrome(""abacbb"") ➞""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
