namespace Ellabit.Challenges
{
    public class Challenge208Findthenthtetrahedralnumber : IChallenge
    {
        public string? Header { get; set; } = "Find the nth tetrahedral number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
	public  int Tetra(int n) {
		
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
            sumResult = tmp.tetra(2)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   4

,  $""returned: {sumResult}  expected: 4"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.tetra(5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   35

,   $""returned: {sumResult}  expected: 35"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.tetra(6)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   56

notes
there  is  a  formula  for  the  nth  ,   $""returned: {sumResult}  expected: 56

notes
there  is  a  formula  for  the  nth"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  integer  n  and  returns  the  nth  tetrahedral  number.

alternative  text

examples
tetra(2)  ➞  4

tetra(5)  ➞  35

tetra(6)  ➞  56

notes
there  is  a  formula  for  the  nth  tetrahedral  number.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
