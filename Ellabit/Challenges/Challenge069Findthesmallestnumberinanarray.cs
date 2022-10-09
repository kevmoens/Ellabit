namespace Ellabit.Challenges
{
    public class Challenge069Findthesmallestnumberinanarray : IChallenge
    {
        public string? Header { get; set; } = "Find the smallest number in an array";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class Challenge 
{
    public  double FindSmallestNum(double[] arr) 
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
        double sumResult;
        try 
        {
            sumResult = tmp.FindSmallestNum(new double[] {34, 15, 88, 2});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2,  $""returned: {sumResult}  expected:  2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.FindSmallestNum(new double[] {34, -345, -1, 100});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  -345,   $""returned: {sumResult}  expected:  -345"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.FindSmallestNum(new double[] {-76, 1.345, 1, 0});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  -76,   $""returned: {sumResult}  expected:  -76"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.FindSmallestNum(new double[] {0.4356, 0.8795, 0.5435, -0.9999});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  -0.9999,   $""returned: {sumResult}  expected:  -0.9999"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.FindSmallestNum(new double[] {7, 7, 7});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  7,   $""returned: {sumResult}  expected:  7"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes an array of numbers and returns the smallest number in the set.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
FindSmallestNum([34, 15, 88, 2]) ➞ 2

FindSmallestNum([34, -345, -1, 100]) ➞ -345

FindSmallestNum([-76, 1.345, 1, 0]) ➞ -76

FindSmallestNum([0.4356, 0.8795, 0.5435, -0.9999]) ➞ -0.9999

FindSmallestNum([7, 7, 7]) ➞ 7
            </p>
        </code>

notes
test cases contain decimals.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
