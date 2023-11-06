namespace FractionEksempel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction oneHalef = new(1,2);
            Fraction oneThird = new(1,3);

            Fraction sum = oneHalef.Add(oneThird);
            Console.WriteLine(sum);

            Fraction sumNonstaticMethod = oneHalef.Add(oneThird);
            Console.WriteLine(sumNonstaticMethod.ToText());

            Fraction sumStaticMethod = oneHalef.Add(oneThird);
            Console.WriteLine(sumNonstaticMethod.ToText());
        }
    }
}