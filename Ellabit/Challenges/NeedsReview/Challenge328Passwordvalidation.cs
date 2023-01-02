namespace Ellabit.Challenges
{
    public class Challenge328Passwordvalidation : IChallenge
    {
        public string? Header { get; set; } = "Password validation";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool ValidatePassword(string password)
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
        public string? Description { get; set; } = @"Create a function that validates a password to conform to the following rules:

Length between 6 and 24 characters.
At least one uppercase letter (A-Z).
At least one lowercase letter (a-z).
At least one digit (0-9).
Maximum of 2 repeated characters.
""aa"" is OK 👍
""aaa"" is NOT OK 👎
Supported special characters:
! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; "" ' ? < > , .
Examples
ValidatePassword(""P1zz@"") ➞ false
// Too short.

ValidatePassword(""iLoveYou"") ➞ false
// Missing a number.

ValidatePassword(""Fhg93@"") ➞ true
// OK!";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
