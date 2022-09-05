namespace Ellabit.Challenges
{
    public class Challenge171Convertallarrayitemstostring : IChallenge
    {
        public string? Header { get; set; } = "Convert all array items to string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

    public class Challenge
    {
	    public  string[] ParseArray (object[] arr)
	    {
		
	    }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;
using System.Linq;
namespace Ellabit
{
    public class TestChallenge
    {
        public (bool pass, string message) Test1()
        {
            var tmp = new Challenge();
            string[] sumResult;
            try 
            {
                sumResult = tmp.ParseArray(new object[] {1,  2,  ""a"", ""b""});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            
            return (sumResult.SequenceEqual(new string[] {""1"", ""2"", ""a"", ""b""}) ,  $""returned: {string.Join("", "", sumResult)}  expected: ['1', '2', 'a', 'b']"");
        }

        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            string[] sumResult;
            try 
            {
                sumResult = tmp.ParseArray(new object[] {""abc"", 123, ""def"", 456});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult.SequenceEqual(new string[] {""abc"", ""123"", ""def"", ""456""}) ,   $""returned: {string.Join("", "", sumResult)}  expected: ['abc', '123', 'def', '456']"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            string[] sumResult;
            try 
            {
                sumResult = tmp.ParseArray(new object[] {1, 2, 3, 17, 24, ""123b""});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult.SequenceEqual(new string[] {""1"", ""2"", ""3"", ""17"", ""24"", ""123b""}),   $""returned: {string.Join("", "", sumResult)}  expected: ['1', '2', '3', '17', '24', '123b']"");
        }
        public (bool pass, string message) Test4()
        {
            var tmp = new Challenge();
            string[] sumResult;
            try 
            {
                sumResult = tmp.ParseArray(new object[] {});
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult.SequenceEqual(new string[] {}),   $""returned: {string.Join("", "", sumResult)}  expected: []"");
        }
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  integers  and  strings,  converts  integers  to  strings,  and  returns  the  array  as  a  string  array.

        <h5>Examples</h5>
        <code>
parsearray([1,  2,  "" a"", ""b""]) ➞ [""1"", ""2"", ""a"", ""b""] 
parsearray([""abc"", 123, ""def"", 456]) ➞ [""abc"", ""123"", ""def"", ""456""] 
parsearray([1, 2, 3, 17, 24, ""123b""]) ➞ [""1"", ""2"", ""3"", ""17"", ""24"", ""123b""] 
parsearray([]) ➞ [])
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
