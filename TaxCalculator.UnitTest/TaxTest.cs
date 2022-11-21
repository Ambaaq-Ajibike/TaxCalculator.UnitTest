using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;
[TestFixture]
public class TaxTest
{
    private CalculateTaxService taxService;
    private TaxableIncomeService taxableIncomeService;
    [SetUp]
    public void Setup()
    {
        taxableIncomeService = new TaxableIncomeService();
        taxService = new CalculateTaxService(taxableIncomeService);
    }
    [Test]
    [TestCase(50000, 2744000)]
    public void CalculateTaxableIncome_WhenCalled_ReturnTaxableIncome(decimal income, decimal expectedResult)
    {
        decimal result = taxableIncomeService.CalculateTaxableIncome(income);
        Assert.AreEqual(result, expectedResult);
    }
    [Test]
    [TestCase(300000)] 
    public void GeneralCalc_WhenCalled_ReturnMonthlyTax(decimal income)
    {
        decimal result = taxService.GeneralCalc(income);
        Assert.AreEqual(result, 33534.666666666666666666666667m);
    }
}