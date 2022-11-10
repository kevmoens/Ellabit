namespace Ellabit.Challenges
{
    public class Challenge164Cumulativearraysum : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Cumulative array sum";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  double[] CumulativeSum(double[] arr) 
    {
        
    }
}


}";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.CumulativeSum(new double [] {1,  2,  3});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double [] {1,  3,  6}),  $""returned: [{string.Join("", "", sumResult)}]  expected: [1,  3,  6]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.CumulativeSum(new double [] {1,  -2,  3});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double [] {1,  -1,  2}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [1,  -1,  2]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.CumulativeSum(new double [] {3,  3,  -2,  408,  3,  3});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double [] {3,  6,  4,  412,  415,  418}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [3,  6,  4,  412,  415,  418]"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  numbers  and  returns  an  array  where  each  number  is  the  sum  of  itself  +  all  previous  numbers  in  the  array.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
cumulativesum([1,  2,  3])  ➞  [1,  3,  6]

cumulativesum([1,  -2,  3])  ➞  [1,  -1,  2]

cumulativesum([3,  3,  -2,  408,  3,  3])  ➞  [3,  6,  4,  412,  415,  418]
            </p>
        </code>

notes
return  an  empty  array  if  the  input  is  an  empty  array.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
