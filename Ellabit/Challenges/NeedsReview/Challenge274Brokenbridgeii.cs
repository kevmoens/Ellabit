namespace Ellabit.Challenges
{
    public class Challenge274Brokenbridgeii : IChallenge
    {
        public string? Header { get; set; } = "Broken bridge ii";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
	public  int BridgesII(string str)
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
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Create a function to return the count of all bridges in a two-dimensional grid.

Bridge B should be counted if:

It connects from one end of the grid to the one opposite to it.
It is unobstructed.
Example
""#########/#       #/#   #   #/#   #   #/#### ####/#   #   #/#   #   #/#       #/#########""
In this case the number 4 is returned because, when unraveled, the string reveals four bridges that meet the requirements listed above as shown:

#########/
#       #/
#   #   #/
#   #   #/
#### ####/
#   #   #/
#   #   #/
#       #/
#########
Notes
Vertical bridges may count.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
