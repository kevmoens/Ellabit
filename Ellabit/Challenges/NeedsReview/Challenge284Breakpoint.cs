namespace Ellabit.Challenges
{
    public class Challenge284Breakpoint : IChallenge
    {
        public string? Header { get; set; } = "Break point";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  bool BreakPoint(int num) 
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
        bool sumResult;
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
        bool sumResult;
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
        public string? Description { get; set; } = @"A number has a breakpoint if it can be split in a way where the digits on the left side and the digits on the right side sum to the same number.

For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9 and 9 + 0 = 9. On the other hand, the number 555 does not have a breakpoint (you must split between digits).

Create a function that returns true if a number has a breakpoint, and false otherwise.

Examples
BreakPoint(159780) ➞ true

BreakPoint(112) ➞ true

BreakPoint(1034) ➞ true

BreakPoint(10) ➞ false

BreakPoint(343) ➞ false
Notes
Read each digit as only one number.
Check the Resources tab for a hint.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
