using Microsoft.AspNetCore.Mvc;
using TaxCalculatorProject;

namespace TaxCalculate.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaxCalculatorController : ControllerBase
{
           private readonly ICalculateTaxService _calculateTaxService;
           private readonly ITaxableIncomeService _taxableIncomeService;
           public TaxCalculatorController(ICalculateTaxService calculateTaxService, ITaxableIncomeService taxableIncomeService)
           {
                    _calculateTaxService = calculateTaxService;
                    _taxableIncomeService = taxableIncomeService;
           }
           [HttpGet("CalculateTax/{income}")]
           public IActionResult CalculateTax([FromRoute] decimal income)
           {
                    var taxableIncome = _taxableIncomeService.CalculateTaxableIncome(income);
                    var pension = _taxableIncomeService.CalculatePension(income * 12);
                    var cra = _taxableIncomeService.ConsolidatedReliefAllowance(income * 12); 
                    var tax = _calculateTaxService.GeneralCalc(income);
                    var response = new{Taxable=taxableIncome/12, Pension = pension/ 12, Tax = tax, CRA= cra/12};
                    return Ok(response);
           }
}
