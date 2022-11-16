namespace Ellabit.Challenges
{
    public class Challenge201Pitondecimalplaces : IChallenge
    {
        public string? Header { get; set; } = "Pi to n decimal places";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  decimal MyPi(int n) 
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
        decimal sumResult;
        try 
        {
            sumResult = tmp.mypi(5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   3.14159

,  $""returned: {sumResult}  expected: 3.14159"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        decimal sumResult;
        try 
        {
            sumResult = tmp.mypi(4)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   3.1416

,   $""returned: {sumResult}  expected: 3.1416"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        decimal sumResult;
        try 
        {
            sumResult = tmp.mypi(15)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   3.141592653589793

,   $""returned: {sumResult}  expected: 3.141592653589793"");
    }
}
";
        public string? Description { get; set; } = @"Given content  a  number  n,  write  a  function  that  returns  pi  to  n  decimal  places.

examples
mypi(5)  ➞  3.14159

mypi(4)  ➞  3.1416

mypi(15)  ➞  3.141592653589793

notes
n  will  not  be  above  15,  to  keep  this  challenge  simple.
round  up  the  last  digit  if  the  next  digit  in  pi  is  greater  or  equal  to  5  (see  second  example  above).
the  return  value  must  be  a  number  (add  suffix  -m  t""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
