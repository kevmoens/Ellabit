namespace Ellabit.Challenges
{
    public class Challenge134Modifyingthelastcharacter : IChallenge
    {
        public string? Header { get; set; } = "Modifying the last character";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string ModifyLast(string str, int n)
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
            sumResult = tmp.ModifyLast(""hello"", 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""hellooo"" ,  $""returned: {sumResult}  expected: hellooo"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ModifyLast(""hey"", 6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""heyyyyyy"" ,   $""returned: {sumResult}  expected: heyyyyyy"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.ModifyLast(""excuse me what?"", 5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""excuse me what?????"" ,   $""returned: {sumResult}  expected: excuse me what?????"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  which  makes  the  last  character  of  a  string  repeat  n  number  of  times.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
modifylast("" hello"", 3) ➞ ""hellooo""
modifylast(""hey"", 6) ""heyyyyyy"" 
modifylast(""excuse me what?"", 5) ""excuse what?????"" 
            </p>
        </code>

notes test will include numbers and punctuation. make sure the code is not case sensitive.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
