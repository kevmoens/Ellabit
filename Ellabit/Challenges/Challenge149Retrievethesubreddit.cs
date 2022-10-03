namespace Ellabit.Challenges
{
    public class Challenge149Retrievethesubreddit : IChallenge
    {
        public string? Header { get; set; } = "Retrieve the subreddit";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  string SubReddit(string link)
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
            sumResult = tmp.SubReddit(""https:////www.reddit.com//r//funny"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""funny"" ,  $""returned: {sumResult}  expected: funny"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SubReddit(""https:////www.reddit.com//r//relationships//"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""relationships"",   $""returned: {sumResult}  expected: relationships"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SubReddit(""https:////www.reddit.com//r//mildlyinteresting//"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""mildlyinteresting"",   $""returned: {sumResult}  expected: mildlyinteresting"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  to  extract  the  name  of  the  subreddit  from  its  url.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
SubReddit(""https://www.reddit.com/r/funny/"") ➞ ""funny""

SubReddit(""https://www.reddit.com/r/relationships/"") ➞ ""relationships""

SubReddit(""https://www.reddit.com/r/mildlyinteresting/"") ➞ ""mildlyinteresting""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
