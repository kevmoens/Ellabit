namespace Ellabit.Challenges
{
    public class Challenge299Encodemorse : IChallenge
    {
        public string? Header { get; set; } = "Encode morse";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string EncodeMorse(string str) 
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
            sumResult = tmp.encodemorse("" edabbit challenge"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  "". -.. .- -... .. - -.-. .... .-.. . -. --. ."" ,  $""returned: {sumResult}  expected: . -.. .- -... .. - -.-. .... .-.. . -. --. ."");
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
        public string? Description { get; set; } = @"Create a function that takes a string as an argument and returns the Morse code equivalent.

Examples
EncodeMorse(""EDABBIT CHALLENGE"") ➞ "". -.. .- -... -... .. -   -.-. .... .- .-.. .-.. . -. --. .""

EncodeMorse(""HELP ME !"") ➞ "".... . .-.. .--.   -- .   -.-.--""
Notes
Ouput should be International Morse Code, and use the standard conventions for symbols not defined inside the ITU recommendation (see Resources).
Input value can be lower or upper case.
Input string can have digits.
Input string can have some special characters (e.g. comma, colon, apostrophe, period, question mark, exclamation mark).
One space "" "" is expected after each character.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
