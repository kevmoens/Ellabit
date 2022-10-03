namespace Ellabit.Challenges
{
    public class Challenge189Isthenumbersymmetrical : IChallenge
    {
        public string? Header { get; set; } = "Is the number symmetrical?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
        public  bool IsSymmetrical(int num)
        {
			
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSymmetrical(7227)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSymmetrical(12567)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSymmetrical(44444444)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSymmetrical(9939)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsSymmetrical(1112111)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true,   $""returned: {sumResult}  expected: true"");
    }
}
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  number  as  an  argument  and  returns  true  or  false  depending  on  whether  the  number  is  symmetrical  or  not.  a  number  is  symmetrical  when  it  is  the  same  as  its  reverse.

        <h5>Examples</h5>
        <code>
IsSymmetrical(7227)  ➞  true

IsSymmetrical(12567)  ➞  false

IsSymmetrical(44444444)  ➞  true

IsSymmetrical(9939)  ➞  false

IsSymmetrical(1112111)  ➞  true
            </p>
        </code>

""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
