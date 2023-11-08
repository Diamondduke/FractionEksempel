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
        int Numenator {  get; set; }
        int Denominator {  get; set; }

        #endregion

        #region Constructors
        public Fraction(int numenator = 0, int denominator = 1) 
        {
            Numenator = numenator;
            Denominator = denominator;
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

        public bool Equals(Fraction other)
        {
            //Fraction other = new(Numenator, Denominator);
            //((double)Numerator/Denominator == ((double)other.Numenator/other.Denominator)// Dette er det som kalles casting.

            if (Numenator == other.Numenator && Denominator == other.Denominator)
            {
                Console.WriteLine("True");
                return true;
            }

            else
            {
                Console.WriteLine("False");
                return false;
            }
            
        }

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

        public string ToText()
        {
            return $"{Numenator} / {Denominator}";
        }
        #endregion Public Methods
    }
}