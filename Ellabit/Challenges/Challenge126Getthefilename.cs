namespace Ellabit.Challenges
{
    public class Challenge126Getthefilename : IChallenge
    {
        public string? Header { get; set; } = "Get the file name";
        public string? Code { get; set; } = @"
using System;
using System.IO;
namespace Ellabit;

public class Challenge
{
	public  string GetFilename(string path)
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
            sumResult = tmp.GetFilename(""C:/Projects/pil_tests/ascii/ellabit.txt"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""ellabit.txt"",  $""returned: {sumResult}  expected: ellabit.txt"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetFilename(""C:/Users/johnsmith/Music/Beethoven_5.mp3"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Beethoven_5.mp3"",   $""returned: {sumResult}  expected: Beethoven_5.mp3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.GetFilename(""ffprobe.exe"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""ffprobe.exe"",   $""returned: {sumResult}  expected: ffprobe.exe"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that returns the selected filename from a path. Include the extension in your answer.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
GetFilename(""C:/Projects/pil_tests/ascii/ellabit.txt"") ➞ ""ellabit.txt""

GetFilename(""C:/Users/johnsmith/Music/Beethoven_5.mp3"") ➞ ""Beethoven_5.mp3""

GetFilename(""ffprobe.exe"") ➞ ""ffprobe.exe""
            </p>
        </code>
Notes
Tests will include both absolute and relative paths.
For simplicity, all paths will include forward slashes.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
