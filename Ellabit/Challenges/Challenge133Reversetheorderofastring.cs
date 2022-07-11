namespace Ellabit.Challenges
{
    public class Challenge133Reversetheorderofastring : IChallenge
    {
        public string? Header { get; set; } = "Reverse the order of a string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string Reverse(string str) 
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
        string sumResult;
        try 
        {
            sumResult = tmp.Reverse(""hello world"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""dlrow olleh"" ,  $""returned: {sumResult}  expected: dlrow olleh"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Reverse(""the quick brown fox."");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  "".xof nworb kciuq eht"" ,   $""returned: {sumResult}  expected: .xof nworb kciuq eht"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.Reverse(""edabit is really helpful!"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""!lufpleh yllaer si tibade"" ,   $""returned: {sumResult}  expected: !lufpleh yllaer si tibade"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  as  its  argument  and  returns  the  string  in  reversed  order.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
reverse("" hello world"") ➞ ""dlrow olleh"" 
reverse(""the quick brown fox."") "".xof nworb kciuq eht"" 
reverse(""edabit is really helpful!"") ""!lufpleh yllaer si tibade"" 
            </p>
        </code>

notes 
you can expect a valid string for all test cases.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
