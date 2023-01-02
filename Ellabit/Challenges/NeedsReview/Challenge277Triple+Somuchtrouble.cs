namespace Ellabit.Challenges
{
    public class Challenge277TripleSomuchtrouble : IChallenge
    {
        public string? Header { get; set; } = "Triple + So much trouble";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool Trouble(long num1, long num2)
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
            sumResult = tmp.trouble(451999277,  41177722899)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true

,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.trouble(1222345,  12345)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false

,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.trouble(666789,  12345667)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true

,   $""returned: {sumResult}  expected: true"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes two integers and returns true if a digit repeats three times in a row at any place in num1 AND that same digit repeats two times in a row in num2.

Examples
Trouble(451999277, 41177722899) ➞ true

Trouble(1222345, 12345) ➞ false

Trouble(666789, 12345667) ➞ true

Trouble(33789, 12345337) ➞ false
Notes
You can expect every test case to contain exactly two integers.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
