namespace Ellabit.Challenges
{
    public class Challenge313Closestpalindromenumber : IChallenge
    {
        public string? Header { get; set; } = "Closest palindrome number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int ClosestPalindrome(int num) {
			
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
        int sumResult;
        try 
        {
            sumResult = tmp.closestpalindrome(887)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   888

,  $""returned: {sumResult}  expected: 888"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.closestpalindrome(100)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   99
//  99  and  101  are  equally  distant,  so  we  return  the  smaller  palindrome.

,   $""returned: {sumResult}  expected: 99
//  99  and  101  are  equally  distant,  so  we  return  the  smaller  palindrome."");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.closestpalindrome(888)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   888

,   $""returned: {sumResult}  expected: 888"");
    }
}
";
        public string? Description { get; set; } = @"Write content  a  function  that  returns  the  closest  palindrome  number  to  an  integer.  if  two  palindrome  numbers  tie  in  absolute  distance,  return  the  smaller  number.

examples
closestpalindrome(887)  ➞  888

closestpalindrome(100)  ➞  99
//  99  and  101  are  equally  distant,  so  we  return  the  smaller  palindrome.

closestpalindrome(888)  ➞  888

closestpalindrome(27)  ➞  22

notes
if""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
