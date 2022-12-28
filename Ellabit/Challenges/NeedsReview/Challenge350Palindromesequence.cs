namespace Ellabit.Challenges
{
    public class Challenge350Palindromesequence : IChallenge
    {
        public string? Header { get; set; } = "Palindrome sequence";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
  	public  int[] PalSeq(int n) 
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
        int[] sumResult;
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
        int[] sumResult;
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
        int[] sumResult;
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
        public string? Description { get; set; } = @"A palindrome is a number that is the same when reversed, 2770772 for example. A palindrome can often be formed by adding a number to it's reverse: 641 + 146 = 787 (a palindrome). Using 78 as the seed, it takes 4 steps to produce a palindrome:

78 + 87 = 165
165 + 561 = 726
726 + 627 = 1353
1353 + 3531 = 4884 (a palindrome)
About 97% of integers less than 10,000 produce palindromes in less than 25 steps. A few, like 196 and 879, may never form palindromes.

Make a function that takes a palindrome as it's an argument and returns the smallest seed integer that will produce that palindrome, along with the number of steps required:

palSeq(palindrome) = [seed, steps]
palSeq(4884) ➞ [69, 4]

palSeq(1) ➞ [1, 0]

palSeq(11) ➞ [10, 1]
// 10 + 01 = 11

palSeq(3113) ➞ [199, 3]

palSeq(8836886388) ➞ [177, 15]
Notes
The sequence always terminates when the first palindrome is produced. If the seed is a palindrome, the sequence has 0 steps.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
