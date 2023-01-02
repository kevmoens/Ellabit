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
        public string? Description { get; set; } = @"Create a function that takes a string (IPv4 address in standard dot-decimal format) and returns true if the IP is valid or false if it's not. For information on IPv4 formatting, please refer to the resources in the Resources tab.

Examples
IsValidIP(""1.2.3.4"") ➞ true

IsValidIP(""1.2.3"") ➞ false

IsValidIP(""1.2.3.4.5"") ➞ false

IsValidIP(""123.45.67.89"") ➞ true

IsValidIP(""123.456.78.90"") ➞ false

IsValidIP(""123.045.067.089"") ➞ false
Notes
IPv6 addresses are not valid.
Leading zeros are not valid (""123.045.067.089"" should return false).
You can expect a single string for every test case.
Numbers may only be between 1 and 255.
The last digit may not be zero, but any other might.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
