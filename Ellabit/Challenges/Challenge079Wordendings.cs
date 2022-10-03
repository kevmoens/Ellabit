namespace Ellabit.Challenges
{
    public class Challenge079Wordendings : IChallenge
    {
        public string? Header { get; set; } = "Word endings";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string[] AddEnding(string[] arr, string ending)
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
        string[] sumResult;
        try 
        {
            sumResult = tmp.AddEnding(new string[] {""clever"", ""meek"", ""hurried"", ""nice""}, ""ly"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new string[] {""cleverly"", ""meekly"", ""hurriedly"", ""nicely""}),  $""returned: [{string.Join("", "", sumResult)}]  expected: [cleverly, meekly, hurriedly, nicely]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.AddEnding(new string[] {""new"", ""pander"", ""scoop""}, ""er"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new string[] {""newer"", ""panderer"", ""scooper""}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [newer, panderer, scooper]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.AddEnding(new string[] {""bend"", ""sharpen"", ""mean""}, ""ing"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new string[] {""bending"", ""sharpening"", ""meaning""}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [bending, sharpening, meaning]"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that adds a string ending to each member in an array.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
        AddEnding(new string[] {""clever"", ""meek"", ""hurried"", ""nice""}, ""ly""}) ➞ new string[] {""cleverly"", ""meekly"", ""hurriedly"", ""nicely""}

        AddEnding(new string[] {""new"", ""pander"", ""scoop""}, ""er""}) ➞ new string[] {""newer"", ""panderer"", ""scooper""}

        AddEnding(new string[] {""bend"", ""sharpen"", ""mean""}, ""ing""}) ➞ new string[] {""bending"", ""sharpening"", ""meaning""}
            </p>
        </code>

        Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
