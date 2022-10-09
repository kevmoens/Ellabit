namespace Ellabit.Challenges
{
    public class Challenge161Purgeandorganize : IChallenge
    {
        public string? Header { get; set; } = "Purge and organize";
        public string? Code { get; set; } = @"
using System;
using System.Linq;

namespace Ellabit {

public class Challenge
{
    public  double[] UniqueSort(double[] arr)
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
            sumResult = tmp.UniqueSort(new double[] {1.0d, 2.0d, 4.0d, 3.0d}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double[] {1.0d, 2.0d, 3.0d, 4.0d}.ToList()),  $""returned: [{string.Join("", "", sumResult)}]  expected:  [1, 2, 3, 4]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.UniqueSort(new double[] {1.0d, 4.0d, 4.0d, 4.0d, 4.0d, 4.0d, 3.0d, 2.0d, 1.0d, 2.0d}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double[] {1.0d, 2.0d, 3.0d, 4.0d}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected:  [1, 2, 3, 4]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double[] sumResult;
        try 
        {
            sumResult = tmp.UniqueSort(new double[] {6.0d, 7.0d, 3.0d, 2.0d, 1.0d}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new double[] {1.0d, 2.0d, 3.0d, 6.0d, 7.0d}.ToList()),   $""returned: [{string.Join("", "", sumResult)}]  expected:  [1, 2, 3, 6, 7]"");
    }
}
}";
        public string? Description { get; set; } = @"Given an array of numbers, write a function that returns an array that...

has all duplicate elements removed.
is sorted from least value to greatest value.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
uniquesort([1, 2, 4, 3]) ➞ [1, 2, 3, 4]

uniquesort([1, 4, 4, 4, 4, 4, 3, 2, 1, 2]) ➞ [1, 2, 3, 4]

uniquesort([6, 7, 3, 2, 1]) ➞ [1, 2, 3, 6, 7]
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
