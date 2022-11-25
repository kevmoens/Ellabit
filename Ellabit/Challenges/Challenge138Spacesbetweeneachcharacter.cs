namespace Ellabit.Challenges
{
    public class Challenge138Spacesbetweeneachcharacter : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Spaces between each character";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  string SpaceMeOut(string str)
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
            sumResult = tmp.SpaceMeOut(""space"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""s p a c e"" ,  $""returned: {sumResult}  expected: s p a c e"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SpaceMeOut(""far out"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""f a r   o u t"" ,   $""returned: {sumResult}  expected: f a r   o u t"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.SpaceMeOut(""elongated musk"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""e l o n g a t e d   m u s k"" ,   $""returned: {sumResult}  expected: e l o n g a t e d   m u s k"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  a  string  and  returns  a  string  with  spaces  in  between  all  of  the  characters.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
spacemeout(""space"") ➞ ""s p a c e"" 
spacemeout(""far out"") ➞ ""f a r o u t"" 
spacemeout(""elongated musk"") ➞ ""e l o n g a t e d m u s k""
            </p>
        </code>

notes treat space as its own character (i.e. leave three spaces between words).""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "String", "ToCharArray()" }, { "Loop", "For" }, { "Level", "1"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
