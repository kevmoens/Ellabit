namespace Ellabit.Challenges
{
    public class Challenge387Rationalnumberclasspart2 : IChallenge
    {
        public string? Header { get; set; } = "Rational number class (part 2)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

namespace Program
{
    public struct Rational
    {
        readonly int numerator;
        readonly int denominator;

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException(""The denominator must be non-zero"");
            }
            if (numerator == 0)
            {
                this.numerator = 0;
                this.denominator = 1;
            }
            else
            {
                var gcd = Math.Abs(GCD(numerator, denominator));
                var sign = Math.Sign(numerator * denominator);
                this.numerator = sign * Math.Abs(numerator) / gcd;
                this.denominator = Math.Abs(denominator) / gcd;
            }
        }

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

        public int Sign { get { return Math.Sign(Numerator); } }

        public  Rational FromDecimal(decimal value)
        {
            var str = value.ToString().Split('.');
            if (str.Length == 1)
            {
                return new Rational((int)value, 1);
            }
            var d = (int)Math.Pow(10, str[1].Length);
            return new Rational((int)(value * d), d);
        }

        public  Rational operator +(Rational a) => a;
        public  Rational operator -(Rational a) => new Rational(-a.numerator, a.denominator);
        public  Rational operator +(Rational a, Rational b) 
            => new Rational(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        public  Rational operator -(Rational a, Rational b)
            => new Rational(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
        public  Rational operator *(Rational a, Rational b)
            => new Rational(a.numerator * b.numerator, a.denominator * b.denominator);
        public  Rational operator /(Rational a, Rational b)
            => new Rational(a.numerator * b.denominator, a.denominator * b.numerator);

        // Comparison operators 
        public  bool operator ==(Rational a, Rational b) 
            => a.numerator == b.numerator && a.denominator == b.denominator;
        public  bool operator !=(Rational a, Rational b) 
            => a.numerator != b.numerator || a.denominator != b.denominator;
        public  bool operator <(Rational a, Rational b)
            => a.numerator * b.denominator < a.denominator * b.numerator;
        public  bool operator <=(Rational a, Rational b)
            => a.numerator * b.denominator <= a.denominator * b.numerator;
        public  bool operator >(Rational a, Rational b) => !(a <= b);
        public  bool operator >=(Rational a, Rational b) => !(a < b);

        // Conversion operators
        public  implicit operator decimal(Rational r) => (decimal)r.numerator / (decimal)r.denominator;
        public  explicit operator Rational(decimal dec) => FromDecimal(dec);


        public override string ToString()
        {
            return Denominator > 1 ? $""{Numerator}/{Denominator}"" : Numerator.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Rational && (Rational)obj == this;
        }

        public override int GetHashCode()
        {
            return (13 + numerator.GetHashCode()) * 31 + denominator.GetHashCode();
        }

         int GCD(int a, int b) => (b == 0) ? a : GCD(b, a % b);
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
        Rational sumResult;
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
        Rational sumResult;
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
        Rational sumResult;
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
        public string? Description { get; set; } = @"C# content  has  several  numeric  types  including  natural,  real  and  irrational  numbers.  one  numeric  type  that's  missing  is  a  rational  number.  a  rational  number,  as  the  name  suggests,  is  a  ratio  between  two  natural  numbers  and  is  usually  represented  as  a  fraction  in  the  form  1/2,  5/4,  -79/13,  etc.

in  part  1  of  this  challenge,  you  were  asked  to  create  a  c#  struct  with  a  c""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
