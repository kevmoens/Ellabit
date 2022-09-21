namespace Ellabit.Challenges
{
    public class Challenge077Checkifanarraycontainsagivennumber : IChallenge
    {
        public string? Header { get; set; } = "Check if an array contains a given number";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class Challenge
{
	public  bool Check(int[] arr, int el)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.Check(new int[] {1, 2, 3, 4, 5}, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.Check(new int[] {1, 1, 2, 1, 1}, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.Check(new int[] {5, 5, 5, 6}, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.Check(new int[] {}, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
}
}";
        public string? Description { get; set; } = @"Write a method to check if an array contains a particular number.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
check([1, 2, 3, 4, 5], 3) ➞ true

check([1, 1, 2, 1, 1], 3) ➞ false

check([5, 5, 5, 6], 5) ➞ true

check([], 5) ➞ false
            </p>
        </code>

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
