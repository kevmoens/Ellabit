namespace Ellabit.Challenges
{
    public class Challenge174Findthecharacterscounterpartcharcode : IChallenge
    {
        public string? Header { get; set; } = "Find the characters counterpart char code";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge 
    {
        public  int CounterpartCharCode(char symbol) 
        {
        }
    }
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
    public class TestChallenge
    {
        public (bool pass, string message) Test1()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.CounterpartCharCode('A');
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 65,  $""returned: {sumResult}  expected: 65"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.CounterpartCharCode('a');
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 97,   $""returned: {sumResult}  expected: 97"");
        }
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a single character as an argument and returns the char code of its lowercased / uppercased counterpart.

<h5>Examples</h5>
Given that:
  - ""A"" char code is: 65
  - ""a"" char code is: 97

        <code>
CounterpartCharCode(""A"") ➞ 65

CounterpartCharCode(""a"") ➞ 97
            </p>
        </code>

Notes
The argument will always be a single character.
Not all inputs will have a counterpart(e.g.numbers), in which case return the input's char code.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
