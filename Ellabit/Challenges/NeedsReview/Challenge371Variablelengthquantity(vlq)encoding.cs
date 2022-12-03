namespace Ellabit.Challenges
{
    public class Challenge371Variablelengthquantityvlqencoding : IChallenge
    {
        public string? Header { get; set; } = "Variable length quantity (vlq) encoding";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge {
  	public  byte[] IntToVlq(long n) {
		
	}

  	public  long VlqToInt(byte[] arr) {

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
        byte[] sumResult;
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
        byte[] sumResult;
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
        byte[] sumResult;
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
        public string? Description { get; set; } = @"In content  this  challenge  you  have  to  create  functions  to  encode  and  decode  variable-length  quantities.  a  variable-length  quantity  (vlq)  is  a  universal  code  that  uses  an  arbitrary  number  of  binary  octets  (eight-bit  bytes)  to  represent  an  arbitrarily  large  integer.  a  vlq  is  essentially  a  base-128  representation  of  an  unsigned  integer  with  the  addition  of  the  eighth  bit""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
