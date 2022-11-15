namespace Ellabit.Challenges
{
    public class Challenge071Sumofresistanceinseriescircuits : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Sum of resistance in series circuits";
        public string? Code { get; set; } = @"
using System;
using System.Linq;

namespace Ellabit {

using System.Linq;
public class Challenge {
	public  string SeriesResistance(double[] arr) {
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SeriesResistance(new double[] {1, 5, 6, 3});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""15.0 ohms"",  $""returned: {sumResult}  expected: 15.0 ohms"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SeriesResistance(new double[] { 16, 3.5, 6});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""25.5 ohms"",   $""returned: {sumResult}  expected: 25.5 ohms"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SeriesResistance(new double[] { 0.5, 0.5});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""1.0 ohms"",   $""returned: {sumResult}  expected: 1.0 ohms"");
    }
}
}";
        public string? Description { get; set; } = @"When resistors are connected together in series, the same current passes through each resistor in the chain and the total resistance, rt, of the circuit must be equal to the sum of all the individual resistors added together. that R1 + r2 + r3 ...

Create a function that takes an array of values resistance that are connected in series, and calculates the total resistance of the circuit in ohms. The ohm is the standard unit of electrical resistance in the International System of Units ( SI ).

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
SeriesResistance({1, 5, 6, 3}) ➞ ""15.0 ohms""

SeriesResistance({ 16, 3.5, 6}) ➞ ""25.5 ohms""

SeriesResistance({ 0.5, 0.5}) ➞ ""1.0 ohms""
            </p>
        </code>

Notes
All inputs will be valid.
Notice the singular ohm for values <= 1.
This challenge was inspired by Joshua Señoron's Python Sum of Resistance in Parallel Circuits challenge. You can find it <a href=""https://ellabit.com/challenge/dCnX639Sheqdxqjm2"">here</a>.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Array", "Math" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
