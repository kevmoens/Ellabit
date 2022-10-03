namespace Ellabit.Challenges
{
    public class Challenge004PowerCalculator : IChallenge
    {
        public string? Header { get; set; } = "Power Calculator";
        public string? Code { get; set; } = @"
using System;


namespace Ellabit
{

    public class Challenge
    {
        public int CircuitPower(int voltage, int current) 
        {
			
        }
    }
}";
        public string? TestCode { get; set; } = @"
using System;


namespace Ellabit
{

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CircuitPower(230,10);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 2300,  $""returned: {sumResult}  expected: 2300"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CircuitPower(110,3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 330,   $""returned: {sumResult}  expected: 330"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CircuitPower(480,20);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 9600,   $""returned: {sumResult}  expected: 9600"");
    }
}
}";
        public string? Description { get; set; } = @"
            Create a function that takes voltage and current and returns the calculated power.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                CircuitPower(230, 10) ➞ 2300
                <br />
                CircuitPower(110, 3) ➞ 330
                <br />
                CircuitPower(480, 20) ➞ 9600
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Exponent" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
    }
}
