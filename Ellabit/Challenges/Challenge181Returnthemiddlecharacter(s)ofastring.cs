namespace Ellabit.Challenges
{
    public class Challenge181Returnthemiddlecharactersofastring : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Return the middle character(s) of a string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit{
    public class Challenge 
    {
	    public string GetMiddle(string str) 
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
        string sumResult;
        try 
        {
            sumResult = tmp.GetMiddle("" test"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""es"" ,  $""returned: {sumResult}  expected: es"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetMiddle(""testing"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""t"" ,   $""returned: {sumResult}  expected: t"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetMiddle(""middle"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""dd"" ,   $""returned: {sumResult}  expected: dd"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetMiddle(""a"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""a"" ,   $""returned: {sumResult}  expected: a"");
    }
}
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  and  returns  the  middle  character(s).  if  the  word's  length  is  odd,  return  the  middle  character.  if  the  word's  length  is  even,  return  the  middle  two  characters.

        <h5>Examples</h5>
        <code>
getmiddle("" test"") ➞ ""es"" 
getmiddle(""testing"") ""t"" 
getmiddle(""middle"") ""dd"" 
getmiddle(""a"") ""a"" 
            </p>
        </code>
notes all test cases contain a single word (as string)""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
