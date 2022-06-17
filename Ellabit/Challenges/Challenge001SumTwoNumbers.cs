namespace Ellabit.Challenges
{
    public class Challenge001SumTwoNumbers : IChallenge
    {

        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public int SumTwoNum(int a, int b)
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
            sumResult = tmp.SumTwoNum(3,2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 5, sumResult.ToString());
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.SumTwoNum(-3,-6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == -9,  sumResult.ToString());
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.SumTwoNum(7,3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 10,  sumResult.ToString());
    }
}
";
        public string? Description { get; set; } = @"<h3>Return the Sum of Two Numbers</h3>
            Create a function that takes two numbers as arguments and returns their sum.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                Sum(3, 2) ➞ 5
                <br />
                Sum(-3, -6) ➞ -9
                <br />
                Sum(7, 3) ➞ 10
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";
        public List<ITest> Tests { get; set; } = new ITest[] {new Challenge001Test1(), new Challenge001Test2(), new Challenge001Test3() }.ToList();
    }
    public class Challenge001Test1 : ITest
    {
        public string CodeTypeName { get; set; } = "Ellabit.TestChallenge";
        public string CodeMethod { get; set; } = "Test1";
    }
    public class Challenge001Test2 : ITest
    {
        public string CodeTypeName { get; set; } = "Ellabit.TestChallenge";
        public string CodeMethod { get; set; } = "Test2";
    }
    public class Challenge001Test3 : ITest
    {
        public string CodeTypeName { get; set; } = "Ellabit.TestChallenge";
        public string CodeMethod { get; set; } = "Test3";
    }
    public class Challenge001TestParms
    {
        public int Output { get; set; }
    }
}
