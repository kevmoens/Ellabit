namespace Ellabit.Challenges
{
    public class Challenge002ConvertMinutesToSeconds : IChallenge
    {

        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public int convert(int minute)
    {
        return 0;
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 300, sumResult.ToString());
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 180,  sumResult.ToString());
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 120,  sumResult.ToString());
    }
}
";
        public string? Description { get; set; } = @"<h3>Convert Minutes into Seconds</h3>
            Write a function that takes an integer minutes and converts it to seconds.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                convert(5) ➞ 300
                <br />
                convert(3) ➞ 180
                <br />
                convert(2) ➞ 120
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<ITest> Tests { get; set; } = new ITest[] { new Challenge002Test1(), new Challenge002Test2(), new Challenge002Test3() }.ToList();
    }
    public class Challenge002Test1 : ITest
    {
        public string CodeTypeName { get; set; } = "Ellabit.TestChallenge";
        public string CodeMethod { get; set; } = "Test1";
    }
    public class Challenge002Test2 : ITest
    {
        public string CodeTypeName { get; set; } = "Ellabit.TestChallenge";
        public string CodeMethod { get; set; } = "Test2";
    }
    public class Challenge002Test3 : ITest
    {
        public string CodeTypeName { get; set; } = "Ellabit.TestChallenge";
        public string CodeMethod { get; set; } = "Test3";
    }
}
