namespace Ellabit.Challenges
{
    public class Challenge188UTF8bomtextencoding : IChallenge
    {
        public string? Header { get; set; } = "UTF-8 bom text encoding";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge
    {
	    public  byte[] GetUTF8BOM() 
        {
            return new byte[] {0x00};
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;
using System.Text;
using System.Linq;
namespace Ellabit
{
public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        byte[] sumResult;
        try 
        {
            sumResult = tmp.GetUTF8BOM();
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new byte[] {0xef, 0xbb, 0xbf}),  $""returned: {string.Join("", "", sumResult)}  expected: [0xef, 0xbb, 0xbf]"");
    }
}
}
";
        public string? Description { get; set; } = @"Before Unicode became standard, text files and string data were encoded in different 8-bit based code pages, each different between Germany, Spain, Italy, Sweden, etc. Nowadays, UTF-8 is the mostly used standard for sending text in network communication and when saving text data to files.

UTF-8 encoded text files have a prefix that defines that the file is encoded in UTF-8. It is called a BOM (byte order mark). Use the .Net framework to determine the sequence for the UTF-8 BOM.

        <h5>Examples</h5>
        <code>
GetUTF8BOM() ➞ { 0xef, 0xbb, 0xbf } (byte array)
            </p>
        </code>
Notes
Use the class UTF8Encoding in the System.Text namespace.";
        public List<string> Tests { get; set; } = new string[] { "Test1" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        public bool ShowBlockly { get => false; }
    }
}
