using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;

public class TestForFirst500000
{
          private ICalculateTaxService calculateTax;
          [SetUp]
          public void SetUp()
          {
                    calculateTax = new CalculateTaxService();
          }

           [Test]
          [TestCase(-900000, 0)]
          public void CalculateTaxForFirst500000_IncomeLessThanZero_ReturnZero(decimal income, decimal expectedResult)
          {
          decimal result = calculateTax.CalculateTaxForFirst500000(income);
          Assert.AreEqual(result, expectedResult);
          }
          
          
          [Test]
          [TestCase(0, 0)]
          public void CalculateTaxForFirst500000_IncomeEqualZero_ReturnZero(decimal income, decimal expectedResult)
          {
          decimal result = calculateTax.CalculateTaxForFirst500000(income);
          Assert.AreEqual(result, expectedResult);
          }


          [Test]
          [TestCase(300000, 45000)]
          public void CalculateTaxForFirst500000_IncomeLessThan500000_Return15PercentOfIncome(decimal income, decimal expectedResult)
          {
          decimal result = calculateTax.CalculateTaxForFirst500000(income);
          Assert.AreEqual(result, expectedResult);
          }

          [Test]
          [TestCase(500000, 75000)]
          public void CalculateTaxForFirst500000_IncomeGreaterThanOrEqual500000_Return75000(decimal income, decimal expectedResult)
          {
          decimal result = calculateTax.CalculateTaxForFirst500000(income);
          Assert.AreEqual(result, expectedResult);
          }

}
