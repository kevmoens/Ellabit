namespace Ellabit.Challenges
{
    public class Challenge172Findthelargestnumbersinagroupofarrays : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Find the largest numbers in a group of arrays";
        public string? Code { get; set; } = @"

using System;
using System.Linq;
using System.Collections.Generic;
namespace Ellabit
{

    public class Challenge 
    {
        public  double[] FindLargest(double[][] values) 
        {
			
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;

namespace Ellabit
{

    public class TestChallenge
    {
        public (bool pass, string message) Test1()
        {
            var tmp = new Challenge();
            double[] sumResult;
            try 
            {
                sumResult = tmp.FindLargest(new double[][] { new double[] {4, 2, 7, 1},  new double[] {20, 70, 40, 90}, new double[] {1, 2, 0}}) ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new double[] {7, 90, 2}),  $""returned: {string.Join("", "", sumResult)}  expected:  [7, 90, 2]"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            double[] sumResult;
            try 
            {
                sumResult = tmp.FindLargest(new double [][] { new double[] {-34, -54, -74}, new double[] {-32, -2, -65}, new double[] {-54, 7, -43}}) ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new double[] {-34, -2, 7}),   $""returned: {string.Join("", "", sumResult)}  expected:  [-34, -2, 7]"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            double[] sumResult;
            try 
            {
                sumResult = tmp.FindLargest(new double[][] { new double[] {0.4321, 0.7634, 0.652}, new double[] {1.324, 9.32, 2.5423, 6.4314}, new double[] {9, 3, 6, 3}});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult.SequenceEqual(new double[] {0.7634, 9.32, 9}),   $""returned: {string.Join("", "", sumResult)}  expected: [0.7634, 9.32, 9]"");
        }
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an array of arrays with numbers. return a new (single) array with the largest numbers of each.

        <h5>Examples</h5>
        <code>
findlargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]) ➞ [7, 90, 2]

findlargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]) ➞ [-34, -2, 7]

findlargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]) ➞ [0.7634, 9.32, 9]
            </p>
        </code>

Note
watch ouf for negative numbers";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Int", "Array" }, { "Array", "Max Value" }, { "Level", "2" } };

        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
