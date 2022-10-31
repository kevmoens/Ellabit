namespace Ellabit.Challenges
{
    public class Challenge195Fridaythe13th : IChallenge
    {
        public string? Header { get; set; } = "Friday the 13th";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	  public  bool HasFriday13th(int month, int year)
	  {
		  return true|false;
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HasFriday13th(3, 2020) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,  $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HasFriday13th(10, 2017) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HasFriday13th(1, 1985) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  false,   $""returned: {sumResult}  expected:  false"");
    }
}
";
        public string? Description { get; set; } = @"Given the month and year as numbers, return whether that month contains a friday 13th.

examples
hasfriday13th(3, 2020) ➞ true

hasfriday13th(10, 2017) ➞ true

hasfriday13th(1, 1985) ➞ false

notes
january will be given as 1, february as 2, etc ...
check resources for some helpful tutorials on c#'s datetime struct.""1""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
