namespace Ellabit.Challenges
{
    public class Challenge309Smallesttransform : IChallenge
    {
        public string? Header { get; set; } = "Smallest transform";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int SmallestTransform(int num) 
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
            sumResult = tmp.smallesttransform(399)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   6
//  399  transformed  to  999  in  6  steps.

,  $""returned: {sumResult}  expected: 6
//  399  transformed  to  999  in  6  steps."");
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
        public string? Description { get; set; } = @"Create a function that returns the smallest number of changes it takes to transform one number into one with identical digits. A step is incrementing or decrementing a digit by one.

Examples
SmallestTransform(399) ➞ 6
// 399 transformed to 999 in 6 steps.

SmallestTransform(1234) ➞ 4
// 1234 can be transformed to either 2222 or 3333 using 4 steps.

SmallestTransform(153) ➞ 4

SmallestTransform(33338) ➞ 5

SmallestTransform(7777) ➞ 0
Notes
If a number already has identical digits, return 0.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
