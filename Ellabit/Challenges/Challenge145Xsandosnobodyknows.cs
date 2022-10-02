namespace Ellabit.Challenges
{
    public class Challenge145Xsandosnobodyknows : IChallenge
    {
        public string? Header { get; set; } = "Xs and os, nobody knows";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  bool XO(string str) 
    {
        
    }
}


}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.XO(""ooxx"");
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
            sumResult = tmp.XO(""xooxx"");
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
            sumResult = tmp.XO(""ooxXm"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.XO(""zpzpzpp"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.XO(""zzoo"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string,  checks  if  it  has  the  same  number  of  x's  and  o's  and  returns  either  true  or  false.

return  a  boolean  value  (true  or  false).
return  true  if  the  amount  of  x's  and  o's  are  the  same.
return  false  if  they  aren't  the  same  amount.
the  string  can  contain  any  character.
when  "" x"" and ""o"" are not in the string, return true. 

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
XO(""ooxx"") ➞ true

XO(""xooxx"") ➞ false

XO(""ooxXm"") ➞ true
// Case insensitive.

XO(""zpzpzpp"") ➞ true
// Returns true if no x and o.

XO(""zzoo"") ➞ false
            </p>
        </code>
Notes
Remember to return true if there aren't any x's or o's.
Must be case insensitive.
            """;
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
