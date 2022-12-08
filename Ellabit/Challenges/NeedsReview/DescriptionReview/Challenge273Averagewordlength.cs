namespace Ellabit.Challenges
{
    public class Challenge273Averagewordlength : IChallenge
    {
        public string? Header { get; set; } = "Average word length";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  double AverageWordLength(string str) 
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
        double sumResult;
        try 
        {
            sumResult = tmp.averagewordlength("" a b c."") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1.00 ,  $""returned: {sumResult}  expected: 1.00"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.averagewordlength(""what gorgeous day."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  4.00 ,   $""returned: {sumResult}  expected: 4.00"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.averagewordlength(""dude, this is so awesome!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  3.80 ,   $""returned: {sumResult}  expected: 3.80"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  in  a  sentence  and  returns  the  average  length  of  each  word  in  that  sentence.  round  your  result  to  two  decimal  places.

examples
averagewordlength("" a b c."") ➞ 1.00 averagewordlength(""what gorgeous day."") 4.00 averagewordlength(""dude, this is so awesome!"") 3.80 notes ignore punctuation when counting the length of word.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
