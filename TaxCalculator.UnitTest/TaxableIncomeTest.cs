using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;
[TestFixture]
public class TaxableIncomeTest
{
          private ITaxableIncomeService taxableIncomeService;
          [SetUp]
          public void SetUp()
          {
                    taxableIncomeService = new TaxableIncomeService();
          }
          [Test]
          [TestCase(50000, 4000)]
          public void CalculatePension_IncomeGreaterThanZero_Return8PercentOfIncome(decimal income, decimal expectedResult)
          {
                    decimal result = taxableIncomeService.CalculatePension(income);
                    Assert.AreEqual(result, expectedResult);
          }
          [Test]
          [TestCase(0)]
          public void CalculatePension_IncomeLessThanOrEqualZero_ThrowDivideByZeroException(decimal income)
          {
                    Assert.That(() => taxableIncomeService.CalculatePension(income), Throws.InvalidOperationException);
          }

          [Test]
          [TestCase(50000, 241600)]
          public void CalculateTaxableIncome_WhenCalled_ReturnTaxableIncome(decimal income, decimal expectedResult)
          {
                    decimal result = taxableIncomeService.CalculateTaxableIncome(income);
                    Assert.AreEqual(result, expectedResult);
          }
}
