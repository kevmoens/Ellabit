namespace Ellabit.Challenges
{
    public class Challenge162Removeeveryvowelfromastring : IChallenge
    {
        public string? Header { get; set; } = "Remove every vowel from a string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  string RemoveVowels(string str) 
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
            sumResult = tmp.RemoveVowels(""i have never seen a thin person drinking diet coke."") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  "" hv nvr sn  thn prsn drnkng dt ck."" ,  $""returned: [{sumResult}]  expected: [ hv nvr sn  thn prsn drnkng dt ck.]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.RemoveVowels(""we're gonna build wall!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""w'r gnn bld wll!"" ,   $""returned: {sumResult}  expected: w'r gnn bld wll!"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.RemoveVowels(""happy thanksgiving to all--even the haters and losers!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""hppy thnksgvng t ll--vn th htrs nd lsrs!"",   $""returned: {sumResult}  expected: hppy thnksgvng t ll--vn th htrs nd lsrs!"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  and  returns  a  new  string  with  all  vowels  removed.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
removevowels(""i have never seen a thin person drinking diet coke."") ➞ "" hv nvr sn thn prsn drnkng dt ck."" 
removevowels(""we're gonna build wall!"") ➞ ""w'r gnn bld wll!"" 
removevowels(""happy thanksgiving to all--even the haters and losers!"") ➞ ""hppy thnksgvng t ll--vn th htrs nd lsrs!""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
