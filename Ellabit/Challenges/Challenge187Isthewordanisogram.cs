namespace Ellabit.Challenges
{
    public class Challenge187Isthewordanisogram : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Is the word an isogram?";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ellabit
{
    public class Challenge 
    {
        public  bool IsIsogram(string str) 
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
            sumResult = tmp.IsIsogram(""Algorism"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true ,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsIsogram(""PasSword"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsIsogram(""Consecutive"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
}
";
        public string? Description { get; set; } = @"An content  isogram  is  a  word  that  has  no  duplicate  letters.  create  a  function  that  takes  a  string  and  returns  either  true  or  false  depending  on  whether  or  not  it's  an  "" isogram"". 

        <h5>Examples</h5>
        <code>
IsIsogram(""Algorism"") ➞ true 
IsIsogram(""PasSword"") ➞ false
//Not case sensitive
IsIsogram(""Consecutive"") ➞ false
            </p>
        </code>


Notes
Ignore letter case (should not be case sensitive).
All test cases contain valid one word strings.
""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
