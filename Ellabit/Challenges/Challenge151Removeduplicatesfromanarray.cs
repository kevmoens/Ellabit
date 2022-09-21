namespace Ellabit.Challenges
{
    public class Challenge151Removeduplicatesfromanarray : IChallenge
    {
        public string? Header { get; set; } = "Remove duplicates from an array";
        public string? Code { get; set; } = @"
using System;
using System.Linq;

namespace Ellabit {

public class Challenge 
{
    public  object[] RemoveDups(object[] str) 
    {
      
    }
}

}";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        object[] sumResult;
        try 
        {
            sumResult = tmp.RemoveDups(new object[] {1,  0,  1,  0})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new object[] {1,  0}),  $""returned: [{string.Join("", "", sumResult)}]   expected: [1,  0]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        object[] sumResult;
        try 
        {
            sumResult = tmp.RemoveDups(new object[] {""the"", ""big"", ""cat""}) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new object[] {""the"", ""big"", ""cat""}) ,   $""returned: [{string.Join("", "", sumResult)}]   expected: [the, cat]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        object[] sumResult;
        try 
        {
            sumResult = tmp.RemoveDups(new object[] {""john"", ""taylor"", ""john""});
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new object[] {""john"", ""taylor""}) ,   $""returned: [{string.Join("", "", sumResult)}]   expected: [john, taylor]"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  items,  removes  all  duplicate  items  and  returns  a  new  array  in  the  same  sequential  order  as  the  old  array  (minus  duplicates).

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
removedups([1,  0,  1,  0])  ➞  [1,  0]

removedups(["" the"", ""big"", ""cat""]) ➞ [""the"", ""cat""] 

removedups([""john"", ""taylor"", ""john""]) [""john"", ""taylor""] 
            </p>
        </code>

notes tests contain arrays with""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
