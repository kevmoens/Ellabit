namespace Ellabit.Challenges
{
    public class Challenge003ReturnNextNumber : IChallenge
    {

        public string? Header { get; set; } = "Return the Next Number from the Integer Passed";
        public string? Code { get; set; } = @"
using System;


namespace Ellabit
{

    public class Challenge
    {
        public int Addition(int num)
        {
            return 0;
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
            sumResult = tmp.Addition(0);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,  $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Addition(9);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 10,  $""returned: {sumResult}  expected: 10"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Addition(-3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == -2,  $""returned: {sumResult}  expected: -2"");
    }
}
}";
        public string? Description { get; set; } = @"
            Create a function that takes a number as an argument, increments the number by +1 and returns the result.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                Addition(0) ➞ 1
                <br />
                Addition(9) ➞ 10
                <br />
                Addition(-3) ➞ -2
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Add" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
