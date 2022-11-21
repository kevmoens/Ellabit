namespace Ellabit.Challenges
{
    public class Challenge251Converttohex : IChallenge
    {
        public string? Header { get; set; } = "Convert to hex";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
    public  string ConvertToHex(string inputword) 
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
            sumResult = tmp.converttohex("" hello world"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""68 65 6c 6f 20 77 72 64"" ,  $""returned: {sumResult}  expected: 68 65 6c 6f 20 77 72 64"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.converttohex(""big boi"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""42 69 67 42 69"" ,   $""returned: {sumResult}  expected: 42 69 67 42 69"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.converttohex(""marty poppinson"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""4d 61 74 79 50 70 6e 73 6e"" ,   $""returned: {sumResult}  expected: 4d 61 74 79 50 70 6e 73 6e"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string's  characters  as  ascii  and  returns  each  character's  hexadecimal  value  as  a  string.

examples
converttohex("" hello world"") ➞ ""68 65 6c 6f 20 77 72 64"" converttohex(""big boi"") ""42 69 67 42 69"" converttohex(""marty poppinson"") ""4d 61 74 79 50 70 6e 73 6e"" notes each byte must be seperated""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
