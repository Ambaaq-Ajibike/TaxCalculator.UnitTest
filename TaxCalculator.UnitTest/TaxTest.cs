using TaxCalculatorProject;

namespace TaxCalculator.UnitTest;
[TestFixture]
public class TaxTest
{
    private CalculateTaxService taxService;
    private ITaxableIncomeService taxableIncomeService;
    [SetUp]
    public void Setup()
    {
        taxableIncomeService = new TaxableIncomeService();
        taxService = new CalculateTaxService(taxableIncomeService);
    }
 
    [Test]
    [TestCase(300000)] 
    public void GeneralCalc_WhenCalled_ReturnMonthlyTax(decimal income)
    {
        decimal result = taxService.GeneralCalc(income);
        Assert.AreEqual(result, 33534.666666666666666666666667m);
    }
}