using Microsoft.AspNetCore.Mvc;
using TaxCalculatorProject;

namespace TaxCalculate.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaxableIncomeController : ControllerBase
{
          private readonly ITaxableIncomeService _taxableIncomeService;
          public TaxableIncomeController(ITaxableIncomeService taxableIncomeService)
          {
                    _taxableIncomeService = taxableIncomeService;
          }
          [HttpGet("CalculateTaxableIncome/{income}")]
          public IActionResult CalculateTaxableIncome([FromRoute]decimal income)
          {
                    var taxableIncome = _taxableIncomeService.CalculateTaxableIncome(income);
                    return Ok(taxableIncome);
          }

          [HttpGet("CalculatePension/{income}")]
          public IActionResult CalculatePension([FromRoute]decimal income)
          {
                    var taxableIncome = _taxableIncomeService.CalculatePension(income);
                    return Ok(taxableIncome);
          }

          [HttpGet("CRA/{income}")]
          public IActionResult CRA([FromRoute]decimal income)
          {
                    var taxableIncome = _taxableIncomeService.ConsolidatedReliefAllowance(income);
                    return Ok(taxableIncome);
          }
}
