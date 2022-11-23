namespace Ellabit.Challenges
{
    public class Challenge279Splitthestringintoncasesofequallength : IChallenge
    {
        public string? Header { get; set; } = "Split the string into n cases of equal length";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
    public  string[] SplitNCases(string input, int cases)
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
        string[] sumResult;
        try 
        {
            sumResult = tmp.splitncases("" strengthened"", 6) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  { ""st"", ""re"", ""ng"", ""th"", ""en"", ""ed"" } ,  $""returned: {sumResult}  expected: { st, re, ng, th, en, ed }"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.splitncases(""unscrupulous"", 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""unscru"", ""pulous"" ,   $""returned: {sumResult}  expected: unscru, pulous"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  accepts  string  input  and  int  cases  as  parameters  where  the  string  is  split  into  n  distinct  cases  of  equal  length  as  shown:

examples
splitncases("" strengthened"", 6) ➞ { ""st"", ""re"", ""ng"", ""th"", ""en"", ""ed"" } splitncases(""unscrupulous"", 2) ""unscru"", ""pulous"" splitncases(""flavorless"", 1) ""flavorless"" notes if it's not possible""";
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
