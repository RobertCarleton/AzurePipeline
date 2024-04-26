using NUnit.Framework;
using Moq;
using SQTAssignment_Tests;
using SQTAssignment;


namespace SQTAssignment_Tests
{
    [TestFixture]
    internal class Program
    {
        [Test]
        public static void Test1()
        {
            //SQTAssignment.InsuranceService myClass = new SQTAssignment.InsuranceService();


            // Arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            InsuranceService insurance = new InsuranceService(mockDiscountService.Object);

            // Act
            double result = insurance.CalcPremium(20, "rural");

            // Assert
            //Assert.AreEqual("It's hot!", wea`therDescription); // classic
            Assert.That(result, Is.EqualTo(5)); // constraint

        }


        [Test]
        public static void Test2()
        {


            // Arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            InsuranceService insurance = new InsuranceService(mockDiscountService.Object);

            // Act
            double result = insurance.CalcPremium(16, "rural");

            // Assert

            Assert.That(result, Is.EqualTo(0)); // constraint

        }

        [Test]
        public static void Test3()
        {


            // Arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            InsuranceService insurance = new InsuranceService(mockDiscountService.Object);

            // Act
            double result = insurance.CalcPremium(32, "rural");

            // Assert

            Assert.That(result, Is.EqualTo(2.5)); // constraint

        }
        [Test]
        public static void Test4()
        {


            // Arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            InsuranceService insurance = new InsuranceService(mockDiscountService.Object);

            // Act
            double result = insurance.CalcPremium(21, "urban");

            // Assert

            Assert.That(result, Is.EqualTo(6)); // constraint

        }
        [Test]
        public static void Test5()
        {


            // Arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            InsuranceService insurance = new InsuranceService(mockDiscountService.Object);

            // Act
            double result = insurance.CalcPremium(17, "urban");

            // Assert

            Assert.That(result, Is.EqualTo(0)); // constraint

        }
        [Test]
        public static void Test6()
        {


            // Arrange
            var mockDiscountService = new Mock<IDiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            InsuranceService insurance = new InsuranceService(mockDiscountService.Object);

            // Act
            double result = insurance.CalcPremium(37, "urban");

            // Assert

            Assert.That(result, Is.EqualTo(5)); // constraint

        }
    }
}
