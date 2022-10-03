namespace Ellabit.Challenges
{
    public class Challenge143Returnthefourletterstrings : IChallenge
    {
        public string? Header { get; set; } = "Return the four letter strings";
        public string? Code { get; set; } = @"
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ellabit {

using System.Collections.Generic;
public class Challenge 
{
    public  string[] IsFourLetters(string[] arr) 
    {
        
    }
}


}";
        public string? TestCode { get; set; } = @"
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.IsFourLetters(new string[] {""tomato"", ""potato"", ""pair""}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual( new string[] {""pair""}.ToList()) ,  $""returned: {sumResult}  expected: [pair]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.IsFourLetters(new string[] {""kangaroo"", ""bear"", ""fox""});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual( new string[] {""bear""}.ToList()) ,   $""returned: {sumResult}  expected: [bear]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.IsFourLetters(new string[] {""ryan"", ""kieran"", ""jason"", ""matt""});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual( new string[] {""ryan"", ""matt""}.ToList()),  $""returned: {sumResult}  expected: [ryan, matt]"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  strings  and  returns  the  words  that  are  exactly  four  letters.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
isfourletters([""tomato"", ""potato"", ""pair""]) ➞ [""pair""] 
isfourletters([""kangaroo"", ""bear"", ""fox""]) ➞ [""bear""] 
isfourletters([""ryan"", ""kieran"", ""jason"", ""matt""]) ➞ [""ryan"", ""matt""] 
            </p>
        </code>

notes you can expect valid strings for all test cases.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
