namespace FractionEksempel.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TwoFractions_ReturnsExpectedSum()
        {
            //Arrange
            Fraction fraction1 = new(1, 4);
            Fraction fraction2 = new(2, 4);
            Fraction expected = new(12, 16); //Fordi vi ikke har reduce må jeg gjøre det på denne måten

            //Act
            Fraction actual = fraction1.Add(fraction2);

            //Assert
            Assert.That(actual.Numenator, Is.EqualTo(expected.Numenator));
            Assert.That(actual.Denominator, Is.EqualTo(expected.Denominator));
        }

        [Test]
        public void Multiplication_TwoFractions_ReturnsExpectedSum()
        {
            //Arrange
            Fraction fraction1 = new(1, 4);
            Fraction fraction2 = new(2, 4);
            Fraction expected = new(2, 16);

            //Act
            Fraction actual = fraction1.Multiplication(fraction2);

            //Assert
            Assert.That(actual.Numenator, Is.EqualTo(expected.Numenator));
            Assert.That(actual.Denominator, Is.EqualTo(expected.Denominator));
        }
    }
}