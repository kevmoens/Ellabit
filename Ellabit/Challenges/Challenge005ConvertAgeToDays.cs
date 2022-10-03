namespace Ellabit.Challenges
{
    public class Challenge005ConvertAgeToDays : IChallenge
    {
        public string? Header { get; set; } = "Convert Age to Days";
        public string? Code { get; set; } = @"
using System;


namespace Ellabit
{

    public class Challenge
    {
        public int CalcAge(int age)
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
            sumResult = tmp.CalcAge(65);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 23725,  $""returned: {sumResult}  expected: 23725"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CalcAge(0);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 0,   $""returned: {sumResult}  expected: 0"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CalcAge(20);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 7300,   $""returned: {sumResult}  expected: 7300"");
    }
}
}";
        public string? Description { get; set; } = @"
            Create a function that takes the age in years and returns the age in days.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                CalcAge(65) ➞ 23725
                <br />
                CalcAge(0) ➞ 0
                <br />
                CalcAge(20) ➞ 7300
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Use 365 days as the length of a year for this challenge.</li>
            <li>Ignore leap years and days between last birthday and now.</li>
            <li>Expect only positive integer inputs.</li>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
    }
}
