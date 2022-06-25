namespace Ellabit.Challenges
{
    public class Challenge103Convertnumbertocorrespondingmonthname : IChallenge
    {
        public string? Header { get; set; } = "Convert number to corresponding month name";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string MonthName(int num) 
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
            sumResult = tmp.MonthName(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""March"",  $""returned: {sumResult}  expected: March"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.MonthName(12);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""December"",   $""returned: {sumResult}  expected: December"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.MonthName(6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""June"",   $""returned: {sumResult}  expected: June"");
    }
}
";
        public string? Description { get; set; } = @"<p>Create a function that takes a number (from 1 to 12) and returns its corresponding month name as a string. For example, if you're given 3 as input, your function should return ""March"", because March is the 3rd month.
<table><tr><th>Number  </th> <th>Month Name</th></tr><tr><td>1</td><td>January</td></tr><tr><td>2</td><td>February</td></tr><tr><td>3</td><td>March</td></tr><tr><td>4</td><td>April</td></tr><tr><td>5</td><td>May</td></tr><tr><td>6</td><td>June</td></tr><tr><td>7</td><td>July</td></tr><tr><td>8</td><td>August</td></tr><tr><td>9</td><td>September</td></tr><tr><td>10</td><td>October</td></tr><tr><td>11</td><td>November</td></tr><tr><td>12</td><td>December</td></tr></table>
</p>
Examples
MonthName(3) ➞ ""March""

MonthName(12) ➞ ""December""

MonthName(6) ➞ ""June""
Notes
You can expect only integers ranging from 1 to 12 as test input.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
