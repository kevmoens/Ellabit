namespace Ellabit.Challenges
{
    public class Challenge173Thecollatzconjecture : IChallenge
    {
        public string? Header { get; set; } = "The collatz conjecture";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

    public class Challenge
    {
	    public  int collatz(int num)
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
                sumResult = tmp.collatz(2);
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 1,  $""returned: {sumResult}  expected: 1"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.collatz(3);
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 7,   $""returned: {sumResult}  expected: 7"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.collatz(10);
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult == 6,   $""returned: {sumResult}  expected: 6"");
        }
    }
}
";
        public string? Description { get; set; } = @"Consider the following operation on an arbitrary positive integer:

If n is even -> n / 2
If n is odd -> n * 3 + 1
Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.

See the following example, using 10 as the input, with 6 steps:

10 is even - 10 / 2 = 5
5 is odd - 5 * 3 + 1 = 16
16 is even - 16 / 2 = 8
8 is even - 8 / 2 = 4
4 is even - 4 / 2 = 2
2 is even - 2 / 2 = 1 -> Reached 1, so return 6

        <h5>Examples</h5>
        <code>
collatz(2) ➞ 1

collatz(3) ➞ 7

collatz(10) ➞ 6
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
