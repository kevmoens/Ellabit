namespace Ellabit.Challenges
{
    public class Challenge155Equalityof3values : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Equality of 3 values";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  int Equal(int a, int b, int c)
    {
			
    }
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Equal(3,  4,  3)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   2,  $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Equal(1,  1,  1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   3,   $""returned: {sumResult}  expected: 3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Equal(3,  4,  1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   0,   $""returned: {sumResult}  expected: 0"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  three  integer  arguments  (a,  b,  c)  and  returns  the  amount  of  integers  which  are  of  equal  value.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
equal(3,  4,  3)  ➞  2

equal(1,  1,  1)  ➞  3

equal(3,  4,  1)  ➞  0
            </p>
        </code>

notes
your  function  must  return  0,  2  or  3.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Int", "Logic"},{ "Logic", " '=='"}, { "Level","2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
