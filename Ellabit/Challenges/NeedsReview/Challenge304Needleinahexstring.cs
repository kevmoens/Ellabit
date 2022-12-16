namespace Ellabit.Challenges
{
    public class Challenge304Needleinahexstring : IChallenge
    {
        public string? Header { get; set; } = "  \"Needle in a hex string\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
public class Challenge 
{
    public  int FirstIndex(string hexString, string needle)
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
        int sumResult;
        try 
        {
            sumResult = tmp.firstindex("" 68 65 6c 6f 20 77 72 64"", ""world"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  6 ,  $""returned: {sumResult}  expected: 6"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
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
        public string? Description { get; set; } = @"Find the index of a string within a hex encoded string.

You will be given a string which needs to be found in another string which has previously been translated into hex. You will need to return the first index of the needle within the hex encoded string.

Examples
FirstIndex(""68 65 6c 6c 6f 20 77 6f 72 6c 64"", ""world"") ➞ 6

FirstIndex(""47 6f 6f 64 62 79 65 20 77 6f 72 6c 64"", ""world"") ➞ 8

FirstIndex(""42 6f 72 65 64 20 77 6f 72 6c 64"", ""Bored"") ➞ 0";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
