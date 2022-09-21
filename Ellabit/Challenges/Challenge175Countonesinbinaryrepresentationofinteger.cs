namespace Ellabit.Challenges
{
    public class Challenge175Countonesinbinaryrepresentationofinteger : IChallenge
    {
        public string? Header { get; set; } = "Count ones in binary representation of integer";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
        public  int CountOnes(int i)
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
                sumResult = tmp.CountOnes(0);
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 0,  $""returned: {sumResult}  expected: 0"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.CountOnes(100);
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult == 3,   $""returned: {sumResult}  expected: 3"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            int sumResult;
            try 
            {
                sumResult = tmp.CountOnes(999);
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult == 8,   $""returned: {sumResult}  expected: 8"");
        }
    }
}
";
        public string? Description { get; set; } = @"Count content  the  amount  of  ones  in  the  binary  representation  of  an  integer.  for  example,  since  12  is  1100  in  binary,  the  return  value  should  be  2.

        <h5>Examples</h5>
        <code>
countones(0)  ➞  0

countones(100)  ➞  3

countones(999)  ➞  8
            </p>
        </code>

notes
the  input  will  always  be  a  valid  integer  (number).""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
