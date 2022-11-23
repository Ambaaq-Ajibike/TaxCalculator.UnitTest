using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;

public class TestForIncomeOver3200000
{
          private ICalculateTaxService calculateTaxService;
          [SetUp]
          public void SetUp()
          {
                    calculateTaxService = new CalculateTaxService();
          }
           [Test]
          [TestCase(-900000, 0)]
          public void CalculateTaxForIncomeOver3200000_IncomeLessThanZero_ReturnZero(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxForIncomeOver3200000(income);
                    Assert.AreEqual(result, expectedResult);
          }
          
          
          [Test]
          [TestCase(0, 0)]
          public void CalculateTaxForIncomeOver3200000_IncomeEqualZero_ReturnZero(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxForIncomeOver3200000(income);
                    Assert.AreEqual(result, expectedResult);
          }


          [Test]
          [TestCase(1600000, 384000)]
          public void CalculateTaxForIncomeOver3200000_IncomeLessThan3200000_Return24PercentOfIncome(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxForIncomeOver3200000(income);
                    Assert.AreEqual(result, expectedResult);
          }

          [Test]
          [TestCase(3200000, 768000)]
          public void CalculateTaxForIncomeOver3200000_IncomeGreaterThanOrEqual1600000_Return786000(decimal income, decimal expectedResult)
          {
                    decimal result = calculateTaxService.CalculateTaxForIncomeOver3200000(income);
                    Assert.AreEqual(result, expectedResult);
          }
}
