namespace Ellabit.Challenges
{
    public class Challenge349Generateallnonconsecutivebinarystrings : IChallenge
    {
        public string? Header { get; set; } = "Generate all nonconsecutive binary strings";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
    public  string GenerateNonconsecutive(int len)
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
            sumResult = tmp.generatenonconsecutive(1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   "" 0 1"" ,  $""returned: {sumResult}  expected:  0 1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.generatenonconsecutive(2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""00 01 10"" ,   $""returned: {sumResult}  expected: 00 01 10"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.generatenonconsecutive(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""000 001 010 100 101"" ,   $""returned: {sumResult}  expected: 000 001 010 100 101"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  to  generate  all  nonconsecutive  binary  strings  where  nonconsecutive  is  defined  as  a  string  where  no  consecutive  ones  are  present,  and  where  len  governs  the  length  of  each  binary  string.

examples
generatenonconsecutive(1)  ➞  "" 0 1"" generatenonconsecutive(2) ➞ ""00 01 10"" generatenonconsecutive(3) ""000 001 010 100 101"" generatenonconsecutive(""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
