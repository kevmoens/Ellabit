namespace Ellabit.Challenges
{
    public class Challenge139Amongusimposterformula : IChallenge
    {
        public string? Header { get; set; } = "Among us imposter formula";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  string ImposterFormula(int i, int p)
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
        string sumResult;
        try 
        {
            sumResult = tmp.ImposterFormula(1,  10)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   ""10%"" ,  $""returned: {sumResult}  expected:  10%"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ImposterFormula(2, 5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""40%"",   $""returned: {sumResult}  expected: 40%"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ImposterFormula(3,4);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""75%"",   $""returned: {sumResult}  expected: 75%"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  calculates  the  chance  of  being  an  imposter.  the  formula  for  the  chances  of  being  an  imposter  is  100  ×  (i  p)  where  i  is  the  imposter  count  and  p  is  the  player  count.  make  sure  to  round  the  value  to  the  nearest  integer  and  return  the  value  as  a  percentage.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
imposterformula(1,  10)  ➞ ""10%"" 
imposterformula(2, 5) ➞ ""40%"" 
imposterformula(3, 4) ➞ ""75%""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
