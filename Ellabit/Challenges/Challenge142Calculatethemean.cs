namespace Ellabit.Challenges
{
    public class Challenge142Calculatethemean : IChallenge
    {
        public string? Header { get; set; } = "  \"Calculate the mean\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  double Mean(int[] arr) 
    {
        
    }
}


";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.Mean(new int[] {1,  0,  4,  5,  2,  4,  1,  2,  3,  3,  3})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   2.55,  $""returned: {sumResult}  expected: 2.55"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.Mean(new int[] {2,  3,  2,  3})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   2.50,   $""returned: {sumResult}  expected: 2.50"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.Mean(new int[] {3,  3,  3,  3,  3})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   3.00,   $""returned: {sumResult}  expected: 3.00"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  numbers  and  returns  the  mean  (average)  of  all  those  numbers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
mean([1,  0,  4,  5,  2,  4,  1,  2,  3,  3,  3])  ➞  2.55

mean([2,  3,  2,  3])  ➞  2.50

mean([3,  3,  3,  3,  3])  ➞  3.00
            </p>
        </code>

notes
round  to  two  decimal  places.
you  can  expect  a  number  ranging  from  0  to  10,000.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
