namespace Ellabit.Challenges
{
    public class Challenge001SumTwoNumbers : IChallenge
    {
        public string? Header { get; set; } = "Sum two numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

    public class Challenge
    {
        public int Sum(int a, int b)
        {
            return 0;
        }
    }
}
";
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
            sumResult = tmp.Sum(3,2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 5,  $""returned: {sumResult}  expected: 5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Sum(-3,-6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == -9,   $""returned: {sumResult}  expected: -9"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Sum(7,3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 10,   $""returned: {sumResult}  expected: 10"");
    }
}
}
";
        public string? Description { get; set; } = @"
            Create a function that takes two numbers as arguments and returns their sum.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                Sum(3, 2) ➞ 5
                <br />
                Sum(-3, -6) ➞ -9
                <br />
                Sum(7, 3) ➞ 10
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] {"Test1","Test2","Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"Math","Add"}, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
