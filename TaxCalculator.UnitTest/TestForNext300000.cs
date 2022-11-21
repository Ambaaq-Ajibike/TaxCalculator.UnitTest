using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;

public class TestForNext300000
{
          private CalculateTaxService calculateTaxService;
          [SetUp]
          public void SetUp()
          {
                    calculateTaxService = new CalculateTaxService();
          }
          [Test]
          [TestCase(-200000, 0)]
          public void CalculateTaxForNext300000_IncomeLessThanZero_ReturnZero(decimal income, decimal expectedResult)
          {
          decimal result = calculateTaxService.CalculateTaxForNext300000(income);
          Assert.AreEqual(result, expectedResult);
          }
          
          
          [Test]
          [TestCase(0, 0)]
          public void CalculateTaxForNext300000_IncomeEqualZero_ReturnZero(decimal income, decimal expectedResult)
          {
          decimal ans = calculateTaxService.CalculateTaxForNext300000(income);
          Assert.That(ans, Is.EqualTo(expectedResult));
          }
          
          
          [Test]
          [TestCase(20000, 2200)]
          public void CalculateTaxForNext300000_IncomeLessThan300000_Return33000(decimal income, decimal expectedResult)
          {
          decimal ans = calculateTaxService.CalculateTaxForNext300000(income);
          Assert.That(ans, Is.EqualTo(expectedResult));
          }
}
