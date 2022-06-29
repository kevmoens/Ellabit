namespace Ellabit.Challenges
{
    public class Challenge040Buggycode : IChallenge
    {
        public string? Header { get; set; } = "Buggy code (part 5)";
        public string? Code { get; set; } = @"

using System;
using System.Collections.Generic;

namespace Ellabit;

public class Challenge
{
  public  List<int> PrintArray(int number)
  {
    List<int> array = new List<int>();
    
    for(int counter = 1; counter <= number;)
    {
      array.Add(counter);
    }
    
    return array;
  }
}

";
        public string? TestCode { get; set; } = @"
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        List<int> sumResult;
        try 
        {
            sumResult = tmp.PrintArray(1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected: 1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        List<int> sumResult;
        try 
        {
            sumResult = tmp.PrintArray(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1,2,3}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected: 1,2,3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        List<int> sumResult;
        try 
        {
            sumResult = tmp.PrintArray(6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1,2,3,4,5,6}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected: 1,2,3,4,5,6"");
    }
}
";
        public string? Description { get; set; } = @"Mubashir created an infinite loop! help him by fixing the code in the code tab to pass this challenge. look at the examples below to get an idea of what the function should do.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
printarray(1) ➞ [1]

printarray(3) ➞ [1, 2, 3]

printarray(6) ➞ [1, 2, 3, 4, 5, 6]
            </p>
        </code>

notes
read every word carefully, character by character!
don't overthink this challenge; it's not supposed to be hard.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
