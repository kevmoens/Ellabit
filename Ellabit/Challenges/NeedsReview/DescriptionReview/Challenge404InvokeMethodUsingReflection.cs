﻿namespace Ellabit.Challenges.NeedsReview.DescriptionReview
{
    public class Challenge404InvokeMethodUsingReflection
    {
        public string? Header { get; set; } = "Invoke the Method by using Reflection";
        public string? Code { get; set; } = @"
using System;

using System.Reflection;

namespace Ellabit;

using system;

namespace Program
{
    public Class Challenge
    {
        public int InvokeMethod(int a, int b)
        {
            
        }
        public int InvokeOverloadMethod(int a, int b, int c)
        {
            
        }
        public int InvokeProperty(int a)
        {
            
        }
    }
    public class TestClass1
    {
        public int MyAge {get; set;}

        public int TestMethod(int a, int b)
        {
           return a + b;
        }
        public int TestMethod(int num, int secondNum, int LastNumber)
        {
           return (num + secondNum) * lastNum;
        }
        
    }   
}
";
        public string? TesttCode { get; set; } = @"

using system;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try
        {
           sumResult = tmp.InvokeMethod(2, 2);
        }catch(Exception ex)
        {
           return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 4, $""returned: {sumResult} expected: 4"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try
        {
           sumResult = tmp.InvokeOverloadMethod(3, 2, 2);
        }catch(Exception ex)
        {
           return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 10, $""returned: {sumResult} expected: 10"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try
        {
           sumResult = tmp.InvokeProperty(21);
        }catch(Exception ex)
        {
           return (false, ex.ToString() + ""/n"" + ex.Message);
        }
        return (sumResult == 21, $""returned: {sumResult} expected: 21"");
    } 
}
";
        public string? Description { get; set; } = @"

Write a function using Reflection that Invokes the method in the second Class.

<h5>Examples</h5>
        <code>
            <p style = """"border:1px solid grey; padding: 10px;"""" >
                Sum(2, 2) ➞ 4
                <br />
                Sum(3, 2) ➞ 5
                <br />
                Sum(4, 4) ➞ 8
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>""
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"Reflection", "Int"} ,{ "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
