namespace Ellabit.Challenges
{
    public class Challenge258Clearbrackets : IChallenge
    {
        public string? Header { get; set; } = "Clear brackets";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool Brackets(string str)
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
            sumResult = tmp.brackets("" (a*(b-c)..... )"") ;
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
            sumResult = tmp.brackets("")(a-b-45 7*(a-34))"");
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
            sumResult = tmp.brackets(""sin(90...)+.............cos1)"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  notes the string may not contain ,   $""returned: {sumResult}  expected: notes the string may not contain"");
    }
}
";
        public string? Description { get; set; } = @"Create a function Brackets() that takes a string and checks that the brackets in the math expression are correct. The function should return true or false.

Examples
Brackets(""(a*(b-c)..... )"") ➞ true

Brackets("")(a-b-45/7*(a-34))"") ➞ false

Brackets(""sin(90...)+.............cos1)"") ➞ false
Notes
The string may not contain brackets, then return true.
String may contain spaces.
The string may be empty.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
