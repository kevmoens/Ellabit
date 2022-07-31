namespace Ellabit.Challenges
{
    public class Challenge068FindtheindexPart1 : IChallenge
    {
        public string? Header { get; set; } = "  \"Find the index (part 1)\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  int Search(int[] arr, int item)
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
            sumResult = tmp.Search(new int[] {1, 5, 3}, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1,  $""returned: {sumResult}  expected:  1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Search(new int[] {9, 8, 3}, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2,   $""returned: {sumResult}  expected:  2"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Search(new int[] {1, 2, 3}, 4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  -1,   $""returned: {sumResult}  expected:  -1"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that finds the index of a given item.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
search([1, 5, 3], 5) ➞ 1

search([9, 8, 3], 3) ➞ 2

search([1, 2, 3], 4) ➞ -1
            </p>
        </code>

notes
if the item is not present, return -1.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
