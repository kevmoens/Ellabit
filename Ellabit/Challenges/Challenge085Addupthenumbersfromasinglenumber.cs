namespace Ellabit.Challenges
{
    public class Challenge085Addupthenumbersfromasinglenumber : IChallenge
    {
        public string? Header { get; set; } = "Add up the numbers from a single number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int AddUp(int num) 
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
            sumResult = tmp.AddUp(4);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 10,  $""returned: {sumResult}  expected: 10"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.AddUp(13);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 91,   $""returned: {sumResult}  expected: 91"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.AddUp(600);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 180300,   $""returned: {sumResult}  expected: 180300"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a number as an argument. add up all the numbers from 1 to the number you passed to the function. for example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 10.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
AddUp(4) ➞ 10

addup(13) ➞ 91

addup(600) ➞ 180300
            </p>
        </code>

notes
expect any positive number between 1 and 1000.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
