namespace Ellabit.Challenges
{
    public class Challenge070Findthelargestnumberinanarray : IChallenge
    {
        public string? Header { get; set; } = "Find the largest number in an array";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class Challenge
    {
        public  int FindLargestNum(int[] arr)
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
            sumResult = tmp.FindLargestNum(new int[] {4, 5, 1, 3}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  5,  $""returned: {sumResult}  expected:  5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindLargestNum(new int[] {300, 200, 600, 150}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  600,   $""returned: {sumResult}  expected:  600"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindLargestNum(new int[] {1000, 1001, 857, 1}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  1001,   $""returned: {sumResult}  expected:  1001"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes an array of numbers. return the largest number in the array.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
findlargestnum([4, 5, 1, 3]) ➞ 5

findlargestnum([300, 200, 600, 150]) ➞ 600

findlargestnum([1000, 1001, 857, 1]) ➞ 1001
            </p>
        </code>

notes
expect either a positive number or zero (there are no negative numbers).
if you get stuck on a challenge, find help in the resources ";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
