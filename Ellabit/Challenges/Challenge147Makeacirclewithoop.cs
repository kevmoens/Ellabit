namespace Ellabit.Challenges
{
    public class Challenge147Makeacirclewithoop : IChallenge
    {
        public string? Header { get; set; } = "Make a circle with oop";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
class Rectangle
{
    public double SideA;
    public double SideB;
    public Rectangle(double sideA, double sideB){
        SideA = sideA;
        SideB = sideB;
    }
    public double GetArea(){
        return SideA * SideB;
    }
    public double GetPerimeter(){
        return (SideA + SideB) * 2;
    }
}


public class Circle {
    double pi = 3.1415926535897932384626433;
	//put code here
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Circle(11);
        double sumResult;
        try 
        {
            sumResult = tmp.GetArea();
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 380.132711084365,  $""returned: {sumResult}  expected: 380.132711084365"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Circle(4.44);
        double sumResult;
        try 
        {
            sumResult = tmp.GetPerimeter();
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 27.897342763877365,   $""returned: {sumResult}  expected: 27.897342763877365"");
    }
}
";
        public string? Description { get; set; } = @"Your content  task  is  to  create  a  circle  constructor  that  creates  a  circle  with  a  radius  provided  by  an  argument.  the  circles  constructed  must  have  two  getters  getarea()  (pi\r^2)  and  getperimeter()  (2\pi\*r)  which  give  both  respective  areas  and  perimeter  (circumference).

for  help  with  this  class,  i  have  provided  you  with  a  rectangle  constructor  which  you  can  use  as  a base example.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
Circle circy = new Circle(11);
circy.GetArea();

// Should return 380.132711084365.

Circle circy = new Circle(4.44);
circy.GetPerimeter();

// Should return 27.897342763877365
            </p>
        </code>

Notes
Don't worry about floating point precision - I've factored in the chance that your answer may be more or less accurate than mine. This is more of a tutorial than a challenge so the topic covered may be considered advanced, yet the challenge is more simple - so if this challenge gets labelled as easy, don't worry too much.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
    }
}
