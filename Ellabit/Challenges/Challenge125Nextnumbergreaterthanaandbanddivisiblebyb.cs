namespace Ellabit.Challenges
{
    public class Challenge125Nextnumbergreaterthanaandbanddivisiblebyb : IChallenge
    {
        public string? Header { get; set; } = "Next number greater than a and b and divisible by b";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  int DivisibleByB(int a, int b) 
    {
		
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.DivisibleByB(17, 8) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  24,  $""returned: {sumResult}  expected:  24"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.DivisibleByB(98, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  99,   $""returned: {sumResult}  expected:  99"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.DivisibleByB(14, 11) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  22,   $""returned: {sumResult}  expected:  22"");
    }
}
}";
        public string? Description { get; set; } = @"You are given two numbers a and b. create a function that returns the next number greater than a and b and divisible by b.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
divisiblebyb(17, 8) ➞ 24

divisiblebyb(98, 3) ➞ 99

divisiblebyb(14, 11) ➞ 22
            </p>
        </code>

notes
a will always be greater than b.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
