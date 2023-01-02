namespace Ellabit.Challenges
{
    public class Challenge242Imaginarycodinginterview : IChallenge
    {
        public string? Header { get; set; } = "Imaginary coding interview";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
	public  string Interview(int[] arr, int tot) {
		
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
        public string? Description { get; set; } = @"Create a function to check if a candidate is qualified in an imaginary coding interview of an imaginary tech startup.

The criteria for a candidate to be qualified in the coding interview is:

The candidate should have complete all the questions.
The maximum time given to complete the interview is 120 minutes.
The maximum time given for very easy questions is 5 minutes each.
The maximum time given for easy questions is 10 minutes each.
The maximum time given for medium questions is 15 minutes each.
The maximum time given for hard questions is 20 minutes each.
If all the above conditions are satisfied, return ""qualified"", else return ""disqualified"".

You will be given an array of time taken by a candidate to solve a particular question and the total time taken by the candidate to complete the interview.

Given an array, in a true condition will always be in the format [very easy, very easy, easy, easy, medium, medium, hard, hard].

The maximum time to complete the interview includes a buffer time of 20 minutes.

Examples
Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120) ➞ ""qualified""

Interview(new int [] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64) ➞  ""qualified""

Interview(new int [] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120) ➞ ""disqualified""
// Exceeded the time limit for a medium question.

Interview(new int [] { 5, 5, 10, 10, 15, 15, 20 }, 120) ➞ ""disqualified""
// Did not complete all the questions.

Interview(new int [] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130) ➞ ""disqualified""
// Solved all the questions in their respected time limits but exceeded the total time limit of the interview.
Notes
Try to solve the problem using only array methods.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
