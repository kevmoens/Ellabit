namespace Ellabit.Challenges
{
    public class Challenge159Countthelettersanddigits : IChallenge
    {
        public string? Header { get; set; } = "Count the letters and digits";
        public string? Code { get; set; } = @"
using System;
namespace Ellabit {

using System.Linq;
using System;

public class Challenge 
{
    public  string count_all(string txt) 
    {	 	
		
    }
}}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.count_all(""Hello World"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""LETTERS = 10, DIGITS = 0"" ,  $""returned: {sumResult}  expected: LETTERS = 10, DIGITS = 0"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.count_all(""H3ll0 Wor1d"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""LETTERS = 7, DIGITS = 3"",   $""returned: {sumResult}  expected: LETTERS = 7, DIGITS = 3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.count_all(""149990"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""LETTERS = 0, DIGITS = 5"",   $""returned: {sumResult}  expected: LETTERS = 0, DIGITS = 5"");
    }
}
}";
        public string? Description { get; set; } = @"Write content  a  function  that  takes  a  string  and  calculates  the  number  of  letters  and  digits  within  it.  return  the  result  as  anonymous  type  in  string  format.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
count_all(""Hello World"") ➞ ""LETTERS = 10, DIGITS = 0""

count_all(""H3ll0 Wor1d"") ➞ ""LETTERS = 7, DIGITS = 3""

count_all(""149990"") ➞ ""LETTERS = 0, DIGITS = 6""
            </p>
        </code>

Notes
Tests contain only alphanumeric characters.
Spaces are not letters.
All tests contain valid strings.
Return the result as anonymous type.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
