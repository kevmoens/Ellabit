namespace Ellabit.Challenges
{
    public class Challenge076Reverseanarray : IChallenge
    {
        public string? Header { get; set; } = "Reverse an array";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

class Program
{
	public  int[] Reverse(int[] arr)
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.Reverse(new int[] {1, 2, 3, 4}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {4, 3, 2, 1}),  $""returned: {string.Join("", "", sumResult)}  expected:  {4, 3, 2, 1}"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.Reverse(new int[] {9, 9, 2, 3, 4}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {4, 3, 2, 9, 9}),   $""returned: {string.Join("", "", sumResult)}  expected:  {4, 3, 2, 9, 9}"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.Reverse(new int[] {}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {}),   $""returned: {string.Join("", "", sumResult)}  expected: {}"");
    }
}
}";
        public string? Description { get; set; } = @"Write a function to reverse an array.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
reverse(new int[] {1, 2, 3, 4}) ➞ {4, 3, 2, 1}

reverse(new int[] {9, 9, 2, 3, 4}) ➞ {4, 3, 2, 9, 9}

reverse(new int[] {}) ➞ {}
            </p>
        </code>

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyToolboxXML { get => string.Empty; }
        public string BlocklyXML { get => string.Empty; }
    }
}
