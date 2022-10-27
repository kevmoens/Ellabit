namespace Ellabit.Challenges
{
    public class Challenge191Checkifanumberisapalindrome : IChallenge
    {
        public string? Header { get; set; } = "Check if a number is a palindrome";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool IsPalindrome(int num)
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
            sumResult = tmp.IsPalindrome(838)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsPalindrome(4433)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsPalindrome(443344)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true,   $""returned: {sumResult}  expected: true"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  returns  true  if  a  number  is  a  palindrome.

        <h5>Examples</h5>
        <code>
ispalindrome(838)  ➞  true

ispalindrome(4433)  ➞  false

ispalindrome(443344)  ➞  true
            </p>
        </code>

notes
a  palindrome  is  a  number  that  remains  the  same  when  reversed.
bonus:  try  solving  this  without  turning  the  number  into  a  string.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
