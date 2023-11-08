namespace FractionEksempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction oneHalf = new Fraction(); //Vi setter denne utenfor try blokken, sånn at den har en levetid gjennom hele programmet, ikke bare i blokken.
            Fraction oneThird = new Fraction();
            Fraction testFraction = new Fraction();

            try
            {
                oneHalf = new(1, 2);
                oneThird = new(1, 3);
                testFraction = new(4, 8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Fraction sum = oneHalf.Add(oneThird);
            Console.WriteLine(sum);

            Fraction sumNonstaticMethod = oneHalf.Add(oneThird);
            Console.WriteLine(sumNonstaticMethod.ToString());

            Fraction sumStaticMethod = oneHalf.Add(oneThird);
            Console.WriteLine(sumStaticMethod.ToString());

            Fraction sumOverloadAdd = oneHalf + oneThird; //Her bruker vi overload
            Console.WriteLine($"{sumOverloadAdd.ToString()} Dette overload Add");

            Fraction sumOverloadSubstration = oneHalf - testFraction; //Her bruker vi overload
            Console.WriteLine($"{sumOverloadSubstration.ToString()} Dette overload Substraction");

            Fraction sumOverloadDivision = oneHalf - testFraction; //Her bruker vi overload
            Console.WriteLine($"{sumOverloadDivision.ToString()} Dette overload Division");

            Fraction sumTest = oneHalf.Add(testFraction);
            Console.WriteLine(sumStaticMethod.ToString());

            Fraction substraction = oneHalf.Substraction(oneThird);
            Console.WriteLine(substraction.ToString());

            Fraction multiply = oneHalf.Multiplication(oneThird);
            Console.WriteLine(multiply.ToString());

            Fraction divide = oneHalf.Division(oneThird);
            Console.WriteLine(divide.ToString());

            Fraction equal = new(1,3);
            equal.Equals(oneThird);

            Fraction greaterThan = new(1, 1);
            greaterThan.GreaterThan(oneHalf);
        }
    }
}