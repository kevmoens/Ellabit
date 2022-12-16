namespace Ellabit.Challenges
{
    public class Challenge303Adddollarbills : IChallenge
    {
        public string? Header { get; set; } = "Add dollar bills";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int AddBill(string money) {
			
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
        public string? Description { get; set; } = @"Create a function that takes a string containing money in dollars and pounds sterling (seperated by comma+space) and returns the sum of dollar bills only, as an integer.

For the input string:

Each amount is prefixed by the currency symbol: $ for dollars and £ for pounds.
Thousands are represented by the suffix k.
i.e. $4k = $4,000 and £40k = £40,000

Examples
AddBill(""$20, £40, £60, $50"") ➞ 70
// 20 + 50 = 70

AddBill(""£30, $20, £60, $150, £360"") ➞ 170
// 20  + 150 = 170

AddBill(""£30, $2k, £60, $200, £360"") ➞ 2200
// 2 * 1000 + 200 = 2200
Notes
There is at least one dollar bill in string.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
