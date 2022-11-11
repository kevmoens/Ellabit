namespace Ellabit.Challenges
{
    public class Challenge196FindPartLeadTime : IChallenge, IChallengeBlockly, IChallengeTestCode
    {

        public string? Header { get; set; } = "Find the parts lead time";
        public string? Code { get; set; } = @"
using System;


namespace Ellabit {

    public class Challenge
    {
        public int ShippingTime(bool transferred, bool manufactured, bool purchased)
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
            sumResult = tmp.ShippingTime(true, false, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 9,  $""returned: {sumResult}  expected: 9"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ShippingTime(false, true, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 8, $""returned: {sumResult}  expected: 8"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ShippingTime(true, true, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 10,   $""returned: {sumResult}  expected: 10"");
    }
}
}";
        public string? Description { get; set; } = @"
Write a function that finds the lead time of a part based on if it is transferred or manufactured in house.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                ShippingTime(""Transferred"", ""Purchased"") ➞ 9 days
                <br />
                ShippingTime(""Manufactured"", ""Purchased"") ➞ 8 days
                <br />
                ShippingTime(""Transferred"", ""Manufactured"", ""Purchased"") ➞ 10 days
            </p>
        </code>
Notes
A manufactured part has a lead time of 1 day.
A transferred part has a lead time of 2 days.
A purchased part has a lead time of 7 days.
Purchased will always be true.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Statement", "Switch" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
