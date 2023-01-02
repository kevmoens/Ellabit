namespace Ellabit.Challenges
{
    public class Challenge197Testing : IChallenge
    {
        public string? Header { get; set; } = "Testing K^K = n?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System.Numerics;
public class Challenge
{
	public  bool KToK(string n, int k) 
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
            sumResult = tmp.ktok("" 4"", 2) ;
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
            sumResult = tmp.ktok(""387420489"", 9);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""="" 9^9 387420489 ,   $""returned: {sumResult}  expected: =9^9 387420489?"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.ktok(""3124"", 5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"Write a function that returns true if k^k == n for input (n, k) and return false otherwise.

Examples
KToK(""4"", 2) ➞ true

KToK(""387420489"", 9) ➞ true
# 9^9 == 387420489

KToK(""3124"", 5) ➞ false

KToK(""17"", 3) ➞ false
Notes
The ^ operator refers to exponentiation operation, not the bitwise XOR operation.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
