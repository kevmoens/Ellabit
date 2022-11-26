namespace Ellabit.Challenges
{
    public class Challenge307IPv4validation : IChallenge
    {
        public string? Header { get; set; } = "IPv4 validation";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool IsValidIP(string IP)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.isvalidip("" 1.2.3.4"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isvalidip(""1.2.3"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.isvalidip(""1.2.3.4.5"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ,   $""returned: {sumResult}  expected: "");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  (ipv4  address  in  standard  dot-decimal  format)  and  returns  true  if  the  ip  is  valid  or  false  if  it's  not.  for  information  on  ipv4  formatting,  please  refer  to  the  resources  in  the  resources  tab.

examples
isvalidip("" 1.2.3.4"") ➞ true isvalidip(""1.2.3"") false isvalidip(""1.2.3.4.5"") isvalidip(""123.45.67.89"") true""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
