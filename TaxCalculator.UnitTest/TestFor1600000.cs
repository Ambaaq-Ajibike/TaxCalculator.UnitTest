using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;

public class TestFor1600000
{
          private ICalculateTaxService calculateTaxService;
          [SetUp]
          public void SetUp()
          {
                    calculateTaxService = new CalculateTaxService();
          }
          [Test]
          [TestCase(-900000, 0)]
          public void CalculateTaxFor1600000_IncomeLessThanZero_ReturnZero(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxFor1600000(income);
                    Assert.AreEqual(result, expectedResult);
          }
          
          
          [Test]
          [TestCase(0, 0)]
          public void CalculateTaxFor1600000_IncomeEqualZero_ReturnZero(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxFor1600000(income);
                    Assert.AreEqual(result, expectedResult);
          }


          [Test]
          [TestCase(300000, 63000)]
          public void CalculateTaxFor1600000_IncomeLessThan1600000_Return21PercentOfIncome(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxFor1600000(income);
                    Assert.AreEqual(result, expectedResult);
          }

          [Test]
          [TestCase(1600000, 336000)]
          public void CalculateTaxFor1600000_IncomeGreaterThanOrEqual1600000_Return75000(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxFor1600000(income);
                    Assert.AreEqual(result, expectedResult);
          }



}
