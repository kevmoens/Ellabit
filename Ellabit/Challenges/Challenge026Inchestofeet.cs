namespace Ellabit.Challenges
{
    public class Challenge026Inchestofeet : IChallenge
    {
        public string? Header { get; set; } = "Inches to feet";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
  public  int inchesToFeet(int inches)
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
            sumResult = tmp.inchesToFeet(324);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  27,  $""returned: {sumResult}  expected:  27"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.inchesToFeet(12);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1,   $""returned: {sumResult}  expected:  1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.inchesToFeet(36);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  3,   $""returned: {sumResult}  expected:  3"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that accepts a measurement value in inches and returns the equivalent of the measurement value in feet.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
inchestofeet(324) ➞ 27

inchestofeet(12) ➞ 1

inchestofeet(36) ➞ 3
            </p>
        </code>

notes
if inches are under 12, return 0.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Division" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
