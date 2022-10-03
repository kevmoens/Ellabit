using ICSharpCode.Decompiler.Util;

namespace Ellabit.Challenges
{
    public class Challenge186Strangepair : IChallenge
    {
        public string? Header { get; set; } = "Strange pair";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
        public  bool IsStrangePair(string str1, string str2)
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
            sumResult = tmp.IsStrangePair(""ratio"", ""orator"");
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
            sumResult = tmp.IsStrangePair(""sparkling"", ""groups"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsStrangePair(""bush"", ""hubris"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsStrangePair("""", """");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
}
";
        public string? Description { get; set; } = @"A content  pair  of  strings  form  a  strange  pair  if  both  of  the  following  are  true:

the  1st  string's first letter = 2nd string's last letter.
the  1st  string's last letter = 2nd string's first  letter.

create  a  function  that  returns  true  if  a  pair  of  strings  constitutes  a  strange  pair,  and  false  otherwise.

        <h5>Examples</h5>
        <code>
IsStrangePair(""ratio"", ""orator"") ➞ true
// ""ratio"" ends with ""o"" and ""orator"" starts with ""o"".
// ""ratio"" starts with ""r"" and ""orator"" ends with ""r"".

IsStrangePair(""sparkling"", ""groups"") ➞ true

IsStrangePair(""bush"", ""hubris"") ➞ false

IsStrangePair("""", """") ➞ true
            </p>
        </code>

Notes
It should work on a pair of empty strings(they trivially share nothing).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
