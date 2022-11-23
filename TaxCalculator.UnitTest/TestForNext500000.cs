using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;

public class TestForNext500000
{
          private ICalculateTaxService calculateTaxService;
          
          [SetUp]
          public void SetUp()
          {
                    calculateTaxService = new CalculateTaxService();
          }
          [Test]
          [TestCase(-900000, 0)]
          public void CalculateTaxForNext500000_IncomeLessThanZero_ReturnZero(decimal income, decimal expectedResult)
          {
          decimal result = calculateTaxService.CalculateTaxForNext500000(income);
          Assert.AreEqual(result, expectedResult);
          }
          
          
          [Test]
          [TestCase(0, 0)]
          public void CalculateTaxForNext500000_IncomeEqualZero_ReturnZero(decimal income, decimal expectedResult)
          {
          decimal result = calculateTaxService.CalculateTaxForNext500000(income);
          Assert.AreEqual(result, expectedResult);
          }


          [Test]
          [TestCase(300000, 57000)]
          public void CalculateTaxForNext500000_IncomeLessThan500000_Return15PercentOfIncome(decimal income, decimal expectedResult)
          {
          decimal result = calculateTaxService.CalculateTaxForNext500000(income);
          Assert.AreEqual(result, expectedResult);
          }

          [Test]
          [TestCase(500000, 95000)]
          public void CalculateTaxForNext500000_IncomeGreaterThanOrEqual500000_Return75000(decimal income, decimal expectedResult)
          {
          decimal result = calculateTaxService.CalculateTaxForNext500000(income);
          Assert.AreEqual(result, expectedResult);
          }

}
