namespace Ellabit.Challenges
{
    public class Challenge327Tracktherobotpart3 : IChallenge
    {
        public string? Header { get; set; } = "Track the robot (part 3)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  int[] TrackRobot(string steps) {
	  	
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
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
        int[] sumResult;
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
        public string? Description { get; set; } = @"A robot moves around a 2D grid. At the start, it is at [0, 0], facing east. It is controlled by a sequence of instructions:

. means take one step forwards in the current direction.
< means turn 90 degrees anticlockwise.
> means turn 90 degrees clockwise.
Your job is to process the instructions and return the final position of the robot.

Example
For example, if the robot is given the sequence of instructions ..<.<., then:

Step 1: . It still faces east, and is at [1, 0].
Step 2: . It still faces east, and is at [2, 0].
Step 3: < It now faces north, and is still at [2, 0].
Step 4: . It still faces north, and is at [2, 1].
Step 5: < It now faces west, and is still at [2, 1].
Step 6: . It still faces west, and is now at [1, 1].
So, TrackRobot(""..<.<."") returns [1, 1].

Notes
The instruction strings will only contain the three valid characters ., < or >.
You will always be passed a string (but the string might be empty).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
