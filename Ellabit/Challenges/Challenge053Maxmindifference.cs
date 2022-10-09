namespace Ellabit.Challenges
{
    public class Challenge053Maxmindifference : IChallenge
    {
        public string? Header { get; set; } = "Max min difference";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

using System.Linq;
public class Challenge
{
	public  int Diff(int[] arr)
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
            sumResult = tmp.Diff(new int[] {10, 15, 20, 2, 10, 6}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  18,  $""returned: {sumResult}  expected:  18"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Diff(new int[] {-3, 4, -9, -1, -2, 15}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 24,   $""returned: {sumResult}  expected: 24"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Diff(new int[] {4, 17, 12, 2, 10, 2}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 15,   $""returned: {sumResult}  expected: 15"");
    }
}
}";
        public string? Description { get; set; } = @"Given an array of integers, return the difference between the largest and smallest integers on the array .

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
diff([10, 15, 20, 2, 10, 6]) ➞ 18
// 20 - 18

Diff([-3, 4, -9, -1, -2, 15]) ➞ 24
// 15 - 24

Diff([4, 17, 12, 2, 10, 2]) ➞ 15
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
