namespace Ellabit.Challenges
{
    public class Challenge176Fractiongreaterthanone : IChallenge
    {
        public string? Header { get; set; } = "Fraction greater than one";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
	    public  bool GreaterThanOne(string str)
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
            bool sumResult;
            try 
            {
                sumResult = tmp.GreaterThanOne(""1/2"") ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult ==  false ,  $""returned: {sumResult}  expected: false"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.GreaterThanOne(""7/4"");
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult ==  true ,   $""returned: {sumResult}  expected: true"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.GreaterThanOne(""10/10"");
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult == false,   $""returned: {sumResult}  expected: false"");
        }
    }
}
";
        public string? Description { get; set; } = @"Given a fraction as a string, return whether or not it is greater than 1 when evaluated.

        <h5>Examples</h5>
        <code>
GreaterThanOne(""1/2"") ➞ false

GreaterThanOne(""7/4"") ➞ true

GreaterThanOne(""10/10"") ➞ false
            </p>
        </code>
Notes
Fractions must be strictly greater than 1 ";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
