using System;
namespace Ellabit.Challenges
{
	public class ChallengeColor001 : IChallenge
    {
        public string? Header { get; set; } = "Add two colors";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public System.Drawing.Color AddColors(System.Drawing.Color a1, System.Drawing.Color a2)
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
        System.Drawing.Color sumResult;
        try 
        {
            sumResult = tmp.AddColors(System.Drawing.Color.FromArgb(255,255,0,0), System.Drawing.Color.FromArgb(255,0,0,255));
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == System.Drawing.Color.FromArgb(255,255,0,255),   $""returned: {sumResult}  expected: Color (Magenta) (FF,00,FF)"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        System.Drawing.Color sumResult;
        try 
        {
            sumResult = tmp.AddColors(System.Drawing.Color.FromArgb(255,0,255,0), System.Drawing.Color.FromArgb(255,0,0,255));
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == System.Drawing.Color.FromArgb(255,0,255,255),   $""returned: {sumResult}  expected: Color (Cyan) (00,FF,FF)"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        System.Drawing.Color sumResult;
        try 
        {
            sumResult = tmp.AddColors(System.Drawing.Color.FromArgb(255,0,255,255), System.Drawing.Color.FromArgb(255,255,0,0));
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == System.Drawing.Color.FromArgb(255,255,255,255),   $""returned: {sumResult}  expected: Color (White) (FF,FF,FF)"");
    }
}
";
        public string? Description { get; set; } = @"
        Add two colors to make a different color.
        
        <p>Colors have a (R)ed, (G)reen and (B)lue value also known as R G B.
        
        Adding both Red, both Green and both Blues together to make a new color.  
        
        To get a color variable in code run System.Drawing.Color.FromArgb(255, 196, 128, 64)
        </p>
        Where the: 
- 255 is the Alpha
- 196 is the Red
- 128 is the Green
- 64 is the Blue




        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                AddColors(0xFF0000, 0x0000FF) ➞ 0xFF00FF (Magenta)
                <br />
                AddColors(0x00FF00, 0x0000FF) ➞ 0x00FFFF (Cyan)
                <br />
                AddColors(0x00FFFF, 0xFF0000) ➞ 0xFFFFFF (White)
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
