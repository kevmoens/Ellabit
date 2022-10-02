namespace Ellabit.Challenges
{
    public class Challenge182Returnthehighestandlowestnumbers : IChallenge
    {
        public string? Header { get; set; } = "Return the highest and lowest numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit{
    public class Challenge 
    {
        public  string HighLow(string str) 
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
            sumResult = tmp.HighLow(""1 2 3 4 5"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""5 1"",  $""returned: {sumResult}  expected: 5 1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HighLow(""1 2 -3 4 5"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""5 -3"",   $""returned: {sumResult}  expected: 5 -3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HighLow(""1 9 3 3 4 -5"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""9 -5"",   $""returned: {sumResult}  expected: 9 -5"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.HighLow(""13"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""13 13"",   $""returned: {sumResult}  expected: 13 13"");
    }
}
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  accepts  a  string  of  space  separated  numbers  and  returns  the  highest  and  lowest  number  (as  a  string).

        <h5>Examples</h5>
        <code>
highlow(""1 2 3 4 5"") ➞ ""5 1"" 
highlow(""1 2 -3 4 5"") ➞ ""5 -3"" 
highlow(""1 9 3 3 4 -5"") ➞ ""9 -5"" 
highlow(""13"") ➞ ""13 13"" 
            </p>
        </code>
notes 
all numbers are valid int32, no need to validate them. 
there will always be at least one number in the input string
Output string must be two numbers separated by a single space, and highest number is first.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
