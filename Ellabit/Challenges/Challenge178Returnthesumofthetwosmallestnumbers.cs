namespace Ellabit.Challenges
{
    public class Challenge178Returnthesumofthetwosmallestnumbers : IChallenge
    {
        public string? Header { get; set; } = "Return the sum of the two smallest numbers";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit
{
    public class Challenge 
    {
        public int SumSmallest(int[] values) 
        {
			
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
    public class TestChallenge
    {
        public (bool pass, string message) Test1()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.SumSmallest(new int [] {19,  5,  42,  2,  77})  ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 7,  $""returned: {sumResult}  expected: 7"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.SumSmallest(new int [] {10,  343445353,  3453445,  345354535})  ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 3453455,   $""returned: {sumResult}  expected: 3453455"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.SumSmallest(new int [] {2,  9,  6,  -1})  ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult ==  1,   $""returned: {sumResult}  expected: 1"");
        }
        public (bool pass, string message) Test4()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.SumSmallest(new int [] {879,  953,  694,  -847,  342,  221,  -91,  -723,  791,  -587})  ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult == -1570,   $""returned: {sumResult}  expected: -1570"");
        }
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  numbers  and  returns  the  sum  of  the  two  lowest  positive  numbers.

        <h5>Examples</h5>
        <code>
SumSmallest([19,  5,  42,  2,  77])  ➞  7

SumSmallest([10,  343445353,  3453445,  3453545353453])  ➞  3453455

SumSmallest([2,  9,  6,  -1])  ➞  1

SumSmallest([879,  953,  694,  -847,  342,  221,  -91,  -723,  791,  -587])  ➞  -1570
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"Array","Iterate" }, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
