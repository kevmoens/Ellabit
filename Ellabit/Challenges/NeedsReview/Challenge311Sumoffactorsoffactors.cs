namespace Ellabit.Challenges
{
    public class Challenge311Sumoffactorsoffactors : IChallenge
    {
        public string? Header { get; set; } = "Sum of factors of factors";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int SumFF(int a) {
		
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
        int sumResult;
        try 
        {
            sumResult = tmp.sumff(69)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   3,  23  ➞  0
//  both  3  and  23  are  prime  numbers  and  have  no  factors
//  other  than  1  and  themselves  so  the  result  is  0.

,  $""returned: {sumResult}  expected: 3,  23  ➞  0
//  both  3  and  23  are  prime  numbers  and  have  no  factors
//  other  than  1  and  themselves  so  the  result  is  0."");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.sumff(12)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   2,  3,  4,  6  ➞  (0)  +  (0)  +  (2)  +  (2+3)  ➞  7

,   $""returned: {sumResult}  expected: 2,  3,  4,  6  ➞  (0)  +  (0)  +  (2)  +  (2+3)  ➞  7"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
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
        public string? Description { get; set; } = @"Create a function that takes a number and returns the sum of factors of factors of the given number.

Examples
SumFF(69) ➞ 3, 23 ➞ 0
// Both 3 and 23 are prime numbers and have no factors
// other than 1 and themselves so the result is 0.

SumFF(12) ➞ 2, 3, 4, 6 ➞ (0) + (0) + (2) + (2+3) ➞ 7

SumFF(420) ➞ 2,4, 6, 10, 12 ... ➞ (2) + (2+3) + (2+5) + (2+3+4+6) ... ➞ 1175

SumFF(619) ➞ ___ ➞ 0
// 619 doesn't have any factors (other than 1 and 619).
Notes
The number will always be greater than 0.
Factors that are equal to the number or 1, don't count (see example #1).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
