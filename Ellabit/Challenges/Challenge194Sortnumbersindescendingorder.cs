namespace Ellabit.Challenges
{
    public class Challenge194Sortnumbersindescendingorder : IChallenge
    {
        public string? Header { get; set; } = "Sort numbers in descending order";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int SortDescending(int num) 
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
        int sumResult;
        try 
        {
            sumResult = tmp.SortDescending(123)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   321,  $""returned: {sumResult}  expected: 321"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.SortDescending(2619805)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   9865210,   $""returned: {sumResult}  expected: 9865210"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.SortDescending(73065);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 76530,   $""returned: {sumResult}  expected: 76530"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  any  nonnegative  number  as  an  argument  and  return  it  with  it's  digits  in  descending  order.  descending  order  is  when  you  sort  from  highest  to  lowest.

        <h5>Examples</h5>
        <code>
sortdescending(123)  ➞  321

sortdescending(2619805)  ➞  9865210

sortdescending(73065)  ➞  76530
            </p>
        </code>

notes
you  can  expect  non-negative  numbers  for  all  test  cases.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
