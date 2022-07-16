namespace Ellabit.Challenges
{
    public class Challenge059Sliceofpie : IChallenge
    {
        public string? Header { get; set; } = "Slice of pie";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  bool EqualSlices(int total, int people, int each) 
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
        bool sumResult;
        try 
        {
            sumResult = tmp.EqualSlices(11, 5, 2);
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
            sumResult = tmp.EqualSlices(11, 5, 3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,  $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.EqualSlices(8, 3, 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.EqualSlices(8, 3, 3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,  $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.EqualSlices(24, 12, 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that determines whether or not it's possible to split a pie fairly given these three parameters:

Total number of slices.
Number of recipients.
How many slices each person gets.
The function will be in this form:

EqualSlices(total slices, no. recipients, slices each)

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
EqualSlices(11, 5, 2) ➞ true
// 5 people x 2 slices each = 10 slices < 11 slices 

EqualSlices(11, 5, 3) ➞ false
// 5 people x 3 slices each = 15 slices > 11 slices

EqualSlices(8, 3, 2) ➞ true

EqualSlices(8, 3, 3) ➞ false

EqualSlices(24, 12, 2) ➞ true
            </p>
        </code>

Notes
Return (trivially) true if there are zero people.
It's fine not to use the entire pie.
All test parameters are integers.
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
