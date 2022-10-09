namespace Ellabit.Challenges
{
    public class Challenge167Reversethecase : IChallenge
    {
        public string? Header { get; set; } = "Reverse the case";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  string ReverseCase(string str) 
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
            sumResult = tmp.reversecase(""Happy Birthday"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""hAPPY bIRTHDAY"" ,  $""returned: {sumResult}  expected: hAPPY bIRTHDAY"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.reversecase(""MANY THANKS"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""many thanks"" ,   $""returned: {sumResult}  expected: many thanks"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.reversecase(""sPoNtAnEoUs"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""SpOnTaNeOuS"" ,   $""returned: {sumResult}  expected: SpOnTaNeOuS"");
    }
}
}";
        public string? Description { get; set; } = @"Given content  a  string,  create  a  function  to  reverse  the  case.  all  lower-cased  letters  should  be  upper-cased,  and  vice  versa.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
ReverseCase(""Happy Birthday"") ➞ ""hAPPY bIRTHDAY""

ReverseCase(""MANY THANKS"") ➞ ""many thanks""

ReverseCase(""sPoNtAnEoUs"") ➞ ""SpOnTaNeOuS""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
