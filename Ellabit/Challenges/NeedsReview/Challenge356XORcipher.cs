namespace Ellabit.Challenges
{
    public class Challenge356XORcipher : IChallenge
    {
        public string? Header { get; set; } = "XOR cipher";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  string XORCipher(string msg1, string msg2)
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
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
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
        string sumResult;
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
        public string? Description { get; set; } = @"In content  xor  cipher,  encoding  is  done  by  an  xor  operation  on  two  given  strings.  if  the  strings  are  of  different  lengths  then  the  output  should  be  the  length  of  the  shorter  string.  cut  the  length  of  the  longer  string  to  the  same  size  as  the  smaller  string  before  xor  operation.

given  two  strings  of  msg1  and  msg2,  return  the  encoded  message.

examples
xorcipher("" 11"", """;
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
