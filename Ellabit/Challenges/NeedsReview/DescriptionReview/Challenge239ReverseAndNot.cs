namespace Ellabit.Challenges
{
    public class Challenge239ReverseAndNot : IChallenge
    {
        public string? Header { get; set; } = "  \"ReverseAndNot\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;



";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.reverseandnot(123) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""321123"" ,  $""returned: {sumResult}  expected: 321123"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.reverseandnot(152);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""251152"" ,   $""returned: {sumResult}  expected: 251152"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.reverseandnot(123456789);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""987654321123456789"" ,   $""returned: {sumResult}  expected: 987654321123456789"");
    }
}
";
        public string? Description { get; set; } = @"Write content  a  function  that  takes  an  integer  i  and  returns  a  string  with  the  integer  backwards  followed  by  the  original  integer.

to  illustrate:

"" 123"" we reverse ""123"" to get ""321"" and then add the end, resulting in ""321123"". examples reverseandnot(123) ➞ ""321123"" reverseandnot(152) ""251152"" reverseandnot(123456789) ""987654321123456789"" notes i is""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
