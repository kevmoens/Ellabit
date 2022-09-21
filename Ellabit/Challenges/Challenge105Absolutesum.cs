namespace Ellabit.Challenges
{
    public class Challenge105Absolutesum : IChallenge
    {
        public string? Header { get; set; } = "Absolute sum";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  int GetAbsSum(int[] arr) 
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
            sumResult = tmp.GetAbsSum(new int[] {2, -1, 4, 8, 10}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  25,  $""returned: {sumResult}  expected:  25"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.GetAbsSum(new int[] {-3, -4, -10, -2, -3}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  22,   $""returned: {sumResult}  expected:  22"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.GetAbsSum(new int[] {2, 4, 6, 8, 10}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  30,   $""returned: {sumResult}  expected:  30"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.GetAbsSum(new int[] {-1}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  1,   $""returned: {sumResult}  expected:  1"");
    }
}
}";
        public string? Description { get; set; } = @"Take an array of integers (positive or negative or both) and return the sum of the absolute value of each element.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
getabssum([2, -1, 4, 8, 10]) ➞ 25

getabssum([-3, -4, -10, -2, -3]) ➞ 22

getabssum([2, 4, 6, 8, 10]) ➞ 30

getabssum([-1]) ➞ 1
            </p>
        </code>

notes
the term ""absolute value"" means to remove any negative sign in front of a number, and to think of all numbers as positive (or zero).
All the elements in the given array are integers.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
