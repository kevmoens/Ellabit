namespace Ellabit.Challenges
{
    public class Challenge180Filteroutstringsfromanarray : IChallenge
    {
        public string? Header { get; set; } = "Filter out strings from an array";
        public string? Code { get; set; } = @"
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ellabit
{
    public class Challenge
    {
        public  int[] FilterArray(object[] arr)
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
            int[] sumResult;
            try 
            {
                sumResult = tmp.FilterArray(new object[] {1,  2,  ""a"", ""b""}) ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new int[] {1, 2}) ,  $""returned: {string.Join("", "", sumResult)}  expected: [1, 2]"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            int[] sumResult;
            try 
            {
                sumResult = tmp.FilterArray(new object[] {1, ""a"", ""b"", 0, 15});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new int[] {1, 0, 15}) ,  $""returned: {string.Join("", "", sumResult)}  expected: [1, 0, 15]"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            int[] sumResult;
            try 
            {
                sumResult = tmp.FilterArray(new object[] {1, 2, ""aasf"", ""1"", ""123"", 123});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult.SequenceEqual(new int[] {1, 2, 123}) ,  $""returned: {string.Join("", "", sumResult)}  expected: [1, 2, 123]"");
        }
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  non-negative  integers  and  strings  and  return  a  new  array  without  the  strings.

        <h5>Examples</h5>
        <code>
FilterArray([1, 2, ""a"", ""b""]) ➞ [1, 2]

FilterArray([1, ""a"", ""b"", 0, 15]) ➞ [1, 0, 15]

FilterArray([1, 2, ""aasf"", ""1"", ""123"", 123]) ➞ [1, 2, 123]
            </p>
        </code>

Notes
Zero is a non-negative integer.
The given array only has integers and strings.
Numbers in the array should not repeat.
The original order must be maintained.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
