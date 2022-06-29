namespace Ellabit.Challenges
{
    public class Challenge080Returnthefirstandlastelementsinanarray : IChallenge
    {
        public string? Header { get; set; } = "Return the first and last elements in an array";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  object[] FirstLast(object[] values)
	{
		
	}
}

";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        object[] sumResult;
        try 
        {
            sumResult = tmp.FirstLast(new object[] {5, 10, 15, 20, 25}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new object[] {5, 25}),  $""returned: [{string.Join("", "", sumResult)}]  expected:  [5, 25]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        object[] sumResult;
        try 
        {
            sumResult = tmp.FirstLast(new object[] {""ellabit"", 13, null, false, true});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new object[] {""ellabit"", true}),  $""returned: [{string.Join("", "", sumResult)}]  expected:  [ellabit, true]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        object[] sumResult;
        try 
        {
            sumResult = tmp.FirstLast(new object[] {null, 4, ""6"", ""hello"", null});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new object[] {null, null}),  $""returned: [{string.Join("", "", sumResult)}]  expected:  [undefined, null]"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an array of values and returns the first and last values in a new array.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
FirstLast([5, 10, 15, 20, 25]) ➞ [5, 25]

FirstLast(['ellabit', 13, null, false, true]) ➞ ['ellabit', true]

FirstLast([null, 4, '6', 'hello', null]) ➞ [null, null]
            </p>
        </code>
        Notes
Test input will always contain a minimum of two elements within the array.
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
