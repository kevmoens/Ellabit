namespace Ellabit.Challenges
{
    public class Challenge257Almostpalindrome : IChallenge
    {
        public string? Header { get; set; } = "Almost palindrome";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool AlmostPalindrome(string str) 
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
            sumResult = tmp.almostpalindrome("" abcdcbg"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true transformed to ""abcdcba"" by changing ""g"" ""a"". ,  $""returned: {sumResult}  expected: true transformed to abcdcba by changing g a."");
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
        public string? Description { get; set; } = @"A content  string  is  an  almost-palindrome  if,  by  changing  only  one  character,  you  can  make  it  a  palindrome.  create  a  function  that  returns  true  if  a  string  is  an  almost-palindrome  and  false  otherwise.

examples
almostpalindrome("" abcdcbg"") ➞ true transformed to ""abcdcba"" by changing ""g"" ""a"". almostpalindrome(""abccia"") ""abccba"" changing""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
