namespace Ellabit.Challenges
{
    public class Challenge169Returntheindexofallcapitalletters : IChallenge
    {
        public string? Header { get; set; } = "  \"Return the index of all capital letters\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

using System;
using System.Linq;
using System.Collections.Generic;
public class Challenge 
{
    public  int[] IndexOfCapitals(string str) 
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.IndexOfCapitals(""eLlaBiT"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1,4,6}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [1,4,6]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.IndexOfCapitals(""eQuINoX"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1,3,4,6}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [1,3,4,6]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.IndexOfCapitals(""determine"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {}),   $""returned: [{string.Join("", "", sumResult)}]  expected: []"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.IndexOfCapitals(""STRIKE"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {0,1,2,3,4,5}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [0,1,2,3,4,5]"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.IndexOfCapitals(""sUn"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {1}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [1]"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  single  string  as  argument  and  returns  an  ordered  array  containing  the  indices  of  all  capital  letters  in  the  string.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
IndexOfCapitals(""eLlaBiT"") ➞ [1, 4, 6]

IndexOfCapitals(""eQuINoX"") ➞ [1, 3, 4, 6]

IndexOfCapitals(""determine"") ➞ []

IndexOfCapitals(""STRIKE"") ➞ [0, 1, 2, 3, 4, 5]

IndexOfCapitals(""sUn"") ➞ [1]
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
