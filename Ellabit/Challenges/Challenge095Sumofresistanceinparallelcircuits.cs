namespace Ellabit.Challenges
{
    public class Challenge095Sumofresistanceinparallelcircuits : IChallenge
    {
        public string? Header { get; set; } = "Sum of resistance in parallel circuits";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;
public class Challenge {
	public  double ParallelResistance(double[] arr) 
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
        double sumResult = 0d;
        try 
        {
            sumResult = tmp.ParallelResistance(new double[] {6d, 3d});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 2d,  $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult = 0d;
        try 
        {
            sumResult = tmp.ParallelResistance(new double[] {10d, 20d, 10d});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 4d,   $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult = 0d;
        try 
        {
            sumResult = tmp.ParallelResistance(new double[] {500d, 500d, 500d});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 166.6d,   $""returned: {sumResult}  expected: 166.6"");
    }
}
";
        public string? Description { get; set; } = @"If two or more resistors are connected in parallel, the overall resistance of the circuit reduces. it is possible to calculate the total resistance of a parallel circuit by using this formula:

1/r total = 1/r1 + 1/r2 + 1/r3 + ... + 1/rn. ..

Create a function that takes an array of parallel resistance values, and calculates the total resistance of the circuit.

Worked Example
ParallelResistance({6, 3, 6}) ➞ 1.5

// 1/RTotal = 1/6 + 1/3 + 1/6
// 1/RTotal = 2/3
// RTotal = 3/2 = 1.5
Examples
ParallelResistance([6, 3]) ➞ 2

ParallelResistance([10, 20, 10]) ➞ 4

ParallelResistance([500, 500, 500]) ➞ 166.6

// Round to the nearest decimal place

Notes
Note that you should rearrange to return the Resistance Total, not 1 / Resistance Total.
Round to the nearest decimal place.
All inputs will be valid.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
