namespace Ellabit.Challenges
{
    public class Challenge204Thekaracasencryptionalgorithm : IChallenge
    {
        public string? Header { get; set; } = "The karaca's encryption algorithm";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;

public class Challenge 
{
			public  string Encrypt(string word)
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
        public string? Description { get; set; } = @"Make a function that encrypts a given input with these steps:

Input: ""apple""

Step 1: Reverse the input: ""elppa""

Step 2: Replace all vowels using the following chart:

a => 0
e => 1
i => 2
o => 2
u => 3

// ""1lpp0""
Step 3: Add ""aca"" to the end of the word: ""1lpp0aca""

Output: ""1lpp0aca""

Examples
Encrypt(""banana"") ➞ ""0n0n0baca""

Encrypt(""karaca"") ➞ ""0c0r0kaca""

Encrypt(""burak"") ➞ ""k0r3baca""

Encrypt(""alpaca"") ➞ ""0c0pl0aca""
Notes
All inputs are strings, no uppercases and all output must be strings.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
