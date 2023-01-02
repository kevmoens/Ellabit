namespace Ellabit.Challenges
{
    public class Challenge199IsthePhoneNumberFormattedCorrectly : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Is the phone number formatted correctly?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{


public class Challenge 
{
    public  bool IsValidPhoneNumber(string str) 
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
        bool sumResult;
        try 
        {
            sumResult = tmp.isvalidphonenumber(""(123) 456-7890"") ;
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
                sumResult = tmp.IsValidPhoneNumber(""1111)555 2345"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
        }
            return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
                sumResult = tmp.IsValidPhoneNumber(""098) 123 4567"");
        } catch (Exception ex) 
        {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == false,  $""returned: {sumResult}  expected: false"");
        }
    }
}
";
        public string? Description { get; set; } = @"<div><p><span>Create a function that accepts a string and returns </span><code>true</code><span> if it's in the format of a proper phone number and </span><code>false</code><span> if it's not. Assume any number between 0-9 (in the appropriate spots) will produce a valid phone number.</span></p><p><span>This is what a valid phone number looks like:</span></p><pre><code>(123) 456-7890</code></pre><h3><span>Examples</span></h3><pre><code>IsValidPhoneNumber(""(123) 456-7890"") ➞ true

IsValidPhoneNumber(""1111)555 2345"") ➞ false

IsValidPhoneNumber(""098) 123 4567"") ➞ false</code></pre><h3><span>Notes</span></h3><p><span>Don't forget the space after the closing parenthesis.</span></p></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
