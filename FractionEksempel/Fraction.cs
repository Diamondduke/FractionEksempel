using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionEksempel
{
    public class Fraction
    {
        #region Fields & propterties
        public int Numenator {  get; set; }
        public int Denominator {  get; set; }

        #endregion

        #region Constructors
        public Fraction(int numenator = 0, int denominator = 1) 
        {
            Numenator = numenator;
            Denominator = denominator;

            Reduce();
        }
        #endregion Constructors

        #region Public Methods

        public Fraction Add(Fraction other)
        {
            int numerator = (Numenator * other.Denominator) + (Denominator * other.Numenator);
            int denominator = Denominator * other.Denominator;

            Fraction sum = new(numerator, denominator);
            return sum;
        }

        //public Fraction Add(Fraction other) // Alternativ måte å gjøre det på.
        //{
        //    Fraction.Add(this, other);
              
        //}
        public Fraction Substraction(Fraction other)
        {
            int numerator = (Numenator * other.Denominator) - (Denominator * other.Numenator);
            int denominator = Denominator * other.Denominator;

            Fraction sum = new(numerator, denominator);
            return sum;
        }

        public Fraction Multiplication(Fraction other) 
        {
            int numerator = (Numenator * other.Numenator);
            int denominator = (Denominator * other.Denominator);

            Fraction sum = new(numerator, denominator);
            return sum;
        }

        public Fraction Division(Fraction other) 
        {
            int numerator = (Numenator * other.Denominator);
            int denominator = (Denominator * other.Numenator);

            Fraction sum = new(numerator, denominator);
            return sum;
        }

        //public bool Equals(Fraction other)
        //{
        //    //Fraction other = new(Numenator, Denominator);
        //    //((double)Numerator/Denominator == ((double)other.Numenator/other.Denominator)// Dette er det som kalles casting.

        //    if (Numenator == other.Numenator && Denominator == other.Denominator)
        //    {
        //        Console.WriteLine("True");
        //        return true;
        //    }

        //    else
        //    {
        //        Console.WriteLine("False");
        //        return false;
        //    }
            
        //}

        public bool GreaterThan(Fraction value)
        {
            //Fraction other = new(Numenator, Denominator);

            if ((Numenator / Denominator) > (value.Numenator / value.Denominator))
            {
                Console.WriteLine("True. Greater then");
                return true;
            }

            else
            {
                Console.WriteLine("False. Not greater than");
                return false;
            }

        }

        //static variant

        public static Fraction Add(Fraction left, Fraction right)
        {
            int numerator = (left.Numenator * right.Denominator) + (left.Denominator * right.Numenator);
            int denominator = left.Denominator * right.Denominator;

            Fraction sum = new(numerator, denominator);
            return sum;
        }

        //public string ToText()
        //{
        //    return $"{Numenator} / {Denominator}";
        //}

        public bool Equals(Fraction other)
        {
            return (Numenator * other.Denominator) == (other.Numenator * Denominator);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Fraction other)
            {
                return Equals(other);
            }
            else 
            { 
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Numenator} / {Denominator}";
        }

        //public Fraction Reduce(int numenator, int denominator), denne endte jeg opp med å ikke bruke
        public void Reduce()
        {
            for (int i = 2; i < Denominator; i++)
            {
                if (Numenator % i == 0 && Denominator % i == 0)
                {
                    Numenator /= i;
                    Denominator /= i;
                    i = 1; //so i = 2 when the loop starts again
                }
            }
        }

        #endregion Public Methods

        #region Operator Overloads
        public static Fraction operator +(Fraction left, Fraction right)
        {
            return left.Add(right);
            //return Fraction.Add(left, right);
        }

        public static Fraction operator -(Fraction left, Fraction right) 
        {
            return left.Substraction(right);
        }
        public static Fraction operator /(Fraction left, Fraction right)
        {
            return left.Division(right);
        }
        public static Fraction operator *(Fraction left, Fraction right)
        {
            return left.Multiplication(right);
        }

        #endregion Operator Overloads
    }
}