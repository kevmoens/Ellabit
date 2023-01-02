namespace Ellabit.Challenges
{
    public class Challenge317Rationalnumberclasspart1 : IChallenge
    {
        public string? Header { get; set; } = "Rational number class (part 1)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

namespace Program
{
    /* This is a series of progressive challenges to create a fully-featured
			 numeric struct called Rational which defines a rational number in the
			 form Numerator/Denominator.  The series starts with defining a simple
			 struct, which is created with 2 parameters representing the numerator
			 and the denominator, and providing readonly properties Numerator and
			 Denominator and an overriden ToString() method. 
			 
     	 Subsequent challenges in the series will explore operator overloading
			 and implicit and explicit type conversion. */
    public struct Rational
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
        int sumResult;
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
        int sumResult;
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
        int sumResult;
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
        public string? Description { get; set; } = @"C# has several numeric types, including natural, real, and irrational numbers. One numeric type that's missing is a Rational number. A rational number, as the name suggests is a ratio between 2 natural numbers and is usually represented as a fraction in the form 1/2, 5/4, -79/13, etc.

Create a C# struct with a constructor that takes two integer parameters, either or both of which may be positive or negative. Include two read-only properties, Numerator and Denominator, that return the numerator and denominator of the fraction respectively of type int. Also, override the ToString() method to give a string representation of the rational number as described in the preceding paragraph.

Examples
var r1 = new Rational(1, 2);
r1.Numerator ➞ 1
r1.Denominator ➞ 2
r1.ToString() ➞ ""1/2""

var r2 = new Rational(10, 8);
r2.Numerator ➞ 5
r2.Denominator ➞ 4
r2.ToString() ➞ ""5/4""

var r3 = new Rational(2, -1);
r3.Numerator ➞ -2
r3.Denominator ➞ 1
r3.ToString() ➞ ""-2""

var r4 = new Rational(-16, -64);
r4.Numerator ➞ 1
r4.Denominator ➞ 4
r4.ToString() ➞ ""1/4""
Notes
The numerator may be zero, but if the denominator is zero an ArgumentException should be raised by the constructor function.
The Numerator and Denominator values should be reduced to their lowest possible integer values to maintain the ratio (examples r2 and r4 above).
If the resulting fraction is a whole number, the Denominator should return 1 but the ToString() method should only show the integer value (example r3 above).
If one of the values of numerator and denominator is negative, the sign is shown on the Numerator and the Denominator is positive (example r3 above).
If both the numerator and denominator are negative, the fraction is positive and both Numerator and Denominator are positive (example r4 above).
If the numerator is zero, the denominator should be set to 1, regardless of the value passed to the constructor.
Parts 2 and 3
Parts 2 and 3 of this series will build on the Rational struct developed here to include arithmetical operations, comparison operators, and conversion to and from other numeric types. They can be found here.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
