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
        [Test]
        public void Equals_TwoFractions_ReturnsExpectedSum()
        {
            //Arrange
            Fraction fraction1 = new(4, 8);
            Fraction fraction2 = new(2, 4);
            Fraction expected = new(1, 2);

            //Act
            Fraction actual = fraction1.Add(fraction2);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

            Assert.That(actual.Numenator, Is.EqualTo(expected.Numenator));
            Assert.That(actual.Denominator, Is.EqualTo(expected.Denominator));
        }
        
        [Test]
        public void Divide_TwoFractions_ReturnsExpectedSum()
        {
            //Arrange
            Fraction fraction1 = new(4, 4);
            Fraction fraction2 = new(2, 4);
            Fraction expected = new(2, 1);

            //Act
            Fraction actual = fraction1.Division(fraction2);

            //Assert
            Assert.That(actual.Numenator, Is.EqualTo(expected.Numenator));
            Assert.That(actual.Denominator, Is.EqualTo(expected.Denominator));
        }

    }
}