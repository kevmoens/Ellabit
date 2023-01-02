namespace Ellabit.Challenges
{
    public class Challenge369Characterrecognition⁠whatsthetime : IChallenge
    {
        public string? Header { get; set; } = "Character recognition ⁠— what's the time?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  string WhatsTheTime(string bitmap)
	{
			return """";
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
        public string? Description { get; set; } = @"As content  a  programmer  in  a  forensic  laboratory,  you  have  been  asked  to  write  a  function  to  decode  a  bitmap  image  of  a  digital  clock  to  determine  what  time  it  was  when  the  image  was  created.  the  bitmap  image  has  been  converted  to  a  string  of  binary  digits  0  or  1  where  0  represents  a  white  background  pixel  and  1  represents  a  black  pixel.  you  must  convert  this  binary  s""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
