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
            return $"{Numenator}/{Denominator}";
        }
        #endregion Public Methods
    }
}