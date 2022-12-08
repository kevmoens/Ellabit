namespace Ellabit.Challenges
{
    public class Challenge231Phonenumberworddecoder : IChallenge
    {
        public string? Header { get; set; } = "Phone number word decoder";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string TextToNum(string phone) 
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
            sumResult = tmp.texttonum("" 123-647-eyes"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""123-647-3937"" ,  $""returned: {sumResult}  expected: 123-647-3937"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.texttonum(""(325)444-test"") ""(325);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 444-8378"" ,   $""returned: {sumResult}  expected: 444-8378"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.texttonum(""653-try-this"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""653-879-8447"" ,   $""returned: {sumResult}  expected: 653-879-8447"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  program  that  converts  a  phone  number  with  letters  to  one  with  only  numbers.

number  |  letter
---  |  ---
0  |  none
1  |  none
2  |  abc
3  |  def
4  |  ghi
5  |  jkl
6  |  mno
7  |  pqrs
8  |  tuv
9  |  wxyz

examples
texttonum("" 123-647-eyes"") ➞ ""123-647-3937"" texttonum(""(325)444-test"") ""(325)444-8378"" texttonum(""653-try-this"") ""653-879-8447"" texttonum(""435-224-761""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
