namespace Ellabit.Challenges
{
    public class Challenge002ConvertMinutesToSeconds : IChallenge
    {

        public string? Header { get; set; } = "Convert minutes to seconds";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public int convert(int minute)
    {
        return 0;
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
            sumResult = tmp.convert(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 300,  $""returned: {sumResult}  expected: 300"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 180, $""returned: {sumResult}  expected: 180"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 120,   $""returned: {sumResult}  expected: 120"");
    }
}
";
        public string? Description { get; set; } = @"
Write a function that takes an integer minutes and converts it to seconds.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                convert(5) ➞ 300
                <br />
                convert(3) ➞ 180
                <br />
                convert(2) ➞ 120
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
