namespace Ellabit.Challenges
{
    public class Challenge146Alphabetsoup : IChallenge
    {
        public string? Header { get; set; } = "Alphabet soup";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  string AlphabetSoup(string str) 
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
            sumResult = tmp.AlphabetSoup(""hello"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""ehllo"" ,  $""returned: {sumResult}  expected: ehllo"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AlphabetSoup(""ellabit"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""abeillt"" ,   $""returned: {sumResult}  expected: abeillt"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AlphabetSoup(""hacker"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""acehkr"" ,   $""returned: {sumResult}  expected: acehkr"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AlphabetSoup(""geek"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""eegk"" ,   $""returned: {sumResult}  expected: eegk"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.AlphabetSoup(""javascript"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""aacijprstv"" ,   $""returned: {sumResult}  expected: aacijprstv"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  and  returns  a  string  with  its  letters  in  alphabetical  order.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
alphabetsoup("" hello"") ➞ ""ehllo"" 
alphabetsoup(""ellabit"") ➞ ""adeillt"" 
alphabetsoup(""hacker"") ➞ ""acehkr"" 
alphabetsoup(""geek"") ➞ ""eegk"" 
alphabetsoup(""javascript"") ➞ ""aacijprstv"" 
            </p>
        </code>

notes you can assume numbers and punctuation symbols won't be included in the string""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
