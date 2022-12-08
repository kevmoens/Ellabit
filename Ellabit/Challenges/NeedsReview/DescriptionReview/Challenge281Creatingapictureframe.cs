namespace Ellabit.Challenges
{
    public class Challenge281Creatingapictureframe : IChallenge
    {
        public string? Header { get; set; } = "Creating a picture frame";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
// add additional libraries if required

public class Challenge 
{
	public  string[] GetFrame(int w, int h, char ch)
	{
		return null;
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
        string[] sumResult;
        try 
        {
            sumResult = tmp.get_frame(4,  5,  "" #"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  [ ""####"", ""# #"", ""####"" ] frame is 4 characters wide and 5 tall. ,  $""returned: {sumResult}  expected: [ ####, # #, #### ] frame is 4 characters wide and 5 tall."");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  the  width,  height  and  character  and  returns  a  picture  frame  as  an  array  of  strings  (string[]).

examples
get_frame(4,  5,  "" #"") ➞ [ ""####"", ""# #"", ""####"" ] frame is 4 characters wide and 5 tall. get_frame(10, 3, ""*"") ""**"", ""* *"", ""**"" 10 and""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
