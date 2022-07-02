namespace Ellabit.Challenges
{
    public class Challenge084Sumofcubes : IChallenge
    {
        public string? Header { get; set; } = "Sum of cubes";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
public class Challenge
{
	public  int CubesSum(int[] nums_arr)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CubesSum(new int[] {1, 5, 9}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  855,  $""returned: {sumResult}  expected:  855"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CubesSum(new int[] {3, 4, 5});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 216,   $""returned: {sumResult}  expected: 216"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CubesSum(new int[] {2});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 8,   $""returned: {sumResult}  expected: 8"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes in an array of numbers and returns the sum of its cubes.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
cubessum([1, 5, 9]) ➞ 855
// since 1^3 + 5^3 + 1 + 125 + 855

CubesSum([3, 4, 5]) ➞ 216

cubessum([2]) ➞ 8
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
