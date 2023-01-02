namespace Ellabit.Challenges
{
    public class Challenge316Simplifiedfractions : IChallenge
    {
        public string? Header { get; set; } = "Simplified fractions";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string Simplify(string str) 
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
        string sumResult;
        try 
        {
            sumResult = tmp.simplify("" 4 6"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""2 3"" ,  $""returned: {sumResult}  expected: 2 3"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.simplify(""10 11"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""10 11"" ,   $""returned: {sumResult}  expected: 10 11"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.simplify(""100 400"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""1 4"" ,   $""returned: {sumResult}  expected: 1 4"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that returns the simplified version of a fraction.

Examples
Simplify(""4/6"") ➞ ""2/3""

Simplify(""10/11"") ➞ ""10/11""

Simplify(""100/400"") ➞ ""1/4""

Simplify(""8/4"") ➞ ""2""
Notes
A fraction is simplified if there are no common factors (except 1) between the numerator and the denominator. For example, 4/6 is not simplified, since 4 and 6 both share 2 as a factor.
If improper fractions can be transformed into integers, do so in your code (see example #4).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
