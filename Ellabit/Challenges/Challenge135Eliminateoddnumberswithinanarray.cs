namespace Ellabit.Challenges
{
    public class Challenge135Eliminateoddnumberswithinanarray : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Eliminate odd numbers within an array";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
    {
        public  int[] NoOdds(int[] arr)
        {
            
        }
    }


}";
        public string? TestCode { get; set; } = @"
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.NoOdds(new int[] {1,  2,  3,  4,  5,  6,  7,  8})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual( new int[] {2,  4,  6,  8}.ToList()),  $""returned: [{string.Join("", "", sumResult)}]  expected: [2,  4,  6,  8]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.NoOdds(new int[] {43,  65,  23,  89,  53,  9,  6});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {6}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected: [6]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.NoOdds(new int[] {718,  991,  449,  644,  380,  440})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {718,  644,  380,  440}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected: [718,  644,  380,  440]"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  numbers  and  returns  only  the  even  values.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
noodds([1,  2,  3,  4,  5,  6,  7,  8])  ➞  [2,  4,  6,  8]

noodds([43,  65,  23,  89,  53,  9,  6])  ➞  [6]

noodds([718,  991,  449,  644,  380,  440])  ➞  [718,  644,  380,  440]
            </p>
        </code>

notes
return  all  even  numbers  in  the  order  they  were  given.
all  test  cases  contain  valid  numbers  ranging  from  1  to  999";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Int", "int.Parse()" },{ "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
