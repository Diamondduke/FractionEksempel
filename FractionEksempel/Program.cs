namespace FractionEksempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction oneHalf = new(1,2);
            Fraction oneThird = new(1,3);

            Fraction sum = oneHalf.Add(oneThird);
            Console.WriteLine(sum);

            Fraction sumNonstaticMethod = oneHalf.Add(oneThird);
            Console.WriteLine(sumNonstaticMethod.ToText());

            Fraction sumStaticMethod = oneHalf.Add(oneThird);
            Console.WriteLine(sumStaticMethod.ToText());

            Fraction substraction = oneHalf.Substraction(oneThird);
            Console.WriteLine(substraction.ToText());

            Fraction multiply = oneHalf.Multiplication(oneThird);
            Console.WriteLine(multiply.ToText());

            Fraction divide = oneHalf.Division(oneThird);
            Console.WriteLine(divide.ToText());

        }
    }
}