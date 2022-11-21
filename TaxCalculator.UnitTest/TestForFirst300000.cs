using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;

public class TestForFirst300000
{
          private CalculateTaxService taxService;

          [SetUp]
          public void Setup()
          {
                    this.taxService = new CalculateTaxService();
          }

          [Test]
          [TestCase(200000, 14000)]
          public void CalculateTaxForFirst300000_IncomeLessThan300000_Return7PercentOfIncome(decimal income, decimal expectedResult)
          {
                    decimal result = taxService.CalculateTaxForFirst300000(income);
                    Assert.That(result, Is.EqualTo(expectedResult));
          }
          [Test]
          [TestCase(300000, 21000)]
          public void CalculateTaxForFirst300000_IncomeGreaterThanOrEqual300000_Return21000(decimal income, decimal expectedResult)
          {
                    decimal result = taxService.CalculateTaxForFirst300000(income);
                    Assert.That(result, Is.EqualTo(expectedResult));
          }
}
