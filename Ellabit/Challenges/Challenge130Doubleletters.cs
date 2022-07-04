namespace Ellabit.Challenges
{
    public class Challenge130Doubleletters : IChallenge
    {
        public string? Header { get; set; } = "Double letters";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public bool DoubleLetters(string word)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.DoubleLetters(""loop"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.DoubleLetters(""yummy"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.DoubleLetters(""orange"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.DoubleLetters(""munchkin"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,  $""returned: {sumResult}  expected: false"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a word and returns true if the word has two consecutive identical letters.

Examples
DoubleLetters(""loop"") ➞ true

DoubleLetters(""yummy"") ➞ true

DoubleLetters(""orange"") ➞ false

DoubleLetters(""munchkin"") ➞ false";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
    }
}
