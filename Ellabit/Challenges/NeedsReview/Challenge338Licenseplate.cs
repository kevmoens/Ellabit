namespace Ellabit.Challenges
{
    public class Challenge338Licenseplate : IChallenge
    {
        public string? Header { get; set; } = "License plate";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  string LicensePlate(string s, int n) {
		
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
        public string? Description { get; set; } = @"Travelling through Europe one needs to pay attention to how the license plate in the given country is displayed. When crossing the border you need to park on the shoulder, unscrew the plate, re-group the characters according to the local regulations, attach it back and proceed with the journey.

Create a solution that can format the dmv number into a plate number with correct grouping. The function input consists of string s and group length n. The output has to be upper case characters and digits. The new groups are made from right to left and connected by -. The original order of the dmv number is preserved.

Examples
licensePlate(""5F3Z-2e-9-w"", 4) ➞ ""5F3Z-2E9W""

licensePlate(""2-5g-3-J"", 2) ➞ ""2-5G-3J""

licensePlate(""2-4A0r7-4k"", 3) ➞ ""24-A0R-74K""

licensePlate(""nlj-206-fv"", 3) ➞ ""NL-J20-6FV""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
