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
        public int ShippingTime(char partStatus)
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
            sumResult = tmp.ShippingTime('T');
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 2,  $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ShippingTime('M');
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1, $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ShippingTime('P');
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 7,   $""returned: {sumResult}  expected: 7"");
    }
}
}";
        public string? Description { get; set; } = @"
Write a function that finds the lead time of a part based on if it is transferred or manufactured in house.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                ShippingTime(""T"") ➞ 2 days
                <br />
                ShippingTime(""M"") ➞ 1 days
                <br />
                ShippingTime(""P"") ➞ 7 days
            </p>
        </code>
Notes
A manufactured part (M) has a lead time of 1 day.
A transferred part (T) has a lead time of 2 days.
A purchased part (P) has a lead time of 7 days.
Purchased will always be true.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Statement", "Switch" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
