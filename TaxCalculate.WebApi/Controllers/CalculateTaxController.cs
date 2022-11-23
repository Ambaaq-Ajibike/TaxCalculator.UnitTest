using Microsoft.AspNetCore.Mvc;
using TaxCalculatorProject;

namespace TaxCalculate.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculateTaxController : ControllerBase
{
          private readonly ICalculateTaxService _calculateTaxService;
          public CalculateTaxController(ICalculateTaxService calculateTaxService)
          {
                    _calculateTaxService = calculateTaxService;
          }
          [HttpGet("CalculateTax/{income}")]
          public IActionResult CalculateTax([FromRoute]decimal income)
          {
                    var response = _calculateTaxService.GeneralCalc(income);
                    
                    return Ok(response);
          }
}
